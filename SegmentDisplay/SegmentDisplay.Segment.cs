// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	public abstract partial class SegmentDisplay : UserControl
	{
		#region Region - Calculate Tools for Segment Display
		private protected Single Scope => Height / 200F;
		private protected SizeF S (Single W, Single H) => new SizeF(W * Scope, H * Scope);
		private protected PointF P (Single X, Single Y) => new PointF(X * Scope, Y * Scope);
		private protected RectangleF R (Single X, Single Y, Single W, Single H) => new RectangleF(P(X, Y), S(W, H));
		private protected PointF[] PS (Single[] Ss)
		{ List<PointF> Pl = new List<PointF>(); for (Int32 I = 0; I < Ss.Length;) Pl.Add(P(Ss[I++], Ss[I++])); return Pl.ToArray(); }
		private protected Region RP (Single[] Ss) { GraphicsPath GP = new GraphicsPath(); GP.AddPolygon(PS(Ss)); return new Region(GP); }
		private protected static readonly Region REmpty = new Region(new Rectangle(0, 0, 0, 0));
		#endregion
		#region Region - Segment Drawing Function
		private protected abstract Dictionary<UInt16, Region> SegmentRegion { get; }
		private UInt16 Pow2 (UInt16 Number) => Convert.ToUInt16(Pow(2, Number));
		private void DrawSegmentON (UInt16 Segment) => G.FillRegion(new SolidBrush(OnColor), SegmentRegion[Segment]);
		private void DrawSegmentOFF (UInt16 Segment) => G.FillRegion(new SolidBrush(OffColor), SegmentRegion[Segment]);
		private void DrawSegmentRegion (UInt16 Segments)
		{ for (UInt16 I = 0; I < 16; I++) if ((Pow2(I) & Segments) > 0) DrawSegmentON(I); else DrawSegmentOFF(I); }
		/// <summary>Draw Segment</summary><param name="Segments"></param>
		public void DrawSegment (UInt16 Segments) { ShownSegment = Segments; DrawAll(); }
		private protected abstract Dictionary<WordStyle, UInt16> WordMapping { get; }
		/// <summary>Draw Word As Enumerable</summary><param name="Style">Word Style</param>
		public void DrawWord (WordStyle Style) { ShownSegment = WordMapping[Style]; DrawAll(); }
		private WordStyle SearchWord (UInt16 I) { foreach (WordStyle S in WordMapping.Keys) if (WordMapping[S] == I) return S; return WordStyle.None; }
		#endregion
		#region Region - Symbol Drawing Function
		private protected abstract Dictionary<Byte, Region> SymbolRegion { get; }
		private protected readonly Dictionary<Byte, Region> SREmpty = new Dictionary<byte, Region>
		{ { 0, REmpty }, { 1, REmpty }, { 2, REmpty }, { 3, REmpty }, { 4, REmpty }, { 5, REmpty }, { 6, REmpty }, { 7, REmpty } };
		private Byte Pow2 (Byte Number) => Convert.ToByte(Pow(2, Number));
		private void DrawSymbolON (Byte Symbol) => G.FillRegion(new SolidBrush(OnColor), SymbolRegion[Symbol]);
		private void DrawSymbolOFF (Byte Symbol) => G.FillRegion(new SolidBrush(OffColor), SymbolRegion[Symbol]);
		private void DrawSymbolRegion (Byte Symbols) { for (Byte I = 0; I < 8; I++) if ((Pow2(I) & Symbols) > 0) DrawSymbolON(I); else DrawSymbolOFF(I); }
		/// <summary>Draw Symbol</summary><param name="Symbols"></param>
		public void DrawSymbol (Byte Symbols) { ShownSymbol = Symbols; DrawAll(); }
		private protected abstract Dictionary<DotStyle, Byte> DotMapping { get; }
		/// <summary>Draw Dot</summary><param name="Style">DotStyle</param>
		public void DrawDot (DotStyle Style) { ShownSymbol = DotMapping[Style]; DrawAll(); }
		private protected readonly Dictionary<DotStyle, Byte> DMEmpty = new Dictionary<DotStyle, Byte>
		{ { DotStyle.None, 0 }, { DotStyle.Dot, 0 }, { DotStyle.Comma, 0 } };
		private DotStyle SearchDot (Byte B) { foreach (DotStyle S in DotMapping.Keys) if (DotMapping[S] == B) return S; return DotStyle.None; }
		#endregion
		#region Region Event Drawing Function
		private RectangleF GroundRectangle => new RectangleF(0, 0, Width, Height);
		private void DrawGround () => G.FillRectangle(new SolidBrush(GroundColor), GroundRectangle);
		private void DrawAll () { DrawGround(); DrawSegmentRegion(ShownSegment); DrawSymbolRegion(ShownSymbol); }
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();
		#endregion
	}
}
