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
// Generated by IDLImporter from file mozIStorageAggregateFunction.idl
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
    /// mozIStorageAggregateFunction represents aggregate SQL function.
    /// Common examples of aggregate functions are SUM() and COUNT().
    ///
    /// An aggregate function calculates one result for a given set of data, where
    /// a set of data is a group of tuples. There can be one group
    /// per request or many of them, if GROUP BY clause is used or not.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("763217b7-3123-11da-918d-000347412e16")]
	public interface mozIStorageAggregateFunction
	{
		
		/// <summary>
        /// onStep is called when next value should be passed to
        /// a custom function.
        ///
        /// @param aFunctionArguments    The arguments passed in to the function
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void OnStep(mozIStorageValueArray aFunctionArguments);
		
		/// <summary>
        /// Called when all tuples in a group have been processed and the engine
        /// needs the aggregate function's value.
        ///
        /// @returns aggregate result as Variant.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIVariant OnFinal();
	}
}
