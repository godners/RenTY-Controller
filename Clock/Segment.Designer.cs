// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;

namespace RTYC.Clock
{
	/// <summary>Define Control</summary>
	public abstract partial class Segment : UserControl
	{
		#region Region - Initialize Value
		private protected abstract Size ControlInitSize { get; }
		private protected Size SevenInitSize = new Size(120, 200), ColonInitSize = new Size(25, 200);
		private protected Padding InitPadding = new Padding(0);
		private Font InitFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		#endregion
		#region Region - Initialize Function
		private protected abstract void AssignSegments ();
		private void AssignControl ()
		{
			AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable; Font = InitFont;
			CausesValidation = false; ImeMode = ImeMode.Disable; Margin = InitPadding; Name = "Segment"; Size = ControlInitSize;
		}
		private protected abstract void AddSegments ();
		private protected abstract void InitControls ();
		private void AddEvent ()
		{
			AutoSizeChanged += EHPT; AutoValidateChanged += EHPT; CausesValidationChanged += EHPT; CursorChanged += EHPT;
			FontChanged += EHPT; RightToLeftChanged += EHPT; PaddingChanged += EHPT; ImeModeChanged += EHPT; ForeColorChanged += EHDA;
			LocationChanged += EHDA; Move += EHDA; SizeChanged += EHDA; VisibleChanged += EHDA; SystemColorsChanged += EHDA;
			BackColorChanged += EHDA; EnabledChanged += EHDA; Load += new EventHandler(Control_Load); Paint += new PaintEventHandler(DrawAll);
			Layout += new LayoutEventHandler(DrawAll); Resize += new EventHandler(LockAspect);
		}
		/// <summary>Initialize Component</summary>
		public Segment () { InitControls(); SuspendLayout(); AssignSegments(); AssignControl(); AddSegments(); AddEvent(); ResumeLayout(false); }
		#endregion
		#region Region - Designer Event Function
		private EventHandler EHPT => new EventHandler(Property);
		private EventHandler EHDA => new EventHandler(DrawAll);
		private void Property (Object O, EventArgs E) => Property();
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();
		private void LockAspect (Object O, EventArgs E) => LockAspect();
		private void Control_Load (Object O, EventArgs E) => Control_Load();
		private protected abstract SegmentDisplay.SegmentDisplay[] SDS { get; }
		#endregion
	}
}
