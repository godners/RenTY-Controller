// Ignore Spelling: RTYC

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display Style</summary>
	public static class SegmentDisplayStyle
	{
		#region Region - Seven
		//private static readonly Dictionary<Char, Byte> DefineSeven = new Dictionary<Char, Byte>
		//{
		//	{ '1', 6 }, { '2', 91 }, { '3', 79 }, { '4', 102 }, { '5', 109 }, { '6', 125 }, { '7', 7 }, { '8', 127 }, { '9', 111 }, { '0', 63 },
		//	{ 'a', 119 }, { 'b', 124 }, { 'c', 57 }, { 'd', 94 }, { 'e', 121 }, { 'f', 49 }, { 'g', 61 }, { 'h', 118 }, { 'i', 48 }, { 'j', 14 },
		//	{ 'k', 117 }, { 'l', 56 }, { 'm', 55 }, { 'n', 84 }, { 'o', 92 }, { 'p', 115 }, { 'q', 103 }, { 'r', 113 }, { 's', 73 }, { 't', 120 },
		//	{ 'u', 62 }, { 'v', 28 }, { 'w', 126 }, { 'x', 100 }, { 'y', 110 }, { 'z', 90 }, { 'A', 119 }, { 'B', 124 }, { 'C', 57 }, { 'D', 94 },
		//	{ 'E', 121 }, { 'F', 49 }, { 'G', 61 }, { 'H', 118 }, { 'I', 48 }, { 'J', 14 }, { 'K', 117 }, { 'L', 56 }, { 'M', 55 }, { 'N', 84 },
		//	{ 'O', 92 }, { 'P', 115 }, { 'Q', 103 }, { 'R', 113 }, { 'S', 73 }, { 'T', 120 }, { 'U', 62 }, { 'V', 28 }, { 'W', 126 }, { 'X', 100 },
		//	{ 'Y', 110 }, { 'Z', 90 }, { '-', 64 }, { '_', 8 }, { '[', 88 }, { ']', 76 }, { '{', 88 }, { '}', 76 }, { '(', 88 }, { ')', 76 },
		//	{ '<', 88 }, { '>', 76 }, { '.', 12 }, { ',', 12 }, { '?', 83 }, { ':', 4 }, { ';', 4 }, { '\'', 96 }, { '"', 34 }, { '/', 80 }, { '\\', 68 },
		//	{ ' ', 0 }
		//};
		//internal static Byte SegmentSeven (Char Word) => DefineSeven[Word];
		//internal static Boolean ExistSeven (Char Word) => DefineSeven.ContainsKey(Word);
		//internal static Char SearchSeven (Byte B) { foreach (Char C in DefineSeven.Keys) if (DefineSeven[C] == B) return C; return Char.MinValue; }
		#endregion
		#region Region - Nine
		private static readonly Dictionary<Char, UInt16> DefineNine = new Dictionary<Char, UInt16>
		{ {'1', 134 }, {'2', 91 }, {'3', 205 }, {'4', 102 }, {'5', 109 }, {'6', 125 }, {'7', 385 }, {'8', 127 }, {'9', 111 }, {'0', 63 }, { ' ', 0 } };
		internal static UInt16 SegmentNine(Char Word) => DefineNine[Word];
		internal static Boolean ExistNine (Char Word) => DefineNine.ContainsKey(Word);
		internal static Char SearchNine (UInt32 I) { foreach (Char C in DefineNine.Keys) if (DefineNine[C] == I) return C; return Char.MinValue; }
		#endregion

		/// <summary>Word Style</summary>
		public enum WordStyle
		{ 
			/// <summary>None</summary>
			None = 0,
			/// <summary>Space</summary>
			Space = 32,
			/// <summary>Exclamatory - !</summary>
			Exclamatory = 33,
			/// <summary>Double Quotation - <![CDATA["]]></summary>
			DoubleQuotation = 34,
			/// <summary>Sharp - #</summary>
			Sharp = 35,
			/// <summary>Dollar - $</summary>
			Dollar = 36,
			/// <summary>Percent - %</summary>
			Percent = 37,
			/// <summary>And - <![CDATA[&]]></summary>
			And = 38,
			/// <summary>Single Quotation - <![CDATA[']]></summary>
			SingleQuotation = 39,
			/// <summary>Left Round Bracket - (</summary>
			LeftRoundBracket = 40,
			/// <summary>Right Round Bracket - )</summary>
			RightRoundBracket = 41,
			/// <summary>Star - *</summary>
			Star = 42,
			/// <summary>Add - +</summary>
			Add = 43,
			/// <summary>Comma - ,</summary>
			Comma = 44,
			/// <summary>Dash - -</summary>
			Dash = 45,
			/// <summary>Dot - .</summary>
			Dot = 46,
			/// <summary>Slash - /</summary>
			Slash = 47,
			/// <summary>Digit Zero - 0</summary>
			Digit0 = 48,
			/// <summary>Digit One - 1</summary>
			Digit1 = 49,
			/// <summary>Digit Two - 2</summary>
			Digit2 = 50,
			/// <summary>Digit Three - 3</summary>
			Digit3 = 51,
			/// <summary>Digit Four - 4</summary>
			Digit4 = 52,
			/// <summary>Digit Five - 5</summary>
			Digit5 = 53,
			/// <summary>Digit Six - 6</summary>
			Digit6 = 54,
			/// <summary>Digit Seven - 7</summary>
			Digit7 = 55,
			/// <summary>Digit Eight - 8</summary>
			Digit8 = 56,
			/// <summary>Digit Nine - 9</summary>
			Digit9 = 57,
			/// <summary>Colon - :</summary>
			Colon = 58,
			/// <summary>Semicolon - ;</summary>
			Semicolon = 59,
			/// <summary>Left Angel Bracket - <![CDATA[<]]></summary>
			LeftAngelBracket = 60,
			/// <summary>Equal - =</summary>
			Equal = 61,
			/// <summary>Right Angel Bracket - <![CDATA[>]]></summary>
			RightAngelBracket = 62,
			/// <summary>Question - ?</summary>
			Question = 63,
			/// <summary>At - @</summary>
			At = 64,
			/// <summary>Upper Character A - A</summary>
			A = 65,
			/// <summary>Upper Character B - B</summary>
			B = 66,
			/// <summary>Upper Character C - C</summary>
			C = 67,
			/// <summary>Upper Character D - D</summary>
			D = 68,
			/// <summary>Upper Character E - E</summary>
			E = 69,
			/// <summary>Upper Character F - F</summary>
			F = 70,
			/// <summary>Upper Character G - G</summary>
			G = 71,
			/// <summary>Upper Character H - H</summary>
			H = 72,
			/// <summary>Upper Character I - I</summary>
			I = 73,
			/// <summary>Upper Character J - J</summary>
			J = 74,
			/// <summary>Upper Character K - K</summary>
			K = 75,
			/// <summary>Upper Character L - L</summary>
			L = 76,
			/// <summary>Upper Character M - M</summary>
			M = 77,
			/// <summary>Upper Character N - N</summary>
			N = 78,
			/// <summary>Upper Character O - O</summary>
			O = 79,
			/// <summary>Upper Character P - P</summary>
			P = 80,
			/// <summary>Upper Character Q - Q</summary>
			Q = 81,
			/// <summary>Upper Character R - R</summary>
			R = 82,
			/// <summary>Upper Character S - S</summary>
			S = 83,
			/// <summary>Upper Character Y - Y</summary>
			T = 84,
			/// <summary>Upper Character U - U</summary>
			U = 85,
			/// <summary>Upper Character V - V</summary>
			V = 86,
			/// <summary>Upper Character W - W</summary>
			W = 87,
			/// <summary>Upper Character X - X</summary>
			X = 88,
			/// <summary>Upper Character Y - Y</summary>
			Y = 89,
			/// <summary>Upper Character Z - Z</summary>
			Z = 90,
			/// <summary>Left Square Bracket - [</summary>
			LeftSquareBracket = 91,
			/// <summary>Back Slash - \</summary>
			BackSlash = 92,
			/// <summary>Right Square Bracket - ]</summary>
			RightSquareBracket = 93,
			/// <summery>Caret - ^</summery>
			Caret = 94,
			/// <summary>Under Line - _</summary>
			UnderLine = 95,
			/// <summary>Back Quote - `</summary>
			BackQuote = 96,
			/// <summary>Lower Character a - a</summary>
			a = 97,
			/// <summary>Lower Character b - b</summary>
			b = 98,
			/// <summary>Lower Character c - c</summary>
			c = 99,
			/// <summary>Lower Character d - d</summary>
			d = 100,
			/// <summary>Lower Character e - e</summary>
			e = 101,
			/// <summary>Lower Character f - f</summary>
			f = 102,
			/// <summary>Lower Character g - g</summary>
			g = 103,
			/// <summary>Lower Character h - h</summary>
			h = 104,
			/// <summary>Lower Character i - i</summary>
			i = 105,
			/// <summary>Lower Character j - j</summary>
			j = 106,
			/// <summary>Lower Character k - k</summary>
			k = 107,
			/// <summary>Lower Character l - l</summary>
			l = 108,
			/// <summary>Lower Character m - m</summary>
			m = 109,
			/// <summary>Lower Character n - n</summary>
			n = 110,
			/// <summary>Lower Character o - o</summary>
			o = 111,
			/// <summary>Lower Character p - p</summary>
			p = 112,
			/// <summary>Lower Character q - q</summary>
			q = 113,
			/// <summary>Lower Character r - r</summary>
			r = 114,
			/// <summary>Lower Character s - s</summary>
			s = 115,
			/// <summary>Lower Character y - y</summary>
			t = 116,
			/// <summary>Lower Character u - u</summary>
			u = 117,
			/// <summary>Lower Character v - v</summary>
			v = 118,
			/// <summary>Lower Character w - w</summary>
			w = 119,
			/// <summary>Lower Character x - x</summary>
			x = 120,
			/// <summary>Lower Character y - y</summary>
			y = 121,
			/// <summary>Lower Character z - z</summary>
			z = 122,
			/// <summary>Left Curly Bracket - {</summary>
			LeftCurlyBracket = 123,
			/// <summary>Vertical - |</summary>
			Vertical = 124,
			/// <summary>Right Curly Bracket - }</summary>
			RightCurlyBracket = 125,
			/// <summary>Tilde - ~</summary>
			Tilde = 126
		}
		/// <summary>Dot Style</summary>
		public enum DotStyle
		{
			/// <summary>None</summary>
			None = 0,
			/// <summary>Dot</summary>
			Dot = 1,
			/// <summary>Comma</summary>
			Comma = 2
		}
	}
}
