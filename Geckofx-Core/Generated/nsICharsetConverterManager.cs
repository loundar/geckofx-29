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
// Generated by IDLImporter from file nsICharsetConverterManager.idl
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
	
	
	/// <summary>
    ///
    /// Here Charsets are identified by ASCII strings. Charset alias
    /// resolution is provided by default in most methods. "Raw"
    /// versions that do not need this resolution are also provided.
    ///
    /// @created         21/Feb/2000
    /// @author  Catalin Rotaru [CATA]
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a0550d46-8d9c-47dd-acc7-c083620dff12")]
	public interface nsICharsetConverterManager
	{
		
		/// <summary>
        /// Get the Unicode decoder for the given charset.
        /// The "Raw" version skips charset alias resolution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoder([MarshalAs(UnmanagedType.LPStr)] string charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoderRaw([MarshalAs(UnmanagedType.LPStr)] string charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeDecoderInternal([MarshalAs(UnmanagedType.LPStr)] string charset);
		
		/// <summary>
        /// Get the Unicode encoder for the given charset.
        /// The "Raw" version skips charset alias resolution
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeEncoder([MarshalAs(UnmanagedType.LPStr)] string charset);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr GetUnicodeEncoderRaw([MarshalAs(UnmanagedType.LPStr)] string charset);
		
		/// <summary>
        /// A shortcut to calling nsICharsetAlias to do alias resolution
        /// @throws if aCharset is an unknown charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharsetAlias([MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// Get the complete list of available decoders.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetDecoderList();
		
		/// <summary>
        /// Get the complete list of available encoders.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetEncoderList();
		
		/// <summary>
        /// Get the complete list of available charset detectors.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIUTF8StringEnumerator GetCharsetDetectorList();
		
		/// <summary>
        /// Get the human-readable name for the given charset.
        /// @throws if aCharset is an unknown charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharsetTitle([MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Get some data about the given charset. This includes whether the
        /// character encoding may be used for certain purposes, if it is
        /// multi-byte, and the language code for it. See charsetData.properties
        /// for the source of this data. Some known property names:
        /// notForBrowser  - not to be used in the browser.
        /// notForOutgoing - not to be used for exporting files.
        /// LangGroup      - language code for charset, e.g. 'he' and 'zh-CN'.
        /// isMultibyte    - is this a multi-byte charset?
        /// isXSSVulnerable - not to be used in untrusted web content
        ///
        /// @param aCharset name of the character encoding, e.g. 'iso-8859-15'.
        /// @param aProp property desired for the character encoding.
        /// @throws if aCharset is an unknown charset.
        /// @return the value of the property, for the character encoding.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetCharsetData([MarshalAs(UnmanagedType.LPStr)] string aCharset, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aProp, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase retval);
		
		/// <summary>
        /// Get the language group for the given charset. This is similar to
        /// calling <tt>getCharsetData</tt> with the <tt>prop</tt> "LangGroup".
        ///
        /// @param aCharset name of the character encoding, e.g. 'iso-8859-15'.
        /// @throws if aCharset is an unknown charset.
        /// @return the language code for the character encoding.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAtom GetCharsetLangGroup([MarshalAs(UnmanagedType.LPStr)] string aCharset);
		
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIAtom GetCharsetLangGroupRaw([MarshalAs(UnmanagedType.LPStr)] string aCharset);
	}
}
