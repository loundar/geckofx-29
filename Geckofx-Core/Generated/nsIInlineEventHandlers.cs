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
// Generated by IDLImporter from file nsIInlineEventHandlers.idl
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
	[Guid("5b3f9656-9d81-40e4-85ba-01f302177815")]
	public interface nsIInlineEventHandlers
	{
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnabortAttribute(System.IntPtr jsContext);
		
		/// <summary>
        ///This Source Code Form is subject to the terms of the Mozilla Public
        /// License, v. 2.0. If a copy of the MPL was not distributed with this
        /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnabortAttribute(Gecko.JsVal aOnabort, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnblurAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnblurAttribute(Gecko.JsVal aOnblur, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncanplayAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncanplayAttribute(Gecko.JsVal aOncanplay, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncanplaythroughAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncanplaythroughAttribute(Gecko.JsVal aOncanplaythrough, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnchangeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnchangeAttribute(Gecko.JsVal aOnchange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnclickAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnclickAttribute(Gecko.JsVal aOnclick, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncontextmenuAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncontextmenuAttribute(Gecko.JsVal aOncontextmenu, System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval oncuechange;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndblclickAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval oncuechange;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndblclickAttribute(Gecko.JsVal aOndblclick, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragAttribute(Gecko.JsVal aOndrag, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragendAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragendAttribute(Gecko.JsVal aOndragend, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragenterAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragenterAttribute(Gecko.JsVal aOndragenter, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragleaveAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragleaveAttribute(Gecko.JsVal aOndragleave, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragoverAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragoverAttribute(Gecko.JsVal aOndragover, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndragstartAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndragstartAttribute(Gecko.JsVal aOndragstart, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndropAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndropAttribute(Gecko.JsVal aOndrop, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOndurationchangeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOndurationchangeAttribute(Gecko.JsVal aOndurationchange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnemptiedAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnemptiedAttribute(Gecko.JsVal aOnemptied, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnendedAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnendedAttribute(Gecko.JsVal aOnended, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnerrorAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnerrorAttribute(Gecko.JsVal aOnerror, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnfocusAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnfocusAttribute(Gecko.JsVal aOnfocus, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOninputAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninputAttribute(Gecko.JsVal aOninput, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOninvalidAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOninvalidAttribute(Gecko.JsVal aOninvalid, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeydownAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeydownAttribute(Gecko.JsVal aOnkeydown, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeypressAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeypressAttribute(Gecko.JsVal aOnkeypress, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnkeyupAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnkeyupAttribute(Gecko.JsVal aOnkeyup, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadAttribute(Gecko.JsVal aOnload, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadeddataAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadeddataAttribute(Gecko.JsVal aOnloadeddata, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadedmetadataAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadedmetadataAttribute(Gecko.JsVal aOnloadedmetadata, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnloadstartAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnloadstartAttribute(Gecko.JsVal aOnloadstart, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmousedownAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmousedownAttribute(Gecko.JsVal aOnmousedown, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmousemoveAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmousemoveAttribute(Gecko.JsVal aOnmousemove, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseoutAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseoutAttribute(Gecko.JsVal aOnmouseout, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseoverAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseoverAttribute(Gecko.JsVal aOnmouseover, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmouseupAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmouseupAttribute(Gecko.JsVal aOnmouseup, System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval onmousewheel;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozfullscreenchangeAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// [implicit_jscontext] attribute jsval onmousewheel;
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozfullscreenchangeAttribute(Gecko.JsVal aOnmozfullscreenchange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozfullscreenerrorAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozfullscreenerrorAttribute(Gecko.JsVal aOnmozfullscreenerror, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozpointerlockchangeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozpointerlockchangeAttribute(Gecko.JsVal aOnmozpointerlockchange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnmozpointerlockerrorAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnmozpointerlockerrorAttribute(Gecko.JsVal aOnmozpointerlockerror, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnpauseAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnpauseAttribute(Gecko.JsVal aOnpause, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnplayAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnplayAttribute(Gecko.JsVal aOnplay, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnplayingAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnplayingAttribute(Gecko.JsVal aOnplaying, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnprogressAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnprogressAttribute(Gecko.JsVal aOnprogress, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnratechangeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnratechangeAttribute(Gecko.JsVal aOnratechange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnresetAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnresetAttribute(Gecko.JsVal aOnreset, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnscrollAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnscrollAttribute(Gecko.JsVal aOnscroll, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnseekedAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnseekedAttribute(Gecko.JsVal aOnseeked, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnseekingAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnseekingAttribute(Gecko.JsVal aOnseeking, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnselectAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnselectAttribute(Gecko.JsVal aOnselect, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnshowAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnshowAttribute(Gecko.JsVal aOnshow, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnstalledAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnstalledAttribute(Gecko.JsVal aOnstalled, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnsubmitAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnsubmitAttribute(Gecko.JsVal aOnsubmit, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnsuspendAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnsuspendAttribute(Gecko.JsVal aOnsuspend, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOntimeupdateAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOntimeupdateAttribute(Gecko.JsVal aOntimeupdate, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnvolumechangeAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnvolumechangeAttribute(Gecko.JsVal aOnvolumechange, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnwaitingAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnwaitingAttribute(Gecko.JsVal aOnwaiting, System.IntPtr jsContext);
		
		/// <summary>
        /// Non-HTML5 event attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncopyAttribute(System.IntPtr jsContext);
		
		/// <summary>
        /// Non-HTML5 event attributes
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncopyAttribute(Gecko.JsVal aOncopy, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOncutAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOncutAttribute(Gecko.JsVal aOncut, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnpasteAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnpasteAttribute(Gecko.JsVal aOnpaste, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnbeforescriptexecuteAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnbeforescriptexecuteAttribute(Gecko.JsVal aOnbeforescriptexecute, System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		Gecko.JsVal GetOnafterscriptexecuteAttribute(System.IntPtr jsContext);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetOnafterscriptexecuteAttribute(Gecko.JsVal aOnafterscriptexecute, System.IntPtr jsContext);
	}
}
