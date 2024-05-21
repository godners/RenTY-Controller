// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	public abstract partial class SegmentDisplay : UserControl
	{		
		private Single Scope => Height / 200F;
		private PointF P (Single X, Single Y) => new PointF(X * Scope, Y * Scope);



		//private protected Dictionary<UInt16, PointF[]> SegmentPoints;
		private protected abstract Dictionary<UInt16, Region> SegmentRegion { get; }
		private UInt16 Pow2 (UInt16 Number) => Convert.ToUInt16(Pow(2, Number));
		//private void DrawSegmentON (UInt16 Segment) => G.FillPolygon(new SolidBrush(OnColor), SegmentPoints[Segment]);
		private void DrawSegmentON (UInt16 Segment) => G.FillRegion(new SolidBrush(OnColor), SegmentRegion[Segment]);
		//private void DrawSegmentOFF (UInt16 Segment) => G.FillPolygon(new SolidBrush(OffColor), SegmentPoints[Segment]);
		private void DrawSegmentOFF (UInt16 Segment) => G.FillRegion(new SolidBrush(OffColor), SegmentRegion[Segment]);
		// // //private UInt16 Log2 (UInt16 Number) => Convert.ToByte(Log(Number) / Log(2));		
		private void DrawSegmentRegion (UInt16 Segments)
		{ for (UInt16 I = 0; I < 16; I++) if ((Pow2(I) & Segments) > 0) DrawSegmentON(I); else DrawSegmentOFF(I); }
		/// <summary>Draw Segment</summary><param name="Segments"></param>
		public void DrawSegment (UInt16 Segments) { ShownSegment = Segments; DrawAll(); }
		/// <summary>Draw Word</summary><param name="Style">Word Style</param>
		public void DrawWord (WordStyle Style) { }////////////////////////////////



		private protected abstract Dictionary<Byte, Region> SymbolRegions { get; }
		private Byte Pow2 (Byte Number) => Convert.ToByte(Pow(2, Number));
		private void DrawSymbolON (Byte Symbol) => G.FillRegion(new SolidBrush(OnColor), SymbolRegions[Symbol]);
		private void DrawSymbolOFF (Byte Symbol) => G.FillRegion(new SolidBrush(OffColor), SymbolRegions[Symbol]);
		private void DrawSymbolRegion (Byte Symbols) { for (Byte I = 0; I < 8; I++) if ((Pow2(I) & Symbols) > 0) DrawSymbolON(I); else DrawSymbolOFF(I); }
		/// <summary>Draw Symbol</summary><param name="Symbols"></param>
		public void DrawSymbol (Byte Symbols) { ShownSymbol = Symbols; DrawAll(); }
		/// <summary>Draw Dot</summary><param name="Style">DotStyle</param>
		public void DrawDot (DotStyle Style) { }////////////////////////////////



		private RectangleF GroundRectangle => new RectangleF(0, 0, Width, Height);
		private void DrawGround () => G.FillRectangle(new SolidBrush(GroundColor), GroundRectangle);
		private void DrawAll () { DrawGround(); DrawSegmentRegion(ShownSegment); DrawSymbolRegion(ShownSymbol); }
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();

	}
}
