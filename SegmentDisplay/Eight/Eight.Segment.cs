// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	public partial class Eight : UserControl
	{
		private RectangleF GroundRectangle => new RectangleF(0, 0, Width, Height);
		private SizeF DotSize => new SizeF(Height / 8F, Height / 8F);
		private RectangleF DotRectangle => new RectangleF(P(125, 175), DotSize);
		private Double Scope => Height / 200D;
		private PointF P (Double SX, Double SY) => new PointF(Convert.ToSingle(SX * Scope), Convert.ToSingle(SY * Scope));
		private Dictionary<Int32, PointF[]> SegmentPoints => new Dictionary<int, PointF[]>
		{
			{ 0, new PointF[] { P(45.625, 12.5), P(56.25, 25), P(116.25, 25), P(130.625, 12.5), P(120, 0), P(60, 0) } },
			{ 1, new PointF[] { P(134.875, 17.5), P(120.5, 30), P(112.175, 85.5), P(123.25, 95), P(137.625, 82.5), P(145.5, 30) } },
			{ 2, new PointF[] { P(121.75, 105), P(107.375, 117.5), P(99.5, 170), P(110.125, 182.5), P(124.5, 170), P(132.375, 117.5) } },
			{ 3, new PointF[] { P(19.375, 187.5), P(30, 200), P(90, 200), P(104.375, 187.5), P(93.75, 175), P(33.75, 175) } },
			{ 4, new PointF[] { P(26.375, 107.5), P(12.375, 117.5), P(4.5, 170), P(15.125, 182.5), P(29.5, 170), P(37.375, 117.5) } },
			{ 5, new PointF[] { P(39.875, 17.5), P(25.5, 30), P(17.625, 82.5), P(28.25, 95), P(42.625, 82.5), P(50.5, 30) } },
			{ 6, new PointF[] { P(32.5, 100), P(43.125, 112.5), P(103.125, 112.5), P(117.5, 100), P(106.875, 87.5), P(46.875, 87.5) } }
		};
		/// <summary>Draw Char</summary><param name="C"></param>
		public void DrawChar (Char C) { if (!ExistSeven(C)) return; ShownChar = SegmentSeven(C); DrawAll(); }
		private Byte Log2 (Byte Number) => Convert.ToByte(Log(Number) / Log(2));
		private void DrawGround () => G.FillRectangle(new SolidBrush(GroundColor), GroundRectangle);
		private void DrawON (Byte Segment) => G.FillPolygon(new SolidBrush(OnColor), SegmentPoints[Segment]);
		private void DrawOFF (Byte Segment) => G.FillPolygon(new SolidBrush(OffColor), SegmentPoints[Segment]);
		private void DrawDot () => G.FillEllipse(new SolidBrush(ShownDot ? OnColor : OffColor), DotRectangle);
		/// <summary>Draw Segment</summary><param name="Value"></param>
		public void DrawSegment (Byte Value)
		{ ShownChar = Value; for (Byte i = 1; i <= 64; i <<= 1) if ((i & Value) > 0) DrawON(Log2(i)); else DrawOFF(Log2(i)); }
		private void DrawAll () { DrawGround(); DrawSegment(ShownChar); DrawDot(); }
	}
}
