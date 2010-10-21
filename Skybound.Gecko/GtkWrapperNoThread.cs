using Gdk;
using Gtk;
using System;
using System.Windows.Forms;

namespace GtkDotNet
{
	/// <summary>
	/// Allows embeding of a Gtk Window in Winforms control. The gtk event loop is run using  Winform idle processing.
	/// </summary>
	public class GtkWrapperNoThread
	{		
		/// <summary>
		/// The Gtk window which is embeded into m_parent.
		/// </summary>
		public Gtk.Window m_popupWindow;
		
		/// <summary>
		/// The Winform control that m_popupWindow is reparented into.
		/// </summary>
		protected Control m_parent;		
		
		/// <summary>
		/// Gdk wrapper created from m_parent handle.
		/// </summary>
		protected Gdk.Window m_gdkWrapperOfForm;	
				
		/// <summary>
		/// Stores if gtk has been initizlized.
		/// </summary>
		protected bool m_initedOnce = false;
							
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// parent is winform control which the popupWindow is embeded into.
		/// </summary>		
		public GtkWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent)
		{
			if (popupWindow.Type != Gtk.WindowType.Popup)
			{
				throw new ArgumentException("Gtk Window should be of type Popup.");	
			}
			
			m_parent = parent;
			m_popupWindow = popupWindow;			
			parent.HandleCreated += HandleParentCreated;			
			parent.Resize += HandleParentResize;
		}		

		void HandleParentResize(object sender, EventArgs e)
		{
			m_parent.Invalidate(true);
			
			if (m_popupWindow != null)
			{				
				m_popupWindow.SetSizeRequest(m_parent.Width, m_parent.Height);
				m_popupWindow.QueueDraw();				
			}
		}

		void HandleParentCreated(object sender, EventArgs e)
		{					
			System.Windows.Forms.Application.Idle += (senderArg, eventArg) => 
			{ 
				Init();
				ProcessPendingGtkEvents();	
			};
		}

		public void Init()		
		{
			if (m_initedOnce)
				return;
			
			lock(this)
			{				
				if (!m_initedOnce)
				{					
					Gtk.Application.Init();									
					EmbedWidgetIntoWinFormPanel();					
					m_initedOnce = true;
				}
			}
		}
				
		internal void ProcessPendingGtkEvents()
		{
			while (Gtk.Application.EventsPending()) {				
				Gtk.Application.RunIteration(false);
			}
		}
		
		protected void EmbedWidgetIntoWinFormPanel()
		{						
			m_popupWindow.ShowNow();
			m_popupWindow.Move(-5000, -5000);
			while (m_popupWindow.GdkWindow == null)
			{
				ProcessPendingGtkEvents();
			}
								
			// Wraps the panel native (X) window handle in a GdkWrapper 			
			m_gdkWrapperOfForm = Gdk.Window.ForeignNewForDisplay(Gdk.Display.Default, (uint)m_parent.Handle);
						
			System.Windows.Forms.Application.DoEvents();
			ProcessPendingGtkEvents();
						
			// embed m_popupWindow into winform (m_parent)
			m_popupWindow.GdkWindow.Reparent(m_gdkWrapperOfForm, 0, 0);											
			ProcessPendingGtkEvents();								
		}
	}
}

