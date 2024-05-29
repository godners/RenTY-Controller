// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.ColorTemplate;

namespace RTYC.Clock
{
	public abstract partial class Segment : UserControl
	{
		#region Region - Display Control Function
		private void Property ()
		{
			Padding = InitPadding; AutoSize = false; ImeMode = ImeMode.Disable; AutoValidate = AutoValidate.Disable;
			Cursor = DefaultCursor; Font = InitFont; RightToLeft = RightToLeft.No; CausesValidation = false;
		}
		private protected abstract Single Aspect { get; }
		private Single Scope => Height / 250F;
		private protected Point P (Single X, Single Y) => Point.Round(new PointF(X * Scope, Y * Scope));
		private protected Size S (Single X, Single Y) => new SizeF(X * Scope, Y * Scope).ToSize();
		private SizeF ControlSize (Boolean WH) => WH ? new SizeF(Height * Aspect, Height) : new SizeF(Width, Width / Aspect);
		private void LockAspectBegin () => Size = ControlSize(Width / Height > Aspect).ToSize();
		private protected abstract void DrawAll ();
		private protected abstract void LockAspectWork ();
		private void LockAspectEnd () => DrawAll();
		private void LockAspect () { LockAspectBegin(); LockAspectWork(); LockAspectEnd(); }
		#endregion
		#region Region - Color Control Function
		private protected abstract void ColorS2C ();
		/// <summary>Set Color as Template</summary><param name="Name"></param>
		public void SetSegmentColor (TemplateName Name) { foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(Name); ColorS2C(); }
		/// <summary>Set Color as 3 Colors</summary><param name="ON"></param><param name="OFF"></param><param name="Ground"></param>
		public void SetSegmentColor (Color ON, Color OFF, Color Ground)
		{ foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(ON, OFF, Ground); ColorS2C(); }
		/// <summary>Set Color as [Red Green Blue] Values</summary>
		/// <param name="ON_R"></param><param name="ON_G"></param><param name="ON_B"></param>
		/// <param name="OFF_R"></param><param name="OFF_G"></param><param name="OFF_B"></param>
		/// <param name="Ground_R"></param><param name="Ground_G"></param><param name="Ground_B"></param>
		public void SetSegmentColor (Int32 ON_R, Int32 ON_G, Int32 ON_B, Int32 OFF_R, Int32 OFF_G, Int32 OFF_B, Int32 Ground_R, Int32 Ground_G, Int32 Ground_B)
		{ foreach (SegmentDisplay.SegmentDisplay V in SDS) V.SetColor(ON_R, ON_G, ON_B, OFF_R, OFF_G, OFF_B, Ground_R, Ground_G, Ground_B); ColorS2C(); }
		private void Control_Load () { LockAspect(); DrawAll(); }
		#endregion
	}
}
