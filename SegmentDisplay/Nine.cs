﻿// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display - Nine</summary>
	public class Nine : SegmentDisplay
	{
		private protected override Single Aspect => 0.6F;
		private protected override Size InitSize => new Size(120, 200);
		private protected override String InitName => "NineSegmentDisplay";
		private protected override Dictionary<UInt16, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, RP(new Single[] { 17.5F, 12.5F, 30, 25, 90, 25, 102.5F, 12.5F, 90, 0, 30, 0 }) },
			{ 0X1, RP(new Single[] { 107.5F, 17.5F, 95, 30, 95, 85.5F, 107.5F, 95, 120, 82.5F, 120, 30 }) },
			{ 0X2, RP(new Single[] { 107.5F,105, 95,117.5F, 95, 170, 107.5F, 182.5F, 120, 170, 120, 117.5F }) },
			{ 0X3, RP(new Single[] { 17.5F, 187.5F, 30, 200, 90, 200, 102.5F, 187.5F, 90, 175, 30, 175 }) },
			{ 0X4, RP(new Single[] { 12.5F, 107.5F, 0, 117.5F, 0, 170, 12.5F, 182.5F, 25, 170, 25, 117.5F }) },
			{ 0X5, RP(new Single[] { 12.5F, 17.5F, 0, 30, 0, 82.5F, 12.5F, 95, 25, 82.5F, 25, 30 }) },
			{ 0X6, RP(new Single[] { 17.5F, 100, 30, 112.5F, 90, 112.5F, 102.5F, 100, 90, 87.5F, 30, 87.5F }) },
			{ 0X7, RP(new Single[] { 90, 30, 78.7F, 30, 60, 77.2F, 60, 82.5F, 71.3F, 82.5F, 90, 35.3F }) },
			{ 0X8, RP(new Single[] { 60, 117.5F, 48.7F, 117.5F, 30, 164.7F, 30, 170, 41.3F, 170, 60, 122.8F }) },
			{ 0X9, REmpty }, { 0XA, REmpty }, { 0XB, REmpty }, { 0XC, REmpty }, { 0XD, REmpty }, { 0XE, REmpty }, { 0XF, REmpty }
		};
		private protected override Dictionary<WordStyle, UInt16> WordMapping => new Dictionary<WordStyle, UInt16>
		{
			{ WordStyle.None, 0 }, { WordStyle.Space, 0 }, { WordStyle.Exclamatory, 0 }, { WordStyle.DoubleQuotation, 0 }, { WordStyle.Sharp, 0 },
			{ WordStyle.Dollar, 0 }, { WordStyle.Percent, 0 }, { WordStyle.And, 0 }, { WordStyle.SingleQuotation, 0 }, { WordStyle.LeftRoundBracket, 0 },
			{ WordStyle.RightRoundBracket, 0 }, { WordStyle.Star, 0 }, { WordStyle.Add, 0 }, { WordStyle.Comma, 0 }, { WordStyle.Dash, 64 },
			{ WordStyle.Dot, 0 }, { WordStyle.Slash, 0 }, { WordStyle.Digit0, 63 }, { WordStyle.Digit1, 134 }, { WordStyle.Digit2, 91 },
			{ WordStyle.Digit3, 205 }, { WordStyle.Digit4, 102 }, { WordStyle.Digit5, 109 }, { WordStyle.Digit6, 125 }, { WordStyle.Digit7, 385 },
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
		private protected override Dictionary<Byte, Region> SymbolRegion => SREmpty;
		private protected override Dictionary<DotStyle, Byte> DotMapping => DMEmpty;
	}
}