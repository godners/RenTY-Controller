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
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.eight1 = new RTYC.SegmentDisplay.Eight();
			this.seven1 = new RTYC.SegmentDisplay.Seven();
			this.fourteen1 = new RTYC.SegmentDisplay.Fourteen();
			this.nine1 = new RTYC.SegmentDisplay.Nine();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Next Seven";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(145, 264);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Next Eight";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(295, 264);
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
			this.label1.Location = new System.Drawing.Point(23, 249);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(143, 249);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(293, 249);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "label3";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(420, 264);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 11;
			this.button5.Text = "Next 14";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(418, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "label4";
			// 
			// eight1
			// 
			this.eight1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.eight1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.eight1.BackColor = System.Drawing.SystemColors.Control;
			this.eight1.CausesValidation = false;
			this.eight1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.eight1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eight1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.eight1.GroundColor = System.Drawing.SystemColors.Control;
			this.eight1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.eight1.Location = new System.Drawing.Point(145, 49);
			this.eight1.Margin = new System.Windows.Forms.Padding(0);
			this.eight1.Name = "eight1";
			this.eight1.OffColor = System.Drawing.SystemColors.Control;
			this.eight1.OnColor = System.Drawing.SystemColors.ControlText;
			this.eight1.Size = new System.Drawing.Size(150, 200);
			this.eight1.TabIndex = 14;
			this.eight1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// seven1
			// 
			this.seven1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.seven1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.seven1.BackColor = System.Drawing.SystemColors.Control;
			this.seven1.CausesValidation = false;
			this.seven1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.seven1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seven1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.seven1.GroundColor = System.Drawing.SystemColors.Control;
			this.seven1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.seven1.Location = new System.Drawing.Point(25, 49);
			this.seven1.Margin = new System.Windows.Forms.Padding(0);
			this.seven1.Name = "seven1";
			this.seven1.OffColor = System.Drawing.SystemColors.Control;
			this.seven1.OnColor = System.Drawing.SystemColors.ControlText;
			this.seven1.Size = new System.Drawing.Size(120, 200);
			this.seven1.TabIndex = 13;
			this.seven1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// fourteen1
			// 
			this.fourteen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.fourteen1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.fourteen1.BackColor = System.Drawing.SystemColors.Control;
			this.fourteen1.CausesValidation = false;
			this.fourteen1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.fourteen1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fourteen1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.fourteen1.GroundColor = System.Drawing.SystemColors.Control;
			this.fourteen1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.fourteen1.Location = new System.Drawing.Point(415, 49);
			this.fourteen1.Margin = new System.Windows.Forms.Padding(0);
			this.fourteen1.Name = "fourteen1";
			this.fourteen1.OffColor = System.Drawing.SystemColors.Control;
			this.fourteen1.OnColor = System.Drawing.SystemColors.ControlText;
			this.fourteen1.Size = new System.Drawing.Size(150, 200);
			this.fourteen1.TabIndex = 10;
			this.fourteen1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// nine1
			// 
			this.nine1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nine1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.nine1.CausesValidation = false;
			this.nine1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.nine1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nine1.GroundColor = System.Drawing.SystemColors.Control;
			this.nine1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.nine1.Location = new System.Drawing.Point(295, 49);
			this.nine1.Margin = new System.Windows.Forms.Padding(0);
			this.nine1.Name = "nine1";
			this.nine1.OffColor = System.Drawing.SystemColors.Control;
			this.nine1.OnColor = System.Drawing.SystemColors.ControlText;
			this.nine1.Size = new System.Drawing.Size(120, 200);
			this.nine1.TabIndex = 15;
			this.nine1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.nine1);
			this.Controls.Add(this.eight1);
			this.Controls.Add(this.seven1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.fourteen1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "WinMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.WinMain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Timer timer1;
		private IContainer components;
		private Label label1;
		private Label label2;
		private Label label3;
		private SegmentDisplay.Fourteen fourteen1;
		private Button button5;
		private Label label4;
		private SegmentDisplay.Seven seven1;
		private SegmentDisplay.Eight eight1;
		private SegmentDisplay.Nine nine1;
	}
}

