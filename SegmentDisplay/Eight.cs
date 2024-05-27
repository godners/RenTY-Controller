// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display - Eight</summary>
	public class Eight : SegmentDisplay
	{
		private protected override Single Aspect => 0.75F;
		private protected override Size InitSize => new Size(150, 200);
		private protected override String InitName => "EightSegmentDisplay";
		private protected override Dictionary<UInt16, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, RP(new Single[] { 45.625F, 12.5F, 56.25F, 25, 116.25F, 25, 130.625F, 12.5F, 120, 0, 60, 0 }) },
			{ 0X1, RP(new Single[] { 134.875F, 17.5F, 120.5F, 30, 112.175F, 85.5F, 123.25F, 95, 137.625F, 82.5F, 145.5F, 30 }) },
			{ 0X2, RP(new Single[] { 121.75F, 105, 107.375F, 117.5F, 99.5F, 170, 110.125F, 182.5F, 124.5F, 170, 132.375F, 117.5F }) },
			{ 0X3, RP(new Single[] { 19.375F, 187.5F, 30, 200, 90, 200, 104.375F, 187.5F, 93.75F, 175, 33.75F, 175 }) },
			{ 0X4, RP(new Single[] { 26.375F, 107.5F, 12.375F, 117.5F, 4.5F, 170, 15.125F, 182.5F, 29.5F, 170, 37.375F, 117.5F }) },
			{ 0X5, RP(new Single[] { 39.875F, 17.5F, 25.5F, 30, 17.625F, 82.5F, 28.25F, 95, 42.625F, 82.5F, 50.5F, 30 }) },
			{ 0X6, RP(new Single[] { 32.5F, 100, 43.125F, 112.5F, 103.125F, 112.5F, 117.5F, 100, 106.875F, 87.5F, 46.875F, 87.5F }) },
			{ 0X7, REmpty }, { 0X8, REmpty }, { 0X9, REmpty }, { 0XA, REmpty }, { 0XB, REmpty },
			{ 0XC, REmpty }, { 0XD, REmpty }, { 0XE, REmpty }, { 0XF, REmpty }
		};
		private protected override Dictionary<WordStyle, UInt16> WordMapping => new Dictionary<WordStyle, UInt16>
		{
			{ WordStyle.None, 0 }, { WordStyle.Space, 0 }, { WordStyle.Exclamatory, 0 }, { WordStyle.DoubleQuotation, 0 }, { WordStyle.Sharp, 0 },
			{ WordStyle.Dollar, 0 }, { WordStyle.Percent, 0 }, { WordStyle.And, 0 }, { WordStyle.SingleQuotation, 0 }, { WordStyle.LeftRoundBracket, 0 },
			{ WordStyle.RightRoundBracket, 0 }, { WordStyle.Star, 0 }, { WordStyle.Add, 0 }, { WordStyle.Comma, 0 }, { WordStyle.Dash, 64 },
			{ WordStyle.Dot, 0 }, { WordStyle.Slash, 0 }, { WordStyle.Digit0, 63 }, { WordStyle.Digit1, 6 }, { WordStyle.Digit2, 91 },
			{ WordStyle.Digit3, 79 }, { WordStyle.Digit4, 102 }, { WordStyle.Digit5, 109 }, { WordStyle.Digit6, 125 }, { WordStyle.Digit7, 7 },
			{ WordStyle.Digit8, 127 }, { WordStyle.Digit9, 111 }, { WordStyle.Colon, 0 }, { WordStyle.Semicolon, 0 }, { WordStyle.LeftAngelBracket, 0 },
			{ WordStyle.Equal, 0 }, { WordStyle.RightAngelBracket, 0 }, { WordStyle.Question, 0 }, { WordStyle.At, 0 }, { WordStyle.A, 119 },
			{ WordStyle.B, 124 }, { WordStyle.C, 57 }, { WordStyle.D, 94 }, { WordStyle.E, 121 }, { WordStyle.F, 113 }, { WordStyle.G, 0 },
			{ WordStyle.H, 0 }, { WordStyle.I, 0 }, { WordStyle.J, 0 }, { WordStyle.K, 0 }, { WordStyle.L, 0 }, { WordStyle.M, 0 },
			{ WordStyle.N, 0 }, { WordStyle.O, 0 }, { WordStyle.P, 0 }, { WordStyle.Q, 0 }, { WordStyle.R, 0 }, { WordStyle.S, 0 },
			{ WordStyle.T, 0 }, { WordStyle.U, 0 }, { WordStyle.V, 0 }, { WordStyle.W, 0 }, { WordStyle.X, 0 }, { WordStyle.Y, 0 },
			{ WordStyle.Z, 0 }, { WordStyle.LeftSquareBracket, 0 }, { WordStyle.BackSlash, 0 }, { WordStyle.RightSquareBracket, 0 },
			{ WordStyle.Caret, 0 }, { WordStyle.UnderLine, 8 }, { WordStyle.BackQuote, 0 }, { WordStyle.a, 119 }, { WordStyle.b, 124 },
			{ WordStyle.c, 57 }, { WordStyle.d, 94 }, { WordStyle.e, 121 }, { WordStyle.f, 113 }, { WordStyle.g, 0 }, { WordStyle.h, 0 },
			{ WordStyle.i, 0 }, { WordStyle.j, 0 }, { WordStyle.k, 0 }, { WordStyle.l, 0 }, { WordStyle.m, 0 }, { WordStyle.n, 0 },
			{ WordStyle.o, 0 }, { WordStyle.p, 0 }, { WordStyle.q, 0 }, { WordStyle.r, 0 }, { WordStyle.s, 0 }, { WordStyle.t, 0 },
			{ WordStyle.u, 0 }, { WordStyle.v, 0 }, { WordStyle.w, 0 }, { WordStyle.x, 0 }, { WordStyle.y, 0 }, { WordStyle.z, 0 },
			{ WordStyle.LeftCurlyBracket, 0 }, { WordStyle.Vertical, 0 }, { WordStyle.RightCurlyBracket, 0 }, { WordStyle.Tilde, 0 }
		};
		private GraphicsPath GP0 { get { GraphicsPath GP = new GraphicsPath(); GP.AddEllipse(R(125, 175, 25, 25)); return GP; } }
		private protected override Dictionary<Byte, Region> SymbolRegion
		{ get { Dictionary<Byte, Region> SR = SREmpty; SR[0] = new Region(GP0); return SR; } }
		private protected override Dictionary<DotStyle, Byte> DotMapping => new Dictionary<DotStyle, Byte>
		{ { DotStyle.None, 0 }, { DotStyle.Dot, 1 }, { DotStyle.Comma, 0 } };
	}
}
