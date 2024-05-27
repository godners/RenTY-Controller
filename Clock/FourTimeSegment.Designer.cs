// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using RTYC.SegmentDisplay;

namespace RTYC.Clock
{
	/// <summary>Clock - Four Segment to Show Hour and Minute</summary>
	public partial class FourTimeSegment : UserControl
	{
		private IContainer C = null;
		/// <summary></summary><param name="D"></param>
		protected override void Dispose (Boolean D) { if (D && (C != null)) C.Dispose(); base.Dispose(D); }
		private Padding InitPadding = new Padding(0); private Size SegmentInitSize = new Size(120, 200), ControlInitSize = new Size(655, 250);
		private Font InitFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		private SegmentDisplay.SegmentDisplay[] SDS => new SegmentDisplay.SegmentDisplay[] { SD0, SD1, SD2, SD3, SD4 };
		
		private void AssingSegments ()
		{
			SD0.Name = "SD0"; SD0.Location = P(25, 25); SD0.TabIndex = 0; SD0.Margin = InitPadding; SD0.TabStop = false; SD0.Size = SegmentInitSize;
			SD1.Name = "SD1"; SD1.Location = P(170, 25); SD1.TabIndex = 1; SD1.Margin = InitPadding; SD1.TabStop = false; SD1.Size = SegmentInitSize;
			SD2.Name = "SD2"; SD2.Location = P(315, 25); SD2.TabIndex = 2; SD2.Margin = InitPadding; SD2.TabStop = false; SD2.Size = SegmentInitSize;
			SD3.Name = "SD3"; SD3.Location = P(365, 25); SD3.TabIndex = 3; SD3.Margin = InitPadding; SD3.TabStop = false; SD3.Size = SegmentInitSize;
			SD4.Name = "SD4"; SD4.Location = P(510, 25); SD4.TabIndex = 4; SD4.Margin = InitPadding; SD4.TabStop = false; SD4.Size = SegmentInitSize;
		}
		private void AssignControl ()
		{
			AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable;
			CausesValidation = false; foreach (SegmentDisplay.SegmentDisplay V in SDS) Controls.Add(V); Font = InitFont; 
			ImeMode = ImeMode.Disable; Margin = InitPadding; Name = "FourTimeSegment"; Size = ControlInitSize;
		}		
		private void InitControls () { SD1 = new Seven(); SD0 = new Seven(); SD2 = new Colon(); SD3 = new Seven(); SD4 = new Seven(); }
		private void AddEvent ()
		{
			AutoSizeChanged += EHPT; AutoValidateChanged += EHPT; CausesValidationChanged += EHPT; CursorChanged += EHPT;
			FontChanged += EHPT; RightToLeftChanged += EHPT; PaddingChanged += EHPT; ImeModeChanged += EHPT; ForeColorChanged += EHDA;
			LocationChanged += EHDA; Move += EHDA; SizeChanged += EHDA; VisibleChanged += EHDA; SystemColorsChanged += EHDA;
			BackColorChanged += EHDA; EnabledChanged += EHDA; Load += new EventHandler(Control_Load); Paint += new PaintEventHandler(DrawAll);
			Layout += new LayoutEventHandler(DrawAll); Resize += new EventHandler(LockAspect);
		}
		private void InitializeComponent () { InitControls(); SuspendLayout(); AssingSegments(); AssignControl(); AddEvent(); ResumeLayout(false); }
		private EventHandler EHPT => new EventHandler(Property);
		private EventHandler EHDA => new EventHandler(DrawAll);
		private Seven SD0, SD1, SD3, SD4; private Colon SD2;		
	}
}
