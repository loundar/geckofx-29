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
// Generated by IDLImporter from file nsIUrlClassifierPrefixSet.idl
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
	
	
	/// <summary>nsIUrlClassifierPrefixSet </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("42ef1d52-3351-4973-98f8-d18f089bccfa")]
	public interface nsIUrlClassifierPrefixSet
	{
		
		/// <summary>Member SetPrefixes </summary>
		/// <param name='aPrefixes'> </param>
		/// <param name='aLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPrefixes([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint[] aPrefixes, uint aLength);
		
		/// <summary>Member AddPrefixes </summary>
		/// <param name='aPrefixes'> </param>
		/// <param name='aLength'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AddPrefixes([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] uint[] aPrefixes, uint aLength);
		
		/// <summary>Member Contains </summary>
		/// <param name='aPrefix'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Contains(uint aPrefix);
		
		/// <summary>Member Probe </summary>
		/// <param name='aPrefix'> </param>
		/// <param name='aKey'> </param>
		/// <param name='aReady'> </param>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Probe(uint aPrefix, uint aKey, [MarshalAs(UnmanagedType.Bool)] ref bool aReady);
		
		/// <summary>Member EstimateSize </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint EstimateSize();
		
		/// <summary>Member GetKey </summary>
		/// <returns>A System.UInt32</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetKey();
		
		/// <summary>Member IsEmpty </summary>
		/// <returns>A System.Boolean</returns>
		[return: MarshalAs(UnmanagedType.Bool)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsEmpty();
		
		/// <summary>Member LoadFromFile </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LoadFromFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>Member StoreToFile </summary>
		/// <param name='aFile'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StoreToFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
	}
}
