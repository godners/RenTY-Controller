// Ignore Spelling: RTYC

using System;
using System.Windows.Forms;
using System.Drawing;

namespace RTYC.MatrixDisplay
{

	/// <summary>Matrix Display</summary>
	public abstract partial class MatrixDisplay
	{
		#region Region - Initialize Value
		private protected virtual Size InitSize => new Size(160, 160);
		private Padding InitPadding = new Padding(0);
		private Font InitFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		#endregion
		#region Region - Initialize Function
		private void LockedProperty ()
		{
			Padding = InitPadding; AutoSize = false; ImeMode = ImeMode.Disable; AutoValidate = AutoValidate.Disable;
			Cursor = DefaultCursor; Font = InitFont; RightToLeft = RightToLeft.No; CausesValidation = false;
		}
		private void AssignControl () { LockedProperty(); Margin = InitPadding; Name = "MatrixDisplay"; Size = InitSize; }
		private void AddEvent ()
		{
			AutoSizeChanged += EHPT; AutoValidateChanged += EHPT; CausesValidationChanged += EHPT; CursorChanged += EHPT;
			FontChanged += EHPT; RightToLeftChanged += EHPT; PaddingChanged += EHPT; ImeModeChanged += EHPT; ForeColorChanged += EHPT;
			LocationChanged += EHDA; Move += EHDA; SizeChanged += EHDA; VisibleChanged += EHDA; SystemColorsChanged += EHDA;
			BackColorChanged += EHDA; EnabledChanged += EHDA; Load += EHDA; Paint += new PaintEventHandler(DrawAll);
			Layout += new LayoutEventHandler(DrawAll); Resize += EHDA;
		}
		/// <summary>Initialize Component</summary>
		private MatrixDisplay () { SuspendLayout(); AssignControl(); AddEvent(); ResumeLayout(false); }
		#endregion
		#region Region  - Event Function
		private EventHandler EHPT => new EventHandler(Property);
		private EventHandler EHDA => new EventHandler(DrawAll);
		private void Property (Object O, EventArgs E) => LockedProperty();
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();
		#endregion
	}
}
