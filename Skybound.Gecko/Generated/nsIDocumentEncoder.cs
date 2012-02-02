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
// Generated by IDLImporter from file nsIDocumentEncoder.idl
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
	
	
	/// <summary>nsIDocumentEncoderNodeFixup </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c0da5b87-0ba7-4d7c-8cb3-fcb02af4253d")]
	public interface nsIDocumentEncoderNodeFixup
	{
		
		/// <summary>
        /// Create a fixed up version of a node. This method is called before
        /// each node in a document is about to be persisted. The implementor
        /// may return a new node with fixed up attributes or null. If null is
        /// returned the node should be used as-is.
        /// @param aNode Node to fixup.
        /// @param [OUT] aSerializeCloneKids True if the document encoder should
        /// apply recursive serialization to the children of the fixed up node
        /// instead of the children of the original node.
        /// @return The resulting fixed up node.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIDOMNode FixupNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode, [MarshalAs(UnmanagedType.U1)] ref bool aSerializeCloneKids);
	}
	
	/// <summary>nsIDocumentEncoder </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7222bdf1-c2b9-41f1-a40a-a3d65283a95b")]
	public interface nsIDocumentEncoder
	{
		
		/// <summary>
        /// Initialize with a pointer to the document and the mime type.
        /// @param aDocument Document to encode.
        /// @param aMimeType MimeType to use. May also be set by SetMimeType.
        /// @param aFlags Flags to use while encoding. May also be set by SetFlags.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMDocument aDocument, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMimeType, uint aFlags);
		
		/// <summary>Member NativeInit </summary>
		/// <param name='aDocument'> </param>
		/// <param name='aMimeType'> </param>
		/// <param name='aFlags'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void NativeInit(System.IntPtr aDocument, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMimeType, uint aFlags);
		
		/// <summary>
        /// If the selection is set to a non-null value, then the
        /// selection is used for encoding, otherwise the entire
        /// document is encoded.
        /// @param aSelection The selection to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSelection([MarshalAs(UnmanagedType.Interface)] nsISelection aSelection);
		
		/// <summary>
        /// If the range is set to a non-null value, then the
        /// range is used for encoding, otherwise the entire
        /// document or selection is encoded.
        /// @param aRange The range to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRange([MarshalAs(UnmanagedType.Interface)] nsIDOMRange aRange);
		
		/// <summary>
        /// If the node is set to a non-null value, then the
        /// node is used for encoding, otherwise the entire
        /// document or range or selection is encoded.
        /// @param aNode The node to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aNode);
		
		/// <summary>
        /// If the container is set to a non-null value, then its
        /// child nodes are used for encoding, otherwise the entire
        /// document or range or selection or node is encoded.
        /// @param aContainer The node which child nodes will be encoded.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetContainerNode([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aContainer);
		
		/// <summary>Member SetNativeContainerNode </summary>
		/// <param name='aContainer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeContainerNode(System.IntPtr aContainer);
		
		/// <summary>
        /// Documents typically have an intrinsic character set,
        /// but if no intrinsic value is found, the platform character set
        /// is used. This function overrides both the intrinisc and platform
        /// charset.
        /// @param aCharset Overrides the both the intrinsic or platform
        /// character set when encoding the document.
        ///
        /// Possible result codes: NS_ERROR_NO_CHARSET_CONVERTER
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCharset([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aCharset);
		
		/// <summary>
        /// Set a wrap column.  This may have no effect in some types of encoders.
        /// @param aWrapColumn Column to which to wrap.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetWrapColumn(uint aWrapColumn);
		
		/// <summary>
        /// The mime type preferred by the encoder.  This piece of api was
        /// added because the copy encoder may need to switch mime types on you
        /// if you ask it to copy html that really represents plaintext content.
        /// Call this AFTER Init() and SetSelection() have both been called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetMimeTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aMimeType);
		
		/// <summary>
        /// Encode the document and send the result to the nsIOutputStream.
        ///
        /// Possible result codes are the stream errors which might have
        /// been encountered.
        /// @param aStream Stream into which to encode.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStream([MarshalAs(UnmanagedType.Interface)] nsIOutputStream aStream);
		
		/// <summary>
        /// Encode the document into a string.
        ///
        /// @return The document encoded into a string.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToString([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Encode the document into a string. Stores the extra context information
        /// into the two arguments.
        /// @param [OUT] aContextString The string where the parent hierarchy
        /// information will be stored.
        /// @param [OUT] aInfoString The string where extra context info will
        /// be stored.
        /// @return The document encoded as a string.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void EncodeToStringWithContext([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aContextString, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aInfoString, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Set the fixup object associated with node persistence.
        /// @param aFixup The fixup object.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNodeFixup([MarshalAs(UnmanagedType.Interface)] nsIDocumentEncoderNodeFixup aFixup);
	}
}
