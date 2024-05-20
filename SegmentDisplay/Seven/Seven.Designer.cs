// Ignore Spelling: RTYC

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace RTYC.SegmentDisplay
{
	/// <summary>Define Control</summary>
	public partial class Seven
	{
		private IContainer C = null;
		/// <summary></summary><param name="D"></param>
		protected override void Dispose (Boolean D) { if (D && (C != null)) C.Dispose(); base.Dispose(D); }
		private void InitializeComponent ()
		{
			SuspendLayout();
			AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable;
			CausesValidation = false; Font = LockedFont; ImeMode = ImeMode.Disable; Padding = LockedPadding; Name = "Seven"; Size = new Size(120, 200);
			AutoSizeChanged += EH_Locked; AutoValidateChanged += EH_Locked; CausesValidationChanged += EH_Locked; CursorChanged += EH_Locked;
			FontChanged += EH_Locked; RightToLeftChanged += EH_Locked; PaddingChanged += EH_Locked; ImeModeChanged += EH_Locked;
			BackColorChanged += EH_ReDraw; EnabledChanged += EH_ReDraw; ForeColorChanged += EH_ReDraw; LocationChanged += EH_ReDraw;
			VisibleChanged += EH_ReDraw; SystemColorsChanged += EH_ReDraw; Move += EH_ReDraw; SizeChanged += EH_ReSize; Resize += EH_ReSize;
			Paint += new PaintEventHandler(Seven_Paint); Layout += new LayoutEventHandler(Seven_Layout); Load += new EventHandler(Seven_Load);
			ResumeLayout(false);
		}
		private EventHandler EH_Locked => new EventHandler(Seven_LockedParameters);
		private EventHandler EH_ReDraw => new EventHandler(Seven_ReDraw);
		private EventHandler EH_ReSize => new EventHandler(Seven_Resize);
		private readonly Font LockedFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		private readonly Padding LockedPadding = new Padding(0);
	}
}
