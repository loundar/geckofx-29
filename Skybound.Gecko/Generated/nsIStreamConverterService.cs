// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIStreamConverterService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIStreamConverterService.idl
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
	
	
	/// <summary>nsIStreamConverterService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f2b1ab53-f0bd-4adb-9365-e59b1701a258")]
	public interface nsIStreamConverterService
	{
		
		/// <summary>Member CanConvert </summary>
		/// <param name='aFromType'> </param>
		/// <param name='aToType'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CanConvert([MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType);
		
		/// <summary>Member Convert </summary>
		/// <param name='aFromStream'> </param>
		/// <param name='aFromType'> </param>
		/// <param name='aToType'> </param>
		/// <param name='aContext'> </param>
		/// <returns>A nsIInputStream</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIInputStream Convert([MarshalAs(UnmanagedType.Interface)] nsIInputStream  aFromStream, [MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
		
		/// <summary>Member AsyncConvertData </summary>
		/// <param name='aFromType'> </param>
		/// <param name='aToType'> </param>
		/// <param name='aListener'> </param>
		/// <param name='aContext'> </param>
		/// <returns>A nsIStreamListener</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIStreamListener AsyncConvertData([MarshalAs(UnmanagedType.LPStr)] System.String  aFromType, [MarshalAs(UnmanagedType.LPStr)] System.String  aToType, [MarshalAs(UnmanagedType.Interface)] nsIStreamListener  aListener, [MarshalAs(UnmanagedType.Interface)] nsISupports  aContext);
	}
}