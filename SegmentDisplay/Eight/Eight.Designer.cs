// Ignore Spelling: RTYC

using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace RTYC.SegmentDisplay
{
	/// <summary>Define Control</summary>
	public partial class Eight
	{
		private IContainer C = null;
		/// <summary></summary><param name="D"></param>
		protected override void Dispose (Boolean D) { if (D && (C != null)) C.Dispose(); base.Dispose(D); }
		private void InitializeComponent ()
		{
			SuspendLayout();
			AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable;
			CausesValidation = false; Font = LockedFont; ImeMode = ImeMode.Disable; Padding = LockedPadding; Name = "Eight"; Size = new Size(150, 200);
			AutoSizeChanged += EH_Locked; AutoValidateChanged += EH_Locked; CausesValidationChanged += EH_Locked; CursorChanged += EH_Locked;
			FontChanged += EH_Locked; RightToLeftChanged += EH_Locked; PaddingChanged += EH_Locked; ImeModeChanged += EH_Locked;
			BackColorChanged += EH_ReDraw; EnabledChanged += EH_ReDraw; ForeColorChanged += EH_ReDraw; LocationChanged += EH_ReDraw;
			SystemColorsChanged += EH_ReDraw; Move += EH_ReDraw; SizeChanged += EH_ReSize; Resize += EH_ReSize;
			Paint += new PaintEventHandler(Eight_Paint); Layout += new LayoutEventHandler(Eight_Layout); Load += new EventHandler(Eight_Load);
			ResumeLayout(false);
		}
		private EventHandler EH_Locked => new EventHandler(Eight_LockedParameters);
		private EventHandler EH_ReDraw => new EventHandler(Eight_ReDraw);
		private EventHandler EH_ReSize => new EventHandler(Eight_Resize);
		private readonly Font LockedFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		private readonly Padding LockedPadding = new Padding(0);
	}
}
