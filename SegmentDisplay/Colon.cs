// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display - Colon</summary>
	public class Colon : SegmentDisplay
	{
		private protected override Single Aspect => 0.125F;
		private protected override Size InitSize => new Size(25, 200);
		private protected override String InitName => "ColonSegmentDisplay";
		private protected override Dictionary<ushort, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, REmpty }, { 0X1, REmpty }, { 0X2, REmpty }, { 0X3, REmpty }, { 0X4, REmpty }, { 0X5, REmpty }, { 0X6, REmpty }, { 0X7, REmpty },
			{ 0X8, REmpty }, { 0X9, REmpty }, { 0XA, REmpty }, { 0XB, REmpty }, { 0XC, REmpty }, { 0XD, REmpty }, { 0XE, REmpty }, { 0XF, REmpty }
		};
		private protected override Dictionary<WordStyle, UInt16> WordMapping => new Dictionary<WordStyle, UInt16>
		{
			{ WordStyle.None, 0 }, { WordStyle.Space, 0 }, { WordStyle.Exclamatory, 0 }, { WordStyle.DoubleQuotation, 0 }, { WordStyle.Sharp, 0 },
			{ WordStyle.Dollar, 0 }, { WordStyle.Percent, 0 }, { WordStyle.And, 0 }, { WordStyle.SingleQuotation, 0 }, { WordStyle.LeftRoundBracket, 0 },
			{ WordStyle.RightRoundBracket, 0 }, { WordStyle.Star, 0 }, { WordStyle.Add, 0 }, { WordStyle.Comma, 0 }, { WordStyle.Dash, 0 },
			{ WordStyle.Dot, 0 }, { WordStyle.Slash, 0 }, { WordStyle.Digit0, 0 }, { WordStyle.Digit1, 0 }, { WordStyle.Digit2, 0 },
			{ WordStyle.Digit3, 0 }, { WordStyle.Digit4, 0 }, { WordStyle.Digit5, 0 }, { WordStyle.Digit6, 0 }, { WordStyle.Digit7, 0 },
			{ WordStyle.Digit8, 0 }, { WordStyle.Digit9, 0 }, { WordStyle.Colon, 0 }, { WordStyle.Semicolon, 0 }, { WordStyle.LeftAngelBracket, 0 },
			{ WordStyle.Equal, 0 }, { WordStyle.RightAngelBracket, 0 }, { WordStyle.Question, 0 }, { WordStyle.At, 0 }, { WordStyle.A, 0 },
			{ WordStyle.B, 0 }, { WordStyle.C, 0 }, { WordStyle.D, 94 }, { WordStyle.E, 121 }, { WordStyle.F, 0 }, { WordStyle.G, 0 },
			{ WordStyle.H, 0 }, { WordStyle.I, 0 }, { WordStyle.J, 0 }, { WordStyle.K, 0 }, { WordStyle.L, 0 }, { WordStyle.M, 0 },
			{ WordStyle.N, 0 }, { WordStyle.O, 0 }, { WordStyle.P, 0 }, { WordStyle.Q, 0 }, { WordStyle.R, 0 }, { WordStyle.S, 0 },
			{ WordStyle.T, 0 }, { WordStyle.U, 0 }, { WordStyle.V, 0 }, { WordStyle.W, 0 }, { WordStyle.X, 0 }, { WordStyle.Y, 0 },
			{ WordStyle.Z, 0 }, { WordStyle.LeftSquareBracket, 0 }, { WordStyle.BackSlash, 0 }, { WordStyle.RightSquareBracket, 0 },
			{ WordStyle.Caret, 0 }, { WordStyle.UnderLine, 0 }, { WordStyle.BackQuote, 0 }, { WordStyle.a, 0 }, { WordStyle.b, 0 },
			{ WordStyle.c, 0 }, { WordStyle.d, 0 }, { WordStyle.e, 0 }, { WordStyle.f, 0 }, { WordStyle.g, 0 }, { WordStyle.h, 0 },
			{ WordStyle.i, 0 }, { WordStyle.j, 0 }, { WordStyle.k, 0 }, { WordStyle.l, 0 }, { WordStyle.m, 0 }, { WordStyle.n, 0 },
			{ WordStyle.o, 0 }, { WordStyle.p, 0 }, { WordStyle.q, 0 }, { WordStyle.r, 0 }, { WordStyle.s, 0 }, { WordStyle.t, 0 },
			{ WordStyle.u, 0 }, { WordStyle.v, 0 }, { WordStyle.w, 0 }, { WordStyle.x, 0 }, { WordStyle.y, 0 }, { WordStyle.z, 0 },
			{ WordStyle.LeftCurlyBracket, 0 }, { WordStyle.Vertical, 0 }, { WordStyle.RightCurlyBracket, 0 }, { WordStyle.Tilde, 0 }
		};
		private protected override Dictionary<Byte, Region> SymbolRegion => SREmpty;
		private protected override Dictionary<DotStyle, Byte> DotMapping => DMEmpty;
		private Boolean StateValue = true;
		/// <summary>Colon State: True as ON, False as OFF</summary>
		public Boolean State { get => StateValue; set { StateValue = value; DrawAll(); } }
		private RectangleF[] ColonSegment => new RectangleF[] { R(0, 37.5F, 25, 25), R(0, 137.5F, 25, 25) };
		private Brush ColonBrush => new SolidBrush(State ? OnColor : OffColor);
		private void DrawColon () => G.FillRectangles(ColonBrush, ColonSegment);
		private protected override void DrawAll () { DrawGround(); DrawColon(); }
	}
}
