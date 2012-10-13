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
// Generated by IDLImporter from file nsIWapPushApplication.idl
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
    /// Handle WAP Push notifications.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fd6f7f6b-a67e-4892-930d-fca864df8fe7")]
	public interface nsIWapPushApplication
	{
		
		/// <summary>
        /// Receive WAP Push message.
        ///
        /// @param aData
        /// An array containing raw PDU data.
        /// @param aLength
        /// Length of aData.
        /// @param aOffset
        /// Start offset of aData containing message body of the Push PDU.
        /// @param options
        /// An object containing various attributes from lower transport layer.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ReceiveWapPush([MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] byte[] aData, uint aLength, uint aOffset, Gecko.JsVal aOptions, System.IntPtr jsContext);
	}
}
