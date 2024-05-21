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
			this.SuspendLayout();
			// 
			// SegmentDisplay
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.CausesValidation = false;
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "SegmentDisplay";
			this.Size = new System.Drawing.Size(120, 200);
			this.AutoSizeChanged += new System.EventHandler(this.Property);
			this.AutoValidateChanged += new System.EventHandler(this.Property);
			this.Load += new System.EventHandler(this.SegmentDisplay_Load);
			this.BackColorChanged += new System.EventHandler(this.DrawAll);
			this.CausesValidationChanged += new System.EventHandler(this.Property);
			this.CursorChanged += new System.EventHandler(this.Property);
			this.EnabledChanged += new System.EventHandler(this.DrawAll);
			this.FontChanged += new System.EventHandler(this.Property);
			this.ForeColorChanged += new System.EventHandler(this.DrawAll);
			this.LocationChanged += new System.EventHandler(this.DrawAll);
			this.RightToLeftChanged += new System.EventHandler(this.Property);
			this.SizeChanged += new System.EventHandler(this.LockAspect);
			this.VisibleChanged += new System.EventHandler(this.DrawAll);
			this.PaddingChanged += new System.EventHandler(this.Property);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAll);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.DrawAll);
			this.Move += new System.EventHandler(this.DrawAll);
			this.Resize += new System.EventHandler(this.LockAspect);
			this.SystemColorsChanged += new System.EventHandler(this.DrawAll);
			this.ImeModeChanged += new System.EventHandler(this.Property);
			this.ResumeLayout(false);

		}


	}
}
