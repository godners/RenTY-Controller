// Ignore Spelling: RTYC

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace RTYC.SegmentDisplay
{
	/// <summary>Define Control</summary>
	public abstract partial class SegmentDisplay : UserControl
	{
		private IContainer C = null;
		/// <summary></summary><param name="D"></param>
		protected override void Dispose (Boolean D) { if (D && (C != null)) C.Dispose(); base.Dispose(D); }
		private void InitializeComponent ()
		{
			SuspendLayout(); AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable;
			CausesValidation = false; Font = InitFont; ImeMode = ImeMode.Disable; Margin = InitPadding; Name = "SegmentDisplay"; Size = new Size(120, 200);
			AutoSizeChanged += EHPT; AutoValidateChanged += EHPT; CausesValidationChanged += EHPT; CursorChanged += EHPT;
			FontChanged += EHPT; ForeColorChanged += EHDA; LocationChanged += EHDA; RightToLeftChanged += EHPT; Move += EHDA; 
			SizeChanged += EHDA; VisibleChanged += EHDA; PaddingChanged += EHPT; SystemColorsChanged += EHDA; ImeModeChanged += EHPT;			
			BackColorChanged += EHDA; EnabledChanged += EHDA; Load += new EventHandler(SegmentDisplay_Load); Paint += new PaintEventHandler(DrawAll);
			Layout += new LayoutEventHandler(DrawAll); Resize += new EventHandler(LockAspect); ResumeLayout(false);
		}
		private EventHandler EHPT => new EventHandler(Property);
		private EventHandler EHDA => new EventHandler(DrawAll);
		private Font InitFont = new Font ("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, (Byte)(0));
		private Padding InitPadding = new Padding(0);
	}
}
