// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.ColorTemplate;

namespace RTYC.SegmentDisplay
{
	public abstract partial class SegmentDisplay : UserControl
	{
		#region Region - Display Control Function
		private void Property ()
		{
			Padding = InitPadding; AutoSize = false; ImeMode = ImeMode.Disable; AutoValidate = AutoValidate.Disable;
			Cursor = DefaultCursor; Font = InitFont; RightToLeft = RightToLeft.No; CausesValidation = false;
		}
		private void Property (Object O, EventArgs E) => Property();
		private protected abstract Single Aspect { get; }
		private void LockAspect ()
		{ Size = (Width / Height > Aspect ? new SizeF(Height * Aspect, Height) : new SizeF(Width, Width / Aspect)).ToSize(); DrawAll(); }
		private void LockAspect (Object O, EventArgs E) => LockAspect();
		#endregion
		#region Region - Color Control Function
		/// <summary>Segment ON Color</summary>
		public Color OnColor { get => ForeColor; set { ForeColor = value; DrawAll(); } }
		private Color OffColor_P;
		/// <summary>Segment OFF Color</summary>
		public Color OffColor { get => OffColor_P; set { OffColor_P = value; DrawAll(); } }
		/// <summary>Background Color</summary>
		public Color GroundColor { get => BackColor; set { BackColor = value; DrawAll(); } }
		/// <summary>Set Color as Template</summary><param name="Name"></param>
		public void SetColor (TemplateName Name)
		{ OnColor = Value(Name, ColorType.ON); OffColor = Value(Name, ColorType.OFF); GroundColor = Value(Name, ColorType.Ground); DrawAll(); }
		/// <summary>Set Color as 3 Colors</summary><param name="ON"></param><param name="OFF"></param><param name="Ground"></param>
		public void SetColor (Color ON, Color OFF, Color Ground) { OnColor = ON; OffColor = OFF; GroundColor = Ground; DrawAll(); }
		private Color RGB (Int32 R, Int32 G, Int32 B) => Color.FromArgb(R, G, B);
		/// <summary>Set Color as [Red Green Blue] Values</summary>
		/// <param name="ON_R"></param><param name="ON_G"></param><param name="ON_B"></param>
		/// <param name="OFF_R"></param><param name="OFF_G"></param><param name="OFF_B"></param>
		/// <param name="Ground_R"></param><param name="Ground_G"></param><param name="Ground_B"></param>
		public void SetColor (Int32 ON_R, Int32 ON_G, Int32 ON_B, Int32 OFF_R, Int32 OFF_G, Int32 OFF_B, Int32 Ground_R, Int32 Ground_G, Int32 Ground_B)
		{ OnColor = RGB(ON_R, ON_G, ON_B); OffColor = RGB(OFF_R, OFF_G, OFF_B); GroundColor = RGB(Ground_R, Ground_G, Ground_B); DrawAll(); }
		#endregion
	}
}
