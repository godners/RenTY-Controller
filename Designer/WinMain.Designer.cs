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
			this.components = new System.ComponentModel.Container();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.eight1 = new RTYC.SegmentDisplay.Eight();
			this.seven1 = new RTYC.SegmentDisplay.Seven();
			this.nine1 = new RTYC.SegmentDisplay.Nine();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(44, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Next Seven";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(262, 325);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Next Eight";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// eight1
			// 
			this.eight1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.eight1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.eight1.BackColor = System.Drawing.SystemColors.Control;
			this.eight1.CausesValidation = false;
			this.eight1.DotON = false;
			this.eight1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eight1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.eight1.GroundColor = System.Drawing.SystemColors.Control;
			this.eight1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.eight1.Location = new System.Drawing.Point(226, 49);
			this.eight1.Margin = new System.Windows.Forms.Padding(0);
			this.eight1.Name = "eight1";
			this.eight1.OffColor = System.Drawing.SystemColors.Control;
			this.eight1.OnColor = System.Drawing.SystemColors.ControlText;
			this.eight1.Size = new System.Drawing.Size(150, 200);
			this.eight1.TabIndex = 2;
			this.eight1.Word = ' ';
			// 
			// seven1
			// 
			this.seven1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.seven1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.seven1.BackColor = System.Drawing.SystemColors.Control;
			this.seven1.CausesValidation = false;
			this.seven1.Cursor = System.Windows.Forms.Cursors.Default;
			this.seven1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seven1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.seven1.GroundColor = System.Drawing.SystemColors.Control;
			this.seven1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.seven1.Location = new System.Drawing.Point(21, 49);
			this.seven1.Margin = new System.Windows.Forms.Padding(0);
			this.seven1.Name = "seven1";
			this.seven1.OffColor = System.Drawing.Color.Empty;
			this.seven1.OnColor = System.Drawing.SystemColors.ControlText;
			this.seven1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.seven1.Size = new System.Drawing.Size(120, 200);
			this.seven1.TabIndex = 0;
			this.seven1.Word = ' ';
			// 
			// nine1
			// 
			this.nine1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nine1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.nine1.BackColor = System.Drawing.SystemColors.Control;
			this.nine1.CausesValidation = false;
			this.nine1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nine1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.nine1.GroundColor = System.Drawing.SystemColors.Control;
			this.nine1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nine1.Location = new System.Drawing.Point(434, 49);
			this.nine1.Margin = new System.Windows.Forms.Padding(0);
			this.nine1.Name = "nine1";
			this.nine1.OffColor = System.Drawing.Color.Empty;
			this.nine1.OnColor = System.Drawing.SystemColors.ControlText;
			this.nine1.Size = new System.Drawing.Size(120, 200);
			this.nine1.TabIndex = 4;
			this.nine1.Word = ' ';
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(493, 325);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Next Nine";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(44, 385);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Auto Digit";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 300;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 307);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(260, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(491, 307);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "label3";
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.nine1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.eight1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.seven1);
			this.Name = "WinMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.WinMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RTYC.SegmentDisplay.Seven seven1;
		private Button button1;
		private SegmentDisplay.Eight eight1;
		private Button button2;
		private SegmentDisplay.Nine nine1;
		private Button button3;
		private Button button4;
		private Timer timer1;
		private IContainer components;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}

