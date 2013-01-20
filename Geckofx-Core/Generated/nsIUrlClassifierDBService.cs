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
// Generated by IDLImporter from file nsIUrlClassifierDBService.idl
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
    /// Interface for JS function callbacks
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4ca27b6b-a674-4b3d-ab30-d21e2da2dffb")]
	public interface nsIUrlClassifierCallback
	{
		
		/// <summary>
        /// Interface for JS function callbacks
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void HandleEvent([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase value);
	}
	
	/// <summary>
    /// The nsIUrlClassifierUpdateObserver interface is implemented by
    /// clients streaming updates to the url-classifier (usually
    /// nsUrlClassifierStreamUpdater.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("bbb33c65-e783-476c-8db0-6ddb91826c07")]
	public interface nsIUrlClassifierUpdateObserver
	{
		
		/// <summary>
        /// The update requested a new URL whose contents should be downloaded
        /// and sent to the classifier as a new stream.
        ///
        /// @param url The url that was requested.
        /// @param table The table name that this URL's contents will be associated
        /// with.  This should be passed back to beginStream().
        /// @param serverMAC The server-supplied MAC of the data at this URL.  This
        /// should be passed back to beginStream().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateUrlRequested([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase url, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase serverMAC);
		
		/// <summary>
        /// The server has requested that the client get a new client key for
        /// MAC requests.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RekeyRequested();
		
		/// <summary>
        /// A stream update has completed.
        ///
        /// @param status The state of the update process.
        /// @param delay The amount of time the updater should wait to fetch the
        /// next URL in ms.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void StreamFinished(int status, uint delay);
		
		/// <summary>
        ///The update has encountered an error and should be cancelled </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateError(int error);
		
		/// <summary>
        /// The update has completed successfully.
        ///
        /// @param requestedTimeout The number of seconds that the caller should
        /// wait before trying to update again.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateSuccess(uint requestedTimeout);
	}
	
	/// <summary>
    /// This is a proxy class that is instantiated and called from the JS thread.
    /// It provides async methods for querying and updating the database.  As the
    /// methods complete, they call the callback function.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7aae3f3a-527d-488b-a448-45dca6db0e80")]
	public interface nsIUrlClassifierDBService
	{
		
		/// <summary>
        /// Looks up a key in the database.
        ///
        /// @param key: The URL to search for.  This URL will be canonicalized
        /// by the service.
        /// @param c: The callback will be called with a comma-separated list
        /// of tables to which the key belongs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Lookup([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase spec, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);
		
		/// <summary>
        /// Lists the tables along with which chunks are available in each table.
        /// This list is in the format of the request body:
        /// tablename;chunkdata\n
        /// tablename2;chunkdata2\n
        ///
        /// For example:
        /// goog-phish-regexp;a:10,14,30-40s:56,67
        /// goog-white-regexp;a:1-3,5
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTables([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);
		
		/// <summary>
        /// Set the nsIUrlClassifierCompleter object for a given table.  This
        /// object will be used to request complete versions of partial
        /// hashes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetHashCompleter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleter completer);
		
		/// <summary>
        /// Begin an update process.  Will throw NS_ERROR_NOT_AVAILABLE if there
        /// is already an update in progress.
        ///
        /// @param updater The update observer tied to this update.
        /// @param tables A comma-separated list of tables included in this update.
        /// @param clientKey The client key for calculating an update's MAC,
        /// or empty to ignore MAC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginUpdate([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierUpdateObserver updater, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase clientKey);
		
		/// <summary>
        /// Begin a stream update.  This should be called once per url being
        /// fetched.
        ///
        /// @param table The table the contents of this stream will be associated
        /// with, or empty for the initial stream.
        /// @param serverMAC The MAC specified by the update server for this stream.
        /// If the server has not specified a MAC (which is the case
        /// for the initial stream), this will be empty.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void BeginStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase serverMAC);
		
		/// <summary>
        /// Update the table incrementally.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void UpdateStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateChunk);
		
		/// <summary>
        /// Finish an individual stream update.  Must be called for every
        /// beginStream() call, before the next beginStream() or finishUpdate().
        ///
        /// The update observer's streamFinished will be called once the
        /// stream has been processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinishStream();
		
		/// <summary>
        /// Finish an incremental update.  This will attempt to commit any
        /// pending changes and resets the update interface.
        ///
        /// The update observer's updateSucceeded or updateError methods
        /// will be called when the update has been processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void FinishUpdate();
		
		/// <summary>
        /// Cancel an incremental update.  This rolls back any pending changes.
        /// and resets the update interface.
        ///
        /// The update observer's updateError method will be called when the
        /// update has been rolled back.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CancelUpdate();
		
		/// <summary>
        /// Reset the url-classifier database.  This call will delete the existing
        /// database, emptying all tables.  Mostly intended for use in unit tests.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ResetDatabase();
	}
	
	/// <summary>
    /// Interface for the actual worker thread.  Implementations of this need not
    /// be thread aware and just work on the database.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("2af84c09-269e-4fc2-b28f-af56717db118")]
	public interface nsIUrlClassifierDBServiceWorker : nsIUrlClassifierDBService
	{
		
		/// <summary>
        /// Looks up a key in the database.
        ///
        /// @param key: The URL to search for.  This URL will be canonicalized
        /// by the service.
        /// @param c: The callback will be called with a comma-separated list
        /// of tables to which the key belongs.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void Lookup([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase spec, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);
		
		/// <summary>
        /// Lists the tables along with which chunks are available in each table.
        /// This list is in the format of the request body:
        /// tablename;chunkdata\n
        /// tablename2;chunkdata2\n
        ///
        /// For example:
        /// goog-phish-regexp;a:10,14,30-40s:56,67
        /// goog-white-regexp;a:1-3,5
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void GetTables([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierCallback c);
		
		/// <summary>
        /// Set the nsIUrlClassifierCompleter object for a given table.  This
        /// object will be used to request complete versions of partial
        /// hashes.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void SetHashCompleter([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tableName, [MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierHashCompleter completer);
		
		/// <summary>
        /// Begin an update process.  Will throw NS_ERROR_NOT_AVAILABLE if there
        /// is already an update in progress.
        ///
        /// @param updater The update observer tied to this update.
        /// @param tables A comma-separated list of tables included in this update.
        /// @param clientKey The client key for calculating an update's MAC,
        /// or empty to ignore MAC.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BeginUpdate([MarshalAs(UnmanagedType.Interface)] nsIUrlClassifierUpdateObserver updater, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase tables, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase clientKey);
		
		/// <summary>
        /// Begin a stream update.  This should be called once per url being
        /// fetched.
        ///
        /// @param table The table the contents of this stream will be associated
        /// with, or empty for the initial stream.
        /// @param serverMAC The MAC specified by the update server for this stream.
        /// If the server has not specified a MAC (which is the case
        /// for the initial stream), this will be empty.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void BeginStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase table, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase serverMAC);
		
		/// <summary>
        /// Update the table incrementally.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void UpdateStream([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase updateChunk);
		
		/// <summary>
        /// Finish an individual stream update.  Must be called for every
        /// beginStream() call, before the next beginStream() or finishUpdate().
        ///
        /// The update observer's streamFinished will be called once the
        /// stream has been processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void FinishStream();
		
		/// <summary>
        /// Finish an incremental update.  This will attempt to commit any
        /// pending changes and resets the update interface.
        ///
        /// The update observer's updateSucceeded or updateError methods
        /// will be called when the update has been processed.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void FinishUpdate();
		
		/// <summary>
        /// Cancel an incremental update.  This rolls back any pending changes.
        /// and resets the update interface.
        ///
        /// The update observer's updateError method will be called when the
        /// update has been rolled back.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void CancelUpdate();
		
		/// <summary>
        /// Reset the url-classifier database.  This call will delete the existing
        /// database, emptying all tables.  Mostly intended for use in unit tests.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		new void ResetDatabase();
		
		/// <summary>
        /// Provide a way to forcibly close the db connection.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CloseDb();
		
		/// <summary>
        /// Cache the results of a hash completion.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CacheCompletions(System.IntPtr entries);
	}
	
	/// <summary>
    /// This is an internal helper interface for communication between the
    /// main thread and the dbservice worker thread.  It is called for each
    /// lookup to provide a set of possible results, which the main thread
    /// may need to expand using an nsIUrlClassifierCompleter.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("f1dc83c6-ad43-4f0f-a809-fd43de7de8a4")]
	public interface nsIUrlClassifierLookupCallback
	{
		
		/// <summary>
        /// The lookup process is complete.
        ///
        /// @param results
        /// If this parameter is null, there were no results found.
        /// If not, it contains an array of nsUrlClassifierEntry objects
        /// with possible matches.  The callee is responsible for freeing
        /// this array.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LookupComplete(System.IntPtr results);
	}
}
