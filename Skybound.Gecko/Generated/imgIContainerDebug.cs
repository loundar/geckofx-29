// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: imgIContainerDebug.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file imgIContainerDebug.idl
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
	
	
	/// <summary>imgIContainerDebug </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("52cbb839-6e63-4a70-b21a-1db4ca706c49")]
	public interface imgIContainerDebug
	{
		
		/// <summary>Member GetFramesNotifiedAttribute </summary>
		/// <returns>A System.UInt32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.UInt32  GetFramesNotifiedAttribute();
	}
}