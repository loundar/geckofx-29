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
// Generated by IDLImporter from file nsIFeedResult.idl
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
    /// The nsIFeedResult interface provides access to HTTP and parsing
    /// metadata for a feed or entry.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7a180b78-0f46-4569-8c22-f3d720ea1c57")]
	public interface nsIFeedResult
	{
		
		/// <summary>
        /// The Feed parser will set the bozo bit when a feed triggers a fatal
        /// error during XML parsing. There may be entries and feed metadata
        /// that were parsed before the error.  Thanks to Tim Bray for
        /// suggesting this terminology.
        /// <http://www.tbray.org/ongoing/When/200x/2004/01/11/PostelPilgrim>
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBozoAttribute();
		
		/// <summary>
        /// The Feed parser will set the bozo bit when a feed triggers a fatal
        /// error during XML parsing. There may be entries and feed metadata
        /// that were parsed before the error.  Thanks to Tim Bray for
        /// suggesting this terminology.
        /// <http://www.tbray.org/ongoing/When/200x/2004/01/11/PostelPilgrim>
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBozoAttribute([MarshalAs(UnmanagedType.U1)] bool aBozo);
		
		/// <summary>
        /// The parsed feed or entry.
        ///
        /// Will be null if a non-feed is processed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFeedContainer GetDocAttribute();
		
		/// <summary>
        /// The parsed feed or entry.
        ///
        /// Will be null if a non-feed is processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDocAttribute([MarshalAs(UnmanagedType.Interface)] nsIFeedContainer aDoc);
		
		/// <summary>
        /// The address from which the feed was fetched.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetUriAttribute();
		
		/// <summary>
        /// The address from which the feed was fetched.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetUriAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aUri);
		
		/// <summary>
        /// Feed Version:
        /// atom, rss2, rss09, rss091, rss091userland, rss092, rss1, atom03,
        /// atomEntry, rssItem
        ///
        /// Will be null if a non-feed is processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVersion);
		
		/// <summary>
        /// Feed Version:
        /// atom, rss2, rss09, rss091, rss091userland, rss092, rss1, atom03,
        /// atomEntry, rssItem
        ///
        /// Will be null if a non-feed is processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetVersionAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aVersion);
		
		/// <summary>
        /// An XSLT stylesheet available to transform the source of the
        /// feed. Some feeds include this information in a processing
        /// instruction. It's generally intended for clients with specific
        /// feed capabilities.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI GetStylesheetAttribute();
		
		/// <summary>
        /// An XSLT stylesheet available to transform the source of the
        /// feed. Some feeds include this information in a processing
        /// instruction. It's generally intended for clients with specific
        /// feed capabilities.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetStylesheetAttribute([MarshalAs(UnmanagedType.Interface)] nsIURI aStylesheet);
		
		/// <summary>
        /// HTTP response headers that accompanied the feed.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProperties GetHeadersAttribute();
		
		/// <summary>
        /// HTTP response headers that accompanied the feed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHeadersAttribute([MarshalAs(UnmanagedType.Interface)] nsIProperties aHeaders);
		
		/// <summary>
        /// Registers a prefix used to access an extension in the feed/entry
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RegisterExtensionPrefix([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aNamespace, [MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPrefix);
	}
}
