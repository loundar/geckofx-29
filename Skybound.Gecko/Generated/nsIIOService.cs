// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIIOService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIIOService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Skybound.Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	using System.Windows.Forms;
	
	
	/// <summary>nsIIOService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bddeda3f-9020-4d12-8c70-984ee9f7935e")]
	public interface nsIIOService
	{
		
		/// <summary>Member GetProtocolHandler </summary>
		/// <param name='aScheme'> </param>
		/// <returns>A nsIProtocolHandler</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProtocolHandler GetProtocolHandler([MarshalAs(UnmanagedType.LPStr)] System.String  aScheme);
		
		/// <summary>Member GetProtocolFlags </summary>
		/// <param name='aScheme'> </param>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetProtocolFlags([MarshalAs(UnmanagedType.LPStr)] System.String  aScheme);
		
		/// <summary>Member NewURI </summary>
		/// <param name='aSpec'> </param>
		/// <param name='aOriginCharset'> </param>
		/// <param name='aBaseURI'> </param>
		/// <returns>A nsIURI</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewURI([MarshalAs(UnmanagedType.LPStruct)] nsAString  aSpec, [MarshalAs(UnmanagedType.LPStr)] System.String  aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI);
		
		/// <summary>Member NewFileURI </summary>
		/// <param name='aFile'> </param>
		/// <returns>A nsIURI</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIURI NewFileURI([MarshalAs(UnmanagedType.Interface)] nsIFile  aFile);
		
		/// <summary>Member NewChannelFromURI </summary>
		/// <param name='aURI'> </param>
		/// <returns>A nsIChannel</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannelFromURI([MarshalAs(UnmanagedType.Interface)] nsIURI  aURI);
		
		/// <summary>Member NewChannel </summary>
		/// <param name='aSpec'> </param>
		/// <param name='aOriginCharset'> </param>
		/// <param name='aBaseURI'> </param>
		/// <returns>A nsIChannel</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIChannel NewChannel([MarshalAs(UnmanagedType.LPStruct)] nsAString  aSpec, [MarshalAs(UnmanagedType.LPStr)] System.String  aOriginCharset, [MarshalAs(UnmanagedType.Interface)] nsIURI  aBaseURI);
		
		/// <summary>Member GetOfflineAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetOfflineAttribute();
		
		/// <summary>Member SetOfflineAttribute </summary>
		/// <param name='aOffline'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOfflineAttribute(System.Boolean  aOffline);
		
		/// <summary>Member AllowPort </summary>
		/// <param name='aPort'> </param>
		/// <param name='aScheme'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool AllowPort(System.Int32  aPort, [MarshalAs(UnmanagedType.LPStr)] System.String  aScheme);
		
		/// <summary>Member ExtractScheme </summary>
		/// <param name='urlString'> </param>
		/// <returns>A nsAString</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsAString ExtractScheme([MarshalAs(UnmanagedType.LPStruct)] nsAString  urlString);
	}
}