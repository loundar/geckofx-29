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
// Generated by IDLImporter from file nsIMacShellService.idl
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
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7f8ca08e-1df4-4735-86e9-50dedb48e5e8")]
	public interface nsIMacShellService : nsIShellService
	{
		
		/// <summary>
        /// Determines whether or not Firefox is the "Default Browser."
        /// This is simply whether or not Firefox is registered to handle
        /// http links.
        ///
        /// @param aStartupCheck true if this is the check being performed
        /// by the first browser window at startup,
        /// false otherwise.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool IsDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aStartupCheck);
		
		/// <summary>
        /// Registers Firefox as the "Default Browser."
        ///
        /// @param aClaimAllTypes Register Firefox as the handler for
        /// additional protocols (ftp, chrome etc)
        /// and web documents (.html, .xhtml etc).
        /// @param aForAllUsers   Whether or not Firefox should attempt
        /// to become the default browser for all
        /// users on a multi-user system.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDefaultBrowser([MarshalAs(UnmanagedType.U1)] bool aClaimAllTypes, [MarshalAs(UnmanagedType.U1)] bool aForAllUsers);
		
		/// <summary>
        /// Used to determine whether or not to show a "Set Default Browser"
        /// query dialog. This attribute is true if the application is starting
        /// up and "browser.shell.checkDefaultBrowser" is true, otherwise it
        /// is false.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetShouldCheckDefaultBrowserAttribute();
		
		/// <summary>
        /// Used to determine whether or not to show a "Set Default Browser"
        /// query dialog. This attribute is true if the application is starting
        /// up and "browser.shell.checkDefaultBrowser" is true, otherwise it
        /// is false.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetShouldCheckDefaultBrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aShouldCheckDefaultBrowser);
		
		/// <summary>
        /// Used to determine whether or not to offer "Set as desktop background"
        /// functionality. Even if shell service is available it is not
        /// guaranteed that it is able to set the background for every desktop
        /// which is especially true for Linux with its many different desktop
        /// environments.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new bool GetCanSetDesktopBackgroundAttribute();
		
		/// <summary>
        /// Sets the desktop background image using either the HTML <IMG>
        /// element supplied or the background image of the element supplied.
        ///
        /// @param aImageElement Either a HTML <IMG> element or an element with
        /// a background image from which to source the
        /// background image.
        /// @param aPosition     How to place the image on the desktop
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDesktopBackground([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aElement, int aPosition);
		
		/// <summary>
        /// Opens the application specified. If more than one application of the
        /// given type is available on the system, the default or "preferred"
        /// application is used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OpenApplication(int aApplication);
		
		/// <summary>
        /// The desktop background color, visible when no background image is
        /// used, or if the background image is centered and does not fill the
        /// entire screen. A rgb value, where (r << 16 | g << 8 | b)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new uint GetDesktopBackgroundColorAttribute();
		
		/// <summary>
        /// The desktop background color, visible when no background image is
        /// used, or if the background image is centered and does not fill the
        /// entire screen. A rgb value, where (r << 16 | g << 8 | b)
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetDesktopBackgroundColorAttribute(uint aDesktopBackgroundColor);
		
		/// <summary>
        /// Opens an application with a specific URI to load.
        /// @param   application
        /// The application file (or bundle directory, on OS X)
        /// @param   uri
        /// The uri to be loaded by the application
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void OpenApplicationWithURI([MarshalAs(UnmanagedType.Interface)] nsILocalFile aApplication, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aURI);
		
		/// <summary>
        /// The default system handler for web feeds
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new nsILocalFile GetDefaultFeedReaderAttribute();
	}
	
	/// <summary>nsIMacShellServiceConsts </summary>
	public class nsIMacShellServiceConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const long APPLICATION_KEYCHAIN_ACCESS = 2;
		
		// 
		public const long APPLICATION_NETWORK = 3;
		
		// 
		public const long APPLICATION_DESKTOP = 4;
	}
}
