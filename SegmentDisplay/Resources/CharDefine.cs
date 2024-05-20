// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;

namespace RTYC.SegmentDisplay
{
	internal static class CharDefine
	{
		#region Region - Seven
		private static readonly Dictionary<Char, Byte> DefineSeven = new Dictionary<Char, Byte>
		{
			{ '1', 6 }, { '2', 91 }, { '3', 79 }, { '4', 102 }, { '5', 109 }, { '6', 125 }, { '7', 7 }, { '8', 127 }, { '9', 111 }, { '0', 63 },
			{ 'a', 119 }, { 'b', 124 }, { 'c', 57 }, { 'd', 94 }, { 'e', 121 }, { 'f', 49 }, { 'g', 61 }, { 'h', 118 }, { 'i', 48 }, { 'j', 14 },
			{ 'k', 117 }, { 'l', 56 }, { 'm', 55 }, { 'n', 84 }, { 'o', 92 }, { 'p', 115 }, { 'q', 103 }, { 'r', 113 }, { 's', 73 }, { 't', 120 },
			{ 'u', 62 }, { 'v', 28 }, { 'w', 126 }, { 'x', 100 }, { 'y', 110 }, { 'z', 90 }, { 'A', 119 }, { 'B', 124 }, { 'C', 57 }, { 'D', 94 },
			{ 'E', 121 }, { 'F', 49 }, { 'G', 61 }, { 'H', 118 }, { 'I', 48 }, { 'J', 14 }, { 'K', 117 }, { 'L', 56 }, { 'M', 55 }, { 'N', 84 },
			{ 'O', 92 }, { 'P', 115 }, { 'Q', 103 }, { 'R', 113 }, { 'S', 73 }, { 'T', 120 }, { 'U', 62 }, { 'V', 28 }, { 'W', 126 }, { 'X', 100 },
			{ 'Y', 110 }, { 'Z', 90 }, { '-', 64 }, { '_', 8 }, { '[', 88 }, { ']', 76 }, { '{', 88 }, { '}', 76 }, { '(', 88 }, { ')', 76 },
			{ '<', 88 }, { '>', 76 }, { '.', 12 }, { ',', 12 }, { '?', 83 }, { ':', 4 }, { ';', 4 }, { '\'', 96 }, { '"', 34 }, { '/', 80 }, { '\\', 68 },
			{ ' ', 0 }
		};
		internal static Byte SegmentSeven (Char Word) => DefineSeven[Word];
		internal static Boolean ExistSeven (Char Word) => DefineSeven.ContainsKey(Word);
		internal static Char SearchSeven (Byte B) { foreach (Char C in DefineSeven.Keys) if (DefineSeven[C] == B) return C; return Char.MinValue; }
		#endregion
		#region Region - Nine
		private static readonly Dictionary<Char, UInt16> DefineNine = new Dictionary<Char, UInt16>
		{ {'1', 134 }, {'2', 91 }, {'3', 205 }, {'4', 102 }, {'5', 109 }, {'6', 125 }, {'7', 385 }, {'8', 127 }, {'9', 111 }, {'0', 63 }, { ' ', 0 } };
		internal static UInt16 SegmentNine(Char Word) => DefineNine[Word];
		internal static Boolean ExistNine (Char Word) => DefineNine.ContainsKey(Word);
		internal static Char SearchNine (UInt32 I) { foreach (Char C in DefineNine.Keys) if (DefineNine[C] == I) return C; return Char.MinValue; }
		#endregion
	}
}
