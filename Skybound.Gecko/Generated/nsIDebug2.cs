// --------------------------------------------------------------------------------------------
// Copyright (c) 2011, SIL International. All rights reserved.
// 
// File: nsIDebug2.cs
// Responsibility: Generated by IDLImporter
// Last reviewed: 
// 
// <remarks>
// Generated by IDLImporter from file nsIDebug2.idl
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
	
	
	/// <summary>nsIDebug2 </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9c9307ed-480a-4f2a-8f29-21378c03bcbc")]
	public interface nsIDebug2 : nsIDebug
	{
		
		/// <summary>Member Assertion </summary>
		/// <param name='aStr'> </param>
		/// <param name='aExpr'> </param>
		/// <param name='aFile'> </param>
		/// <param name='aLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Assertion([MarshalAs(UnmanagedType.LPStr)] System.String  aStr, [MarshalAs(UnmanagedType.LPStr)] System.String  aExpr, [MarshalAs(UnmanagedType.LPStr)] System.String  aFile, System.Int32  aLine);
		
		/// <summary>Member Warning </summary>
		/// <param name='aStr'> </param>
		/// <param name='aFile'> </param>
		/// <param name='aLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Warning([MarshalAs(UnmanagedType.LPStr)] System.String  aStr, [MarshalAs(UnmanagedType.LPStr)] System.String  aFile, System.Int32  aLine);
		
		/// <summary>Member Break </summary>
		/// <param name='aFile'> </param>
		/// <param name='aLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Break([MarshalAs(UnmanagedType.LPStr)] System.String  aFile, System.Int32  aLine);
		
		/// <summary>Member Abort </summary>
		/// <param name='aFile'> </param>
		/// <param name='aLine'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Abort([MarshalAs(UnmanagedType.LPStr)] System.String  aFile, System.Int32  aLine);
		
		/// <summary>Member GetIsDebugBuildAttribute </summary>
		/// <returns>A System.Boolean </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Boolean  GetIsDebugBuildAttribute();
		
		/// <summary>Member GetAssertionCountAttribute </summary>
		/// <returns>A System.Int32 </returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.Int32  GetAssertionCountAttribute();
	}
}