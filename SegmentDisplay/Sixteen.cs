// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display - Sixteen</summary>
	public partial class Sixteen : SegmentDisplay
	{
		private protected override Single Aspect => 0.9F;
		private protected override Size InitSize => new Size(180, 200);
		private protected override String InitName => "SixteenSegmentDisplay";
		private protected override Dictionary<UInt16, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, RP(new Single[] { 39.5F, 10, 48, 20, 156, 20, 167.5F, 10, 159, 0, 51, 0 }) },
			{ 0X1, RP(new Single[] { 168.4F, 11, 156.9F, 21, 146.7F, 89, 155.2F, 99, 166.7F, 89, 176.9F, 21 }) },
			{ 0X2, RP(new Single[] { 154.9F, 101, 143.4F, 111, 133.2F, 179, 141.7F, 189, 153.2F, 179, 163.4F, 111 }) },
			{ 0X3, RP(new Single[] { 12.5F, 190, 21, 200, 129, 200, 140.5F, 190, 132, 180, 24, 180 }) },
			{ 0X4, RP(new Single[] { 24.9F, 101, 13.4F, 111, 3.2F, 179, 11.7F, 189, 23.2F, 179, 33.4F, 111 }) },
			{ 0X5, RP(new Single[] { 38.4F, 11, 26.9F, 21, 16.7F, 89, 25.2F, 99, 36.7F, 89, 46.9F, 21 }) },
			{ 0X6, RP(new Single[] { 26, 100, 34.5F, 110, 97.5F, 110, 89, 100, 80.5F, 90, 37.5F, 90 }) },
			{ 0X7, RP(new Single[] { 91, 100, 99.5F, 110, 142.5F, 110, 154, 100, 145.5F, 90, 102.5F, 90 }) },
			{ 0X8, RP(new Single[] { 47.9F, 21, 46.2F, 31.8F, 73.8F, 89, 80.7F, 89, 82.3F, 78.2F, 54.7F, 21 }) },
			{ 0X9, RP(new Single[] { 91.9F, 21, 81.7F, 89, 90.2F, 99, 101.7F, 89, 111.9F, 21 }) },
			{ 0XA, RP(new Single[] { 155.9F, 21, 149, 21, 104.7F, 75.2F, 102.7F, 89, 109.5F, 89, 154.2F, 31.8F }) },
			{ 0XB, RP(new Single[] { 77.4F, 111, 70.5F, 111, 25.8F, 168.2F, 24.2F, 179, 31, 179, 75.7F, 121.8F }) },
			{ 0XC, RP(new Single[] { 89.9F, 101, 78.4F, 111, 68.2F, 179, 88.2F, 179, 98.4F, 111 }) },
			{ 0XD, RP(new Single[] { 99.4F, 111, 97.7F, 121.8F, 125.3F, 179, 132.2F, 179, 133.8F, 168.2F, 106.2F, 111 }) },
			{ 0XE, REmpty }, { 0XF, REmpty }
		};
		private protected override Dictionary<WordStyle, UInt16> WordMapping => new Dictionary<WordStyle, UInt16>
		{
			{ WordStyle.None, 0 }, { WordStyle.Space, 0 }, { WordStyle.Exclamatory, 0 }, { WordStyle.DoubleQuotation, 544 }, { WordStyle.Sharp, 0 },
			{ WordStyle.Dollar, 0 }, { WordStyle.Percent, 0 }, { WordStyle.And, 0 }, { WordStyle.SingleQuotation, 0 }, { WordStyle.LeftRoundBracket, 0 },
			{ WordStyle.RightRoundBracket, 0 }, { WordStyle.Star, 11712 }, { WordStyle.Add, 4800 }, { WordStyle.Comma, 0 }, { WordStyle.Dash, 192 },
			{ WordStyle.Dot, 0 }, { WordStyle.Slash, 2560 }, { WordStyle.Digit0, 3135 }, { WordStyle.Digit1, 1030 }, { WordStyle.Digit2, 219 },
			{ WordStyle.Digit3, 143 }, { WordStyle.Digit4, 230 }, { WordStyle.Digit5, 237 }, { WordStyle.Digit6, 253 }, { WordStyle.Digit7, 5121 },
			{ WordStyle.Digit8, 255 }, { WordStyle.Digit9, 239 }, { WordStyle.Colon, 0 }, { WordStyle.Semicolon, 0 }, { WordStyle.LeftAngelBracket, 8704 },
			{ WordStyle.Equal, 0 }, { WordStyle.RightAngelBracket, 2304 }, { WordStyle.Question, 0 }, { WordStyle.At, 0 }, { WordStyle.A, 247 },
			{ WordStyle.B, 4751 }, { WordStyle.C, 57 }, { WordStyle.D, 4623 }, { WordStyle.E, 249 }, { WordStyle.F, 241 }, { WordStyle.G, 189 },
			{ WordStyle.H, 246 }, { WordStyle.I, 4617 }, { WordStyle.J, 30 }, { WordStyle.K, 9328 }, { WordStyle.L, 56 }, { WordStyle.M, 1334 },
			{ WordStyle.N, 8502 }, { WordStyle.O, 63 }, { WordStyle.P, 243 }, { WordStyle.Q, 8255 }, { WordStyle.R, 8435 }, { WordStyle.S, 397 },
			{ WordStyle.T, 4609 }, { WordStyle.U, 62 }, { WordStyle.V, 3120 }, { WordStyle.W, 10294 }, { WordStyle.X, 11520 }, { WordStyle.Y, 5376 },
			{ WordStyle.Z, 3081 }, { WordStyle.LeftSquareBracket, 0 }, { WordStyle.BackSlash, 8448 }, { WordStyle.RightSquareBracket, 0 },
			{ WordStyle.Caret, 0 }, { WordStyle.UnderLine, 8 }, { WordStyle.BackQuote, 0 }, { WordStyle.a, 247 }, { WordStyle.b, 4751 },
			{ WordStyle.c, 57 }, { WordStyle.d, 4623 }, { WordStyle.e, 249 }, { WordStyle.f, 241 }, { WordStyle.g, 189 }, { WordStyle.h, 246 },
			{ WordStyle.i, 4617 }, { WordStyle.j, 30 }, { WordStyle.k, 9328 }, { WordStyle.l, 56 }, { WordStyle.m, 1334 }, { WordStyle.n, 8502 },
			{ WordStyle.o, 63 }, { WordStyle.p, 243 }, { WordStyle.q, 8255 }, { WordStyle.r, 8435 }, { WordStyle.s, 397 }, { WordStyle.t, 4609 },
			{ WordStyle.u, 62 }, { WordStyle.v, 3120 }, { WordStyle.w, 10294 }, { WordStyle.x, 11520 }, { WordStyle.y, 5376 }, { WordStyle.z, 3081 },
			{ WordStyle.LeftCurlyBracket, 0 }, { WordStyle.Vertical, 4608 }, { WordStyle.RightCurlyBracket, 0 }, { WordStyle.Tilde, 0 }
		};
		private Rectangle RR (Single X, Single Y, Single W, Single H) => Rectangle.Round(R(X, Y, W, H));
		private GraphicsPath GP0 { get { GraphicsPath GP = new GraphicsPath(); GP.AddEllipse(R(160, 160, 20, 20)); return GP; } }
		private GraphicsPath GP1
		{
			get
			{
				GraphicsPath GP = new GraphicsPath(); GP.AddPie(RR(120, 160, 60, 40), 0, 90);
				GP.AddArc(RR(160, 175, 20, 10), 0, 180); GP.AddPie(RR(140, 160, 20, 40), 0, 90); return GP;
			}
		}
		private protected override Dictionary<Byte, Region> SymbolRegion
		{ get { Dictionary<Byte, Region> SR = SREmpty; SR[0] = new Region(GP0); SR[1] = new Region(GP1); return SR; } }
		private protected override Dictionary<DotStyle, Byte> DotMapping => new Dictionary<DotStyle, Byte>
		{ { DotStyle.None, 0 }, { DotStyle.Dot, 1 }, { DotStyle.Comma, 3 } };
	}
}
