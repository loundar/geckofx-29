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
// Generated by IDLImporter from file nsICommandLineValidator.idl
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
    /// Validates arguments on the command line of an XUL application.
    ///
    /// Each validator is registered in the category "command-line-validator".
    /// The entries in this category are read in alphabetical order, and each
    /// category value is treated as a service contractid implementing this
    /// interface.
    ///
    /// By convention, validator with ordinary priority should begin with "m".
    ///
    /// Example:
    /// Category               Entry          Value
    /// command-line-validator b-browser      @mozilla.org/browser/clh;1
    /// command-line-validator m-edit         @mozilla.org/composer/clh;1
    /// command-line-validator m-irc          @mozilla.org/chatzilla/clh;1
    ///
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5ecaa593-7660-4a3a-957a-92d5770671c7")]
	public interface nsICommandLineValidator
	{
		
		/// <summary>
        /// Process the command-line validators in the proper order, calling
        /// "validate()" on each.
        ///
        /// @throws NS_ERROR_ABORT if any validator throws NS_ERROR_ABORT. All other
        /// errors thrown by validators will be silently ignored.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Validate([MarshalAs(UnmanagedType.Interface)] nsICommandLine aCommandLine);
	}
}
