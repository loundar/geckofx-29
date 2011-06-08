// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIXPIDialogService.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIXPIDialogService.idl
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
	
	
	/// <summary>nsIXPIDialogService </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8cdd8baa-1dd2-11b2-909a-f0178da5c5ff")]
	public interface nsIXPIDialogService
	{
		
		/// <summary>Member ConfirmInstall </summary>
		/// <param name='parent'> </param>
		/// <param name='packageList'> </param>
		/// <param name='count'> </param>
		/// <returns>A System.Boolean</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool ConfirmInstall([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow  parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=2)] string packageList, System.UInt32  count);
		
		/// <summary>Member OpenProgressDialog </summary>
		/// <param name='packageList'> </param>
		/// <param name='count'> </param>
		/// <param name='observer'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OpenProgressDialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Skybound.Gecko.XpCom.WStringMarshaler", SizeParamIndex=1)] string packageList, System.UInt32  count, [MarshalAs(UnmanagedType.Interface)] nsIObserver  observer);
	}
}