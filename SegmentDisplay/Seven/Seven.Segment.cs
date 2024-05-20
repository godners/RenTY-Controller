// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;
using static RTYC.SegmentDisplay.CharDefine;

namespace RTYC.SegmentDisplay
{
	public partial class Seven : UserControl
	{
		private RectangleF GroundRectangle => new RectangleF(0, 0, Width, Height);
		private Double Scope => Height / 200D;
		private PointF P (Double SX, Double SY) => new PointF(Convert.ToSingle(SX * Scope), Convert.ToSingle(SY * Scope));
		private Dictionary<Int32, PointF[]> SegmentPoints => new Dictionary<Int32, PointF[]>
		{
			{ 0, new PointF[] { P(17.5, 12.5), P(30, 25), P(90, 25), P(102.5, 12.5), P(90, 0), P(30, 0) } },
			{ 1, new PointF[] { P(107.5, 17.5), P(95, 30), P(95, 85.5), P(107.5, 95), P(120, 82.5), P(120, 30) } },
			{ 2, new PointF[] { P(107.5,105), P(95,117.5), P(95, 170), P(107.5, 182.5), P(120, 170), P(120, 117.5) } },
			{ 3, new PointF[] { P(17.5, 187.5), P(30, 200), P(90, 200), P(102.5, 187.5), P(90, 175), P(30, 175) } },
			{ 4, new PointF[] { P(12.5, 107.5), P(0, 117.5), P(0, 170), P(12.5, 182.5), P(25, 170), P(25, 117.5) } },
			{ 5, new PointF[] { P(12.5, 17.5), P(0, 30), P(0, 82.5), P(12.5, 95), P(25, 82.5), P(25, 30) } },
			{ 6, new PointF[] { P(17.5, 100), P(30, 112.5), P(90, 112.5), P(102.5, 100), P(90, 87.5), P(30, 87.5) } }
		};
		/// <summary>Draw Char</summary><param name="C"></param>
		public void DrawChar (Char C) { if (!ExistSeven(C)) return; ShownChar = SegmentSeven(C); DrawAll(); }
		private Byte Log2 (Byte Number) => Convert.ToByte(Log(Number) / Log(2));
		private void DrawGround () => G.FillRectangle(new SolidBrush(GroundColor), GroundRectangle);
		private void DrawON (Byte Segment) => G.FillPolygon(new SolidBrush(OnColor), SegmentPoints[Segment]);
		private void DrawOFF (Byte Segment) => G.FillPolygon(new SolidBrush(OffColor), SegmentPoints[Segment]);
		/// <summary>Draw Segment</summary><param name="Value"></param>
		public void DrawSegment (Byte Value)
		{ ShownChar = Value; DrawGround(); for (Byte i = 1; i <= 64; i <<= 1) if ((i & Value) > 0) DrawON(Log2(i)); else DrawOFF(Log2(i)); }
		private void DrawAll () { DrawGround(); DrawSegment(ShownChar); }
	}
}
