// Ignore Spelling: RTYC
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace RTYC.Designer
{
	partial class WinMain
	{
		private IContainer C = null;
		/// <summary>清理所有正在使用的资源。</summary>
		/// <param name="D">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose (Boolean D) { if (D && (C != null)) C.Dispose(); base.Dispose(D); }

		#region Windows 窗体设计器生成的代码

		private void InitializeComponent ()
		{
			this.C = new Container();
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(800, 450);
			this.Text = "Form1";
		}

		#endregion
	}
}

