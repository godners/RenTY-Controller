// Ignore Spelling: RTYC

using System;
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
		private static Color RGB (Int32 R, Int32 G, Int32 B) => Color.FromArgb(R, G, B);
		/// <summary>Segment ON Color</summary><param name="Name"></param><returns></returns>
		public static Color TemplateOn (TemplateName Name)
		{
			switch (Name)
			{
				case TemplateName.Black: return RGB(9, 9, 9);
				case TemplateName.White: return RGB(255, 255, 255);
				case TemplateName.Red: return RGB(255, 44, 15);
				case TemplateName.Green: return RGB(36, 221, 34);
				case TemplateName.Orange: return RGB(233, 93, 15);
				default: return Color.Empty;
			}
		}
		/// <summary>Segment OFF Color</summary><param name="Name"></param><returns></returns>
		public static Color TemplateOff (TemplateName Name)
		{
			switch (Name)
			{
				case TemplateName.Black: return RGB(200, 200, 200);
				case TemplateName.White: return RGB(59, 59, 59);
				case TemplateName.Red: return RGB(99, 55, 5);
				case TemplateName.Green: return RGB(27, 65, 5);
				case TemplateName.Orange: return RGB(75, 30, 5);
				default: return Color.Empty;
			}
		}
		/// <summary>Ground Color</summary><param name="Name"></param><returns></returns>
		public static Color TemplateGround (TemplateName Name)
		{
			switch (Name)
			{
				case TemplateName.Black: return RGB(226, 226, 226);
				case TemplateName.White: return RGB(36, 30, 30);
				case TemplateName.Red: return RGB(36, 30, 30);
				case TemplateName.Green: return RGB(36, 30, 30);
				case TemplateName.Orange: return RGB(36, 30, 30);
				default: return Color.Empty;
			}
		}
	}
}
