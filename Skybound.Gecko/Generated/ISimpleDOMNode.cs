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
// Generated by IDLImporter from file ISimpleDOMNode.idl
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
	
	
	/// <summary>ISimpleDOMNode </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("1814ceeb-49e2-407f-af99-fa755a7d2607")]
	public interface ISimpleDOMNode
	{
		
		/// <summary>
        /// In Win32 accessible events we generate, the target's childID matches to this
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort get_NodeInfo([MarshalAs(UnmanagedType.BStr)] ref string nodeName, ref short nameSpaceID, [MarshalAs(UnmanagedType.BStr)] ref string nodeValue, ref uint numChildren, ref uint uniqueID);
		
		/// <summary>Member get_Attributes </summary>
		/// <param name='maxAttribs'> </param>
		/// <param name='attribNames'> </param>
		/// <param name='nameSpaceID'> </param>
		/// <param name='attribValues'> </param>
		/// <returns>A System.UInt16</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort get_Attributes(ushort maxAttribs, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] ref string attribNames, ref short nameSpaceID, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] ref string attribValues);
		
		/// <summary>Member get_AttributesForNames </summary>
		/// <param name='numAttribs'> </param>
		/// <param name='attribNames'> </param>
		/// <param name='nameSpaceID'> </param>
		/// <returns>A System.String</returns>
		[return: MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string get_AttributesForNames(ushort numAttribs, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] string attribNames, short nameSpaceID);
		
		/// <summary>
        /// If TRUE, returns properites for media as set in nsIDOMDocument::set_alternateViewMediaTypes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort get_ComputedStyle(ushort maxStyleProperties, [MarshalAs(UnmanagedType.Bool)] bool useAlternateView, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] ref string styleProperties, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] ref string styleValues);
		
		/// <summary>
        /// If TRUE, returns properites for media as set in nsIDOMDocument::set_alternateViewMediaTypes
        /// </summary>
		[return: MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string get_ComputedStyleForProperties(ushort numStyleProperties, [MarshalAs(UnmanagedType.Bool)] bool useAlternateView, [MarshalAs(UnmanagedType.BStr, SizeParamIndex=0)] string styleProperties);
		
		/// <summary>Member ScrollTo </summary>
		/// <param name='placeTopLeft'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint ScrollTo([MarshalAs(UnmanagedType.Bool)] bool placeTopLeft);
		
		/// <summary>Gets a ParentNode </summary>
		/// <returns>A ISimpleDOMNode </returns>
		ISimpleDOMNode ParentNode
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
		
		/// <summary>Gets a FirstChild </summary>
		/// <returns>A ISimpleDOMNode </returns>
		ISimpleDOMNode FirstChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
		
		/// <summary>Gets a LastChild </summary>
		/// <returns>A ISimpleDOMNode </returns>
		ISimpleDOMNode LastChild
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
		
		/// <summary>Gets a PreviousSibling </summary>
		/// <returns>A ISimpleDOMNode </returns>
		ISimpleDOMNode PreviousSibling
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
		
		/// <summary>Gets a NextSibling </summary>
		/// <returns>A ISimpleDOMNode </returns>
		ISimpleDOMNode NextSibling
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
		
		/// <summary>Member get_ChildAt </summary>
		/// <param name='childIndex'> </param>
		/// <returns>A ISimpleDOMNode</returns>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ISimpleDOMNode get_ChildAt(uint childIndex);
		
		/// <summary>Gets a InnerHTML </summary>
		/// <returns>A System.String </returns>
		string InnerHTML
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
		
		/// <summary>Gets a LocalInterface </summary>
		/// <returns>A System.IntPtr </returns>
		System.IntPtr LocalInterface
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			get;
		}
		
		/// <summary>Gets a Language </summary>
		/// <returns>A System.String </returns>
		string Language
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
	}
}
