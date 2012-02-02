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
// Generated by IDLImporter from file nsIDOMHTMLOptionsCollection.idl
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
	
	
	/// <summary>
    /// Introduced in DOM Level 2:
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("429b041b-06df-486c-9a3a-a1d901cc76a2")]
	public interface nsIDOMHTMLOptionsCollection
	{
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetLengthAttribute();
		
		/// <summary>
        /// Introduced in DOM Level 2:
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLengthAttribute(uint aLength);
		
		/// <summary>
        /// FIXME item should just be inherited from nsIDOMHTMLCollection
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode Item(uint index);
		
		/// <summary>
        ///       multiple matching items
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode NamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name);
		
		/// <summary>
        /// Get the node for the name.  Returns null if no node exists for the name.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetNamedItem([MarshalAs(UnmanagedType.LPStruct)] nsAString name, ref System.IntPtr cache);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetSelectedIndexAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelectedIndexAttribute(int aSelectedIndex);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOption(uint index, [MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLOptionElement option);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMHTMLSelectElement GetSelectAttribute();
		
		/// <summary>
        ///   void add(in nsIDOMHTMLOptionElement, in long)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Add([MarshalAs(UnmanagedType.Interface)] nsIDOMHTMLOptionElement option, [MarshalAs(UnmanagedType.Interface)] nsIVariant before);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove(int index);
	}
}
