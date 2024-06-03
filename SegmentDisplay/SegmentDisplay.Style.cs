// Ignore Spelling: RTYC

namespace RTYC.SegmentDisplay
{
	/// <summary>Segment Display Style</summary>
	public static class SegmentDisplayStyle
	{
		/// <summary>Word Style</summary>
		public enum WordStyle
		{
			/// <summary>None</summary>
			None = 0,
			/// <summary>Start Of Heading - SOH</summary>
			SOH = 1,
			/// <summary>Start Of Text - STX </summary>
			STX = 2,
			/// <summary>End Of Text - ETX </summary>
			ETX = 3,
			/// <summary>End Of Transmission - EOT </summary>
			EOT = 4,
			/// <summary>Enquiry - ENQ </summary>
			ENQ = 5,
			/// <summary>Acknowledge - ACK </summary>
			ACK = 6,
			/// <summary>Bell - BEL </summary>
			BEL = 7,
			/// <summary>Backspace - BS </summary>
			BS = 8,
			/// <summary>Horizontal Tab - HT </summary>
			HT = 9,
			/// <summary>Line Feed/New Line - LF/NL</summary>
			LF_NL = 10,
			/// <summary>Vertical Tab - VT </summary>
			VT = 11,
			/// <summary>Form Feed/New Page - FF/NP </summary>
			FF_NP = 12,
			/// <summary>Carriage Return - CR </summary>
			CR = 13,
			/// <summary>Shift Out - SO </summary>
			SO = 14,
			/// <summary>Shift In - SI </summary>
			SI = 15,
			/// <summary>Data Link Escape - DLE </summary>
			DLE = 16,
			/// <summary>Device Control 1/Transmission On - DC1/XON</summary>
			DC1_XON = 17,
			/// <summary>Device Control 2 - DC2</summary>
			DC2 = 18,
			/// <summary>Device Control 3/Transmission Off - DC3/XOFF</summary>
			DC3_XOFF = 19,
			/// <summary>Device Control 4 - DC4 </summary>
			DC4 = 20,
			/// <summary>Negative Acknowledge - NAK </summary>
			NAK = 21,
			/// <summary>Synchronous Idle - SYN </summary>
			SYN = 22,
			/// <summary>End of Transmission Block - ETB </summary>
			ETB = 23,
			/// <summary>Cancel - CAN </summary>
			CAN = 24,
			/// <summary>End of Medium - EM </summary>
			EM = 25,
			/// <summary>Substitute - SUB </summary>
			SUB = 26,
			/// <summary>Escape - ESC </summary>
			ESC = 27,
			/// <summary>File Separator - FS </summary>
			FS = 28,
			/// <summary>Group Separator - GS </summary>
			GS = 29,
			/// <summary>Record Separator - RS </summary>
			RS = 30,
			/// <summary>Unit Separator - US </summary>
			US = 31,
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
			Tilde = 126,
			/// <summary>Delete - DEL</summary>
			DEL = 127
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
