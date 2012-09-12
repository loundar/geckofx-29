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
// Generated by IDLImporter from file xpcexception.idl
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

	
	
	/// <summary>nsIXPCException </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("cac29630-7bf2-4e22-811b-46855a7d5af0")]
	public interface nsIXPCException : nsIException
	{
		
		/// <summary>
        /// A custom message set by the thrower.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetMessageAttribute();
		
		/// <summary>
        /// The nsresult associated with this exception.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new int GetResultAttribute();
		
		/// <summary>
        /// The name of the error code (ie, a string repr of |result|)
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetNameAttribute();
		
		/// <summary>
        /// null indicates "no data"
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string GetFilenameAttribute();
		
		/// <summary>
        /// Valid line numbers begin at '1'. '0' indicates unknown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetLineNumberAttribute();
		
		/// <summary>
        /// We don't have an unambiguous indicator for unknown.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetColumnNumberAttribute();
		
		/// <summary>
        /// A stack trace, if available.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIStackFrame GetLocationAttribute();
		
		/// <summary>
        /// An inner exception that triggered this, if available.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsIException GetInnerAttribute();
		
		/// <summary>
        /// Arbitary data for the implementation.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsISupports GetDataAttribute();
		
		/// <summary>
        /// A generic formatter - make it suitable to print, etc.
        /// </summary>
		[return: MarshalAs(UnmanagedType.LPStr)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new string ToString();
		
		/// <summary>
        /// inherits methods from nsIException
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Initialize([MarshalAs(UnmanagedType.LPStr)] string aMessage, int aResult, [MarshalAs(UnmanagedType.LPStr)] string aName, [MarshalAs(UnmanagedType.Interface)] nsIStackFrame aLocation, [MarshalAs(UnmanagedType.Interface)] nsISupports aData, [MarshalAs(UnmanagedType.Interface)] nsIException aInner);
		
		/// <summary>Member StealJSVal </summary>
		/// <returns>A System.IntPtr</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr StealJSVal();
		
		/// <summary>Member StowJSVal </summary>
		/// <param name='cx'> </param>
		/// <param name='val'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StowJSVal(System.IntPtr cx, System.IntPtr val);
	}
}
