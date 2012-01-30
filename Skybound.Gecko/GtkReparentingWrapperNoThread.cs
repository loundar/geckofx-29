#if GTK
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gdk;

namespace GtkDotNet
{
	public class GtkReparentingWrapperNoThread : GtkWrapperNoThread
	{
		/// <summary>
		/// The Winform control that m_popupWindow is reparented into.
		/// </summary>
		protected Control m_parent;
		
		/// <summary>
		/// Gdk wrapper created from m_parent handle.
		/// </summary>
		protected Gdk.Window m_gdkWrapperOfForm;
		
		#region XSetInputFocus
		[DllImport("libgdk-x11-2.0.so.0")]
		internal static extern IntPtr gdk_x11_drawable_get_xid(IntPtr gdkDrawable);

		[DllImport("libgdk-x11-2.0.so.0")]
		internal static extern IntPtr gdk_x11_display_get_xdisplay(IntPtr display);

		public enum RevertTo
		{
			None = 0,
			PointerRoot = 1,
			Parent = 2
		}
	
		[DllImport ("X11")]
		public extern static int XSetInputFocus(IntPtr display, IntPtr window, RevertTo revert_to, IntPtr time);

		IntPtr m_xDisplayPointer;		
		#endregion
		
		/// <summary>
		/// popupWindow must be a Gtk.Window of type WindowType.Popup
		/// parent is winform control which the popupWindow is embeded into.
		/// </summary>
		public GtkReparentingWrapperNoThread(Gtk.Window popupWindow, System.Windows.Forms.Control parent)
		{
			if (popupWindow.Type != Gtk.WindowType.Popup)
			{
				throw new ArgumentException("Gtk Window should be of type Popup.");
			}

			m_parent = parent;
			m_popupWindow = popupWindow;
			m_parent.HandleCreated += HandleParentCreated;
			m_parent.Resize += HandleParentResize;
		}
		
		public override void Init()
		{
			base.Init();
						
			EmbedWidgetIntoWinFormPanel();
		}
		
		void HandleParentCreated(object sender, EventArgs e)
		{			
			System.Windows.Forms.Application.Idle += HandleSystemWindowsFormsApplicationIdle;
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
		
		protected void EmbedWidgetIntoWinFormPanel()
		{		
			if (m_gdkWrapperOfForm != null)
				return;

			// Wraps the panel native (X) window handle in a GdkWrapper
			m_gdkWrapperOfForm = Gdk.Window.ForeignNewForDisplay(Gdk.Display.Default, (uint)m_parent.Handle);

			m_parent.HandleCreated += delegate {
				// get low level access to x11 events
				Gdk.Window.AddFilterForAll(FilterFunc);
			};
			System.Windows.Forms.Application.DoEvents();
			ProcessPendingGtkEvents();

			// embed m_popupWindow into winform (m_parent)
			m_popupWindow.GdkWindow.Reparent(m_gdkWrapperOfForm, 0, 0);
			ProcessPendingGtkEvents();
			
			// Setting the m_xDisplayPointer could possibly be done earlier if needed.
			Gdk.Display display = Gdk.Display.Default;	
			m_xDisplayPointer = gdk_x11_display_get_xdisplay(display.Handle);
		}
		
		private FilterReturn FilterFunc (IntPtr xevent, Event evnt)
		{
			if (xevent == IntPtr.Zero)
				return FilterReturn.Continue;

			var e = (X11.XEvent)Marshal.PtrToStructure(xevent, typeof(X11.XEvent));

			// Dropping these events is non standard but so is embeding a Gtk into
			// a X11 Window.
			if (e.type == X11.XEventName.FocusOut ||
				e.type == X11.XEventName.LeaveNotify)
			{
				return FilterReturn.Remove;
			}

			// Everything else just process as normal
			return FilterReturn.Continue;
		}
		
		protected override void Cleanup()
		{			
			// TODO: reparent back into m_popupWindow before destroying Window.
			
			base.Cleanup();
		}
		
		public override void SetInputFocus()
		{
			IntPtr xWindow = gdk_x11_drawable_get_xid(m_popupWindow.GdkWindow.Handle);
			XSetInputFocus(m_xDisplayPointer, xWindow, RevertTo.Parent, IntPtr.Zero);
		}
		
		public override void RemoveInputFocus()
		{
			IntPtr xWindow = gdk_x11_drawable_get_xid(m_popupWindow.GdkWindow.Handle);
			XSetInputFocus(m_xDisplayPointer, IntPtr.Zero, RevertTo.Parent, IntPtr.Zero);
		}
	}
}
#endif