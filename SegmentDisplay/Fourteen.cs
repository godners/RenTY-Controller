// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	/// <summary>Define Control</summary>
	public class Fourteen : SegmentDisplay
	{
		/// <summary>Initialize Component</summary>
		public Fourteen () => base.InitializeComponent();
		private protected override Single Aspect => 0.75F;
		private protected override Size InitSize => new Size(150, 200);
		private protected override string InitName => "FourteenSegmentDisplay";
		private protected override Dictionary<UInt16, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, RP(new Single[] { 11, 10, 21, 20, 129, 20, 139, 10, 129, 0, 21, 0 }) },
			{ 0X1, RP(new Single[] { 140, 11, 130, 21, 130, 89, 140, 99, 150, 89, 150, 21 }) },
			{ 0X2, RP(new Single[] { 140, 101, 130, 111, 130, 179, 140, 189, 150, 179, 150, 111 }) },
			{ 0X3, RP(new Single[] { 11, 190, 21, 200, 129, 200, 139, 190, 129, 180, 21, 180 }) },
			{ 0X4, RP(new Single[] { 10, 101, 0, 111, 0, 179, 10, 189, 20, 179, 20, 111 }) },
			{ 0X5, RP(new Single[] { 10, 11, 0, 21, 0, 89, 10, 99, 20, 89, 20, 21 }) },
			{ 0X6, RP(new Single[] { 11, 100, 21, 110, 84, 110, 74, 100, 64, 90, 21, 90 }) },
			{ 0X7, RP(new Single[] { 76, 100, 86, 110, 129, 110, 139, 100, 129, 90, 86, 90 }) },
			{ 0X8, RP(new Single[] { 21, 21, 21, 31.76F, 57.196F, 89, 64, 89, 64, 78.24F, 27.804F, 21 }) },
			{ 0X9, RP(new Single[] { 65, 21, 65, 89, 75, 99, 85, 89, 85, 21 }) },
			{ 0XA, RP(new Single[] { 129, 21, 122.196F, 21, 86, 75.24F, 86, 89, 92.804F, 89, 129, 31.76F }) },
			{ 0XB, RP(new Single[] { 64, 111, 57.196F, 111, 21, 168.24F, 21, 179, 27.804F, 179, 64, 121.76F }) },
			{ 0XC, RP(new Single[] { 75, 101, 65, 111, 65, 179, 85, 179, 85, 111 }) },
			{ 0XD, RP(new Single[] { 86, 111, 86, 121.76F, 122.196F, 179, 129, 179, 129, 168.24F, 92.804F, 111 }) },
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
		private protected override Dictionary<Byte, Region> SymbolRegions => SREmpty;
		private protected override Dictionary<DotStyle, Byte> DotMapping => DMEmpty;
	}
}
