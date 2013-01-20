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
// Generated by IDLImporter from file nsIDOMSVGPathSeg.idl
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
	[Guid("b9022da7-e26d-4df3-8c94-b45c4aedda7c")]
	public interface nsIDOMSVGPathSeg
	{
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		ushort GetPathSegTypeAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathSegTypeAsLetterAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAStringBase aPathSegTypeAsLetter);
	}
	
	/// <summary>nsIDOMSVGPathSegConsts </summary>
	public class nsIDOMSVGPathSegConsts
	{
		
		// <summary>
        // Path Segment Types
        // </summary>
		public const ulong PATHSEG_UNKNOWN = 0;
		
		// 
		public const ulong PATHSEG_CLOSEPATH = 1;
		
		// 
		public const ulong PATHSEG_MOVETO_ABS = 2;
		
		// 
		public const ulong PATHSEG_MOVETO_REL = 3;
		
		// 
		public const ulong PATHSEG_LINETO_ABS = 4;
		
		// 
		public const ulong PATHSEG_LINETO_REL = 5;
		
		// 
		public const ulong PATHSEG_CURVETO_CUBIC_ABS = 6;
		
		// 
		public const ulong PATHSEG_CURVETO_CUBIC_REL = 7;
		
		// 
		public const ulong PATHSEG_CURVETO_QUADRATIC_ABS = 8;
		
		// 
		public const ulong PATHSEG_CURVETO_QUADRATIC_REL = 9;
		
		// 
		public const ulong PATHSEG_ARC_ABS = 10;
		
		// 
		public const ulong PATHSEG_ARC_REL = 11;
		
		// 
		public const ulong PATHSEG_LINETO_HORIZONTAL_ABS = 12;
		
		// 
		public const ulong PATHSEG_LINETO_HORIZONTAL_REL = 13;
		
		// 
		public const ulong PATHSEG_LINETO_VERTICAL_ABS = 14;
		
		// 
		public const ulong PATHSEG_LINETO_VERTICAL_REL = 15;
		
		// 
		public const ulong PATHSEG_CURVETO_CUBIC_SMOOTH_ABS = 16;
		
		// 
		public const ulong PATHSEG_CURVETO_CUBIC_SMOOTH_REL = 17;
		
		// 
		public const ulong PATHSEG_CURVETO_QUADRATIC_SMOOTH_ABS = 18;
		
		// 
		public const ulong PATHSEG_CURVETO_QUADRATIC_SMOOTH_REL = 19;
	}
	
	/// <summary>nsIDOMSVGPathSegClosePath </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4970505f-2cc0-4afa-92e6-0cf4bdbf5a53")]
	public interface nsIDOMSVGPathSegClosePath
	{
	}
	
	/// <summary>nsIDOMSVGPathSegMovetoAbs </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("30cf7749-bf1f-4f9c-9558-8ee24da3a22c")]
	public interface nsIDOMSVGPathSegMovetoAbs
	{
		
		/// <summary>Member GetXAttribute </summary>
		/// <returns>A System.Single</returns>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>Member SetXAttribute </summary>
		/// <param name='aX'> </param>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("58ca7e86-661a-473a-96de-89682e7e24d6")]
	public interface nsIDOMSVGPathSegMovetoRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5c7ba7b0-c7c5-4a7b-bc1c-2d784153be77")]
	public interface nsIDOMSVGPathSegLinetoAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("7933a81a-72c5-4489-ba64-5635f4c23063")]
	public interface nsIDOMSVGPathSegLinetoRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("380afecd-f884-4da7-a0d7-5ffc4531b70b")]
	public interface nsIDOMSVGPathSegCurvetoCubicAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX1Attribute(float aX1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY1Attribute(float aY1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX2Attribute(float aX2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY2Attribute(float aY2);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0e661233-0c4f-4e0d-94d3-fbc460ad1f88")]
	public interface nsIDOMSVGPathSegCurvetoCubicRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX1Attribute(float aX1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY1Attribute(float aY1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX2Attribute(float aX2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY2Attribute(float aY2);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("b7aef0f0-2830-4145-b04f-fe05789ccf8a")]
	public interface nsIDOMSVGPathSegCurvetoQuadraticAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX1Attribute(float aX1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY1Attribute(float aY1);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c46eb661-9c05-4d46-9b2a-c2ae5b166060")]
	public interface nsIDOMSVGPathSegCurvetoQuadraticRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX1Attribute(float aX1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY1Attribute(float aY1);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("c9e222e5-31fd-4083-ae1f-fcf013681340")]
	public interface nsIDOMSVGPathSegArcAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetR1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetR1Attribute(float aR1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetR2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetR2Attribute(float aR2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetAngleAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAngleAttribute(float aAngle);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLargeArcFlagAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLargeArcFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aLargeArcFlag);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSweepFlagAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSweepFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aSweepFlag);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("49d0360d-bb66-4ab9-b9b0-f49b93398595")]
	public interface nsIDOMSVGPathSegArcRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetR1Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetR1Attribute(float aR1);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetR2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetR2Attribute(float aR2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetAngleAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAngleAttribute(float aAngle);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetLargeArcFlagAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLargeArcFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aLargeArcFlag);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetSweepFlagAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetSweepFlagAttribute([MarshalAs(UnmanagedType.U1)] bool aSweepFlag);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("4a54a4d2-edef-4e19-9600-2330311000f4")]
	public interface nsIDOMSVGPathSegLinetoHorizontalAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("8693268c-5180-43fd-acc3-5b9c09f43386")]
	public interface nsIDOMSVGPathSegLinetoHorizontalRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("fd5ffb7b-7279-4c09-abfd-b733dc872e80")]
	public interface nsIDOMSVGPathSegLinetoVerticalAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("d3ef2128-8de3-4aac-a6b4-13c7563119a6")]
	public interface nsIDOMSVGPathSegLinetoVerticalRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5fa8fea8-bdd1-4315-ac44-a39b3ff347b5")]
	public interface nsIDOMSVGPathSegCurvetoCubicSmoothAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX2Attribute(float aX2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY2Attribute(float aY2);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("dd5b4b00-edaa-493a-b477-bbc2576b4a98")]
	public interface nsIDOMSVGPathSegCurvetoCubicSmoothRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetX2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetX2Attribute(float aX2);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetY2Attribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetY2Attribute(float aY2);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ff5bbb58-b49a-450f-b91b-e50585c34b3d")]
	public interface nsIDOMSVGPathSegCurvetoQuadraticSmoothAbs
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
	
	/// <summary>
    /// raises nsIDOMDOMException on setting
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("ac0b2007-04e4-4e70-a0e0-294f374b29c4")]
	public interface nsIDOMSVGPathSegCurvetoQuadraticSmoothRel
	{
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetXAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetXAttribute(float aX);
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetYAttribute();
		
		/// <summary>
        /// raises nsIDOMDOMException on setting
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetYAttribute(float aY);
	}
}
