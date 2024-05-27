// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Math;
using static RTYC.SegmentDisplay.ColorTemplate;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.Clock
{

	public partial class FourTimeSegment : UserControl
	{
		/// <summary>Initialize Component</summary>
		public FourTimeSegment () => InitializeComponent();
		private DateTime TimeValue = DateTime.MinValue;
		/// <summary>Time Value</summary>
		public DateTime Time { get => TimeValue; set { TimeValue = value; DrawAll(); } }
		private Boolean ColonValue = true;
		/// <summary>Colon State: True = ON, False = OFF</summary>
		public Boolean ColonState { get => ColonValue; set { ColonValue = value; DrawAll(); } }
		private readonly Dictionary<Int32, WordStyle> NM = new Dictionary<Int32, WordStyle>
		{
			{ 0, WordStyle.Digit0 }, { 1, WordStyle.Digit1 }, { 2, WordStyle.Digit2 }, { 3, WordStyle.Digit3 }, { 4, WordStyle.Digit4 },
			{ 5, WordStyle.Digit5 }, { 6, WordStyle.Digit6 }, { 7, WordStyle.Digit7 }, { 8, WordStyle.Digit8 }, { 9, WordStyle.Digit9 }
		};
		private Int32 DU (Int32 I) => Convert.ToInt32(Floor(I / 10D)); private Int32 DD (Int32 I) => I % 10;
		private Int32 HH => DU(Time.Hour); private Int32 HL => DD(Time.Hour);
		private Int32 MH => DU(Time.Minute); private Int32 ML => DD(Time.Minute);
		private void DrawAll () { SD0.Word = NM[HH]; SD1.Word = NM[HL]; SD2.State = ColonState; SD3.Word = NM[MH]; SD4.Word = NM[ML]; }


		#region Region - Display Control Function
		private void Property ()
		{
			Padding = InitPadding; AutoSize = false; ImeMode = ImeMode.Disable; AutoValidate = AutoValidate.Disable;
			Cursor = DefaultCursor; Font = InitFont; RightToLeft = RightToLeft.No; CausesValidation = false;
		}
		private void Property (Object O, EventArgs E) => Property();
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();
		private const Single Aspect = 2.62F;
		private Single Scope => Height / 250F;
		private Point P (Single X, Single Y) => Point.Round(new PointF(X * Scope, Y * Scope));
		private Size S (Single X, Single Y) => new SizeF(X * Scope, Y * Scope).ToSize();
		private void LockAspect ()
		{
			Size = (Width / Height > Aspect ? new SizeF(Height * Aspect, Height) : new SizeF(Width, Width / Aspect)).ToSize();
			SD0.Location = P(25, 25); SD1.Location = P(170, 25); SD2.Location = P(315, 25); SD3.Location = P(365, 25); SD4.Location = P(510, 25);
			SD0.Size = S(120, 200); SD1.Size = S(120, 200); SD2.Size = S(25, 200); SD3.Size = S(120, 200); SD4.Size = S(120, 200); DrawAll();
		}
		private void LockAspect (Object O, EventArgs E) => LockAspect();
		#endregion
		#region Region - Color Control Function
		/// <summary>Set Color as Template</summary><param name="Name"></param>
		public void SetSegmentColor (TemplateName Name) { foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(Name); BackColor = SD2.GroundColor; }
		/// <summary>Set Color as 3 Colors</summary><param name="ON"></param><param name="OFF"></param><param name="Ground"></param>
		public void SetSegmentColor (Color ON, Color OFF, Color Ground) 
		{ foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(ON, OFF, Ground); BackColor = SD2.GroundColor; }
		/// <summary>Set Color as [Red Green Blue] Values</summary>
		/// <param name="ON_R"></param><param name="ON_G"></param><param name="ON_B"></param>
		/// <param name="OFF_R"></param><param name="OFF_G"></param><param name="OFF_B"></param>
		/// <param name="Ground_R"></param><param name="Ground_G"></param><param name="Ground_B"></param>
		public void SetSegmentColor (Int32 ON_R, Int32 ON_G, Int32 ON_B, Int32 OFF_R, Int32 OFF_G, Int32 OFF_B, Int32 Ground_R, Int32 Ground_G, Int32 Ground_B)
		{ foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(ON_R, ON_G, ON_B, OFF_R, OFF_G, OFF_B, Ground_R, Ground_G, Ground_B); BackColor = SD2.GroundColor; }
		private void Control_Load (Object O, EventArgs E) { LockAspect(); DrawAll(); }
		#endregion




	}
}
