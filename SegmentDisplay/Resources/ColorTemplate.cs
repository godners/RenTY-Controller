// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;

namespace RTYC.SegmentDisplay
{
	/// <summary>Color Template</summary>
	public static class ColorTemplate
	{
		/// <summary>Name</summary>
		public enum TemplateName
		{
			/// <summary>Black and White</summary>
			Black = 0,
			/// <summary>White and Black</summary>
			White = 1,
			/// <summary>Red and Black</summary>
			Red = 2,
			/// <summary>Green and Black</summary>
			Green = 3,
			/// <summary>Orange and Black</summary>
			Orange = 4
		}
		/// <summary>State</summary>
		internal enum ColorType
		{
			/// <summary>Segment ON</summary>
			ON = 0,
			/// <summary>Segment OFF</summary>
			OFF = 1,
			/// <summary>Ground</summary>
			Ground = 2
		}
		private static readonly Dictionary<TemplateName, Int32[][]> TemplateValue = new Dictionary<TemplateName, Int32[][]>
		{
			{ TemplateName.Black, new Int32[][] { new Int32[] { 9,9,9 }, new Int32[] { 200, 200, 200 }, new Int32[] { 226, 226, 226 } } },
			{ TemplateName.White, new Int32[][] { new Int32[] { 255, 255, 255 }, new Int32[] { 59, 59, 59 }, new Int32[] { 30, 30, 30 } } },
			{ TemplateName.Red, new Int32[][] { new Int32[] { 225, 44, 15 }, new Int32[] { 99, 55, 5 }, new Int32[] { 36, 30, 30 } } },
			{ TemplateName.Green, new Int32[][] { new Int32[] { 36, 221, 34 }, new Int32[] { 27, 65, 5 }, new Int32[] { 36, 30, 30 } } },
			{ TemplateName.Orange, new Int32[][] { new Int32[] { 233, 93, 15 }, new Int32[] { 75, 30, 5 }, new Int32[] {36, 30, 30 } } }
		};		
		private static Color RGB (Int32[] V) => Color.FromArgb(V[0], V[1], V[2]);
		internal static Color Value (TemplateName Name, ColorType State) => RGB(TemplateValue[Name][(Int32)State]);
		internal static Dictionary<ColorType, Color> GetColors (TemplateName Name) => new Dictionary<ColorType, Color>
		{ { ColorType.ON, Value(Name, ColorType.ON) }, { ColorType.ON, Value(Name, ColorType.ON) }, { ColorType.ON, Value(Name, ColorType.ON) } };////////////
	}
}
