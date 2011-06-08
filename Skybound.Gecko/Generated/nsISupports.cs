// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsISupports.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsISupports.idl
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
	
	
	/// <summary>nsISupports </summary>
	[ComImport()]
	[Guid("00000000-0000-0000-c000-000000000046")]
	public interface nsISupports
	{
		
		/// <summary>Member QueryInterface </summary>
		/// <param name='uuid'> </param>
		/// <returns>A System.IntPtr </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr  QueryInterface(ref System.Guid uuid);
		
		/// <summary>Member AddRef </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int AddRef();
		
		/// <summary>Member Release </summary>
		/// <returns>A System.Int32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int Release();
	}
}