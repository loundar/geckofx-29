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
// Generated by IDLImporter from file nsIDocShellLoadInfo.idl
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
    /// The nsIDocShellLoadInfo interface defines an interface for specifying
    /// setup information used in a nsIDocShell::loadURI call.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("92a0a637-373e-4647-9476-ead11e005c75")]
	public interface nsIDocShellLoadInfo
	{
		
		/// <summary>
        ///This is the referrer for the load. </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetReferrerAttribute();
		
		/// <summary>
        ///This is the referrer for the load. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetReferrerAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aReferrer);
		
		/// <summary>
        ///The owner of the load, that is, the entity responsible for
        /// causing the load to occur. This should be a nsIPrincipal typically.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISupports GetOwnerAttribute();
		
		/// <summary>
        ///The owner of the load, that is, the entity responsible for
        /// causing the load to occur. This should be a nsIPrincipal typically.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerAttribute([MarshalAs(UnmanagedType.Interface)] nsISupports aOwner);
		
		/// <summary>
        ///If this attribute is true and no owner is specified, copy
        /// the owner from the referring document.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetInheritOwnerAttribute();
		
		/// <summary>
        ///If this attribute is true and no owner is specified, copy
        /// the owner from the referring document.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInheritOwnerAttribute([MarshalAs(UnmanagedType.Bool)] bool aInheritOwner);
		
		/// <summary>
        ///If this attribute is true only ever use the owner specify by
        /// the owner and inheritOwner attributes.
        /// If there are security reasons for why this is unsafe, such
        /// as trying to use a systemprincipal owner for a content docshell
        /// the load fails.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetOwnerIsExplicitAttribute();
		
		/// <summary>
        ///If this attribute is true only ever use the owner specify by
        /// the owner and inheritOwner attributes.
        /// If there are security reasons for why this is unsafe, such
        /// as trying to use a systemprincipal owner for a content docshell
        /// the load fails.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOwnerIsExplicitAttribute([MarshalAs(UnmanagedType.Bool)] bool aOwnerIsExplicit);
		
		/// <summary>
        ///Contains a load type as specified by the load* constants </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetLoadTypeAttribute();
		
		/// <summary>
        ///Contains a load type as specified by the load* constants </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLoadTypeAttribute(System.IntPtr aLoadType);
		
		/// <summary>
        ///SHEntry for this page </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISHEntry GetSHEntryAttribute();
		
		/// <summary>
        ///SHEntry for this page </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSHEntryAttribute([MarshalAs(UnmanagedType.Interface)] nsISHEntry aSHEntry);
		
		/// <summary>
        ///Target for load, like _content, _blank etc. </summary>
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		string GetTargetAttribute();
		
		/// <summary>
        ///Target for load, like _content, _blank etc. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTarget);
		
		/// <summary>
        ///Post data </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetPostDataStreamAttribute();
		
		/// <summary>
        ///Post data </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPostDataStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aPostDataStream);
		
		/// <summary>
        ///Additional headers </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream GetHeadersStreamAttribute();
		
		/// <summary>
        ///Additional headers </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeadersStreamAttribute([MarshalAs(UnmanagedType.Interface)] nsIInputStream aHeadersStream);
		
		/// <summary>
        ///True if the referrer should be sent, false if it shouldn't be
        /// sent, even if it's available. This attribute defaults to true.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSendReferrerAttribute();
		
		/// <summary>
        ///True if the referrer should be sent, false if it shouldn't be
        /// sent, even if it's available. This attribute defaults to true.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSendReferrerAttribute([MarshalAs(UnmanagedType.Bool)] bool aSendReferrer);
	}
}
