// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIHTMLObjectResizer.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIHTMLObjectResizer </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8b396020-69d3-451f-80c1-1a96a7da25a9")]
	public interface nsIHTMLObjectResizer
	{
		
		/// <summary>
        /// the element currently displaying resizers
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMElement GetResizedObjectAttribute();
		
		/// <summary>
        /// a boolean indicating if object resizing is enabled in the editor
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetObjectResizingEnabledAttribute();
		
		/// <summary>
        /// a boolean indicating if object resizing is enabled in the editor
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetObjectResizingEnabledAttribute([MarshalAs(UnmanagedType.U1)] bool aObjectResizingEnabled);
		
		/// <summary>
        /// Shows active resizers around an element's frame
        /// @param aResizedElement [IN] a DOM Element
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ShowResizers([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aResizedElement);
		
		/// <summary>
        /// Hide resizers if they are visible
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HideResizers();
		
		/// <summary>
        /// Refresh visible resizers
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RefreshResizers();
		
		/// <summary>
        /// event callback when a mouse button is pressed
        /// @param aX      [IN] horizontal position of the pointer
        /// @param aY      [IN] vertical position of the pointer
        /// @param aTarget [IN] the element triggering the event
        /// @param aMouseEvent [IN] the event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MouseDown(int aX, int aY, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTarget, [MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aMouseEvent);
		
		/// <summary>
        /// event callback when a mouse button is released
        /// @param aX      [IN] horizontal position of the pointer
        /// @param aY      [IN] vertical position of the pointer
        /// @param aTarget [IN] the element triggering the event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MouseUp(int aX, int aY, [MarshalAs(UnmanagedType.Interface)] nsIDOMElement aTarget);
		
		/// <summary>
        /// event callback when the mouse pointer is moved
        /// @param aMouseEvent [IN] the event
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MouseMove([MarshalAs(UnmanagedType.Interface)] nsIDOMEvent aMouseEvent);
		
		/// <summary>
        /// Creates a resize listener that can be used to get notifications
        /// that the user started to resize an object or finalized such an operation
        /// @param aListener [IN] an instance of nsIHTMLObjectResizeListener
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddObjectResizeEventListener([MarshalAs(UnmanagedType.Interface)] nsIHTMLObjectResizeListener aListener);
		
		/// <summary>
        /// Deletes a resize listener
        /// @param aListener [IN] an instance of nsIHTMLObjectResizeListener
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RemoveObjectResizeEventListener([MarshalAs(UnmanagedType.Interface)] nsIHTMLObjectResizeListener aListener);
	}
}
