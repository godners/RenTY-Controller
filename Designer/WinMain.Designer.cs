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
			this.T1 = new System.Windows.Forms.Timer(this.components);
			this.L1 = new System.Windows.Forms.Label();
			this.L2 = new System.Windows.Forms.Label();
			this.L3 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.L4 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.L5 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.L6 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.L7 = new System.Windows.Forms.Label();
			this.T2 = new System.Windows.Forms.Timer(this.components);
			this.button9 = new System.Windows.Forms.Button();
			this.L8 = new System.Windows.Forms.Label();
			this.T3 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.L9 = new System.Windows.Forms.Label();
			this.CL1 = new RTYC.SegmentDisplay.Colon();
			this.NN1 = new RTYC.SegmentDisplay.Nine();
			this.EG1 = new RTYC.SegmentDisplay.Eight();
			this.SV1 = new RTYC.SegmentDisplay.Seven();
			this.FT1 = new RTYC.SegmentDisplay.Fourteen();
			this.ST1 = new RTYC.SegmentDisplay.Sixteen();
			this.T4 = new System.Windows.Forms.Timer(this.components);
			this.DL1 = new RTYC.Clock.Dial();
			this.HMS1 = new RTYC.Clock.HourMinuteSecond();
			this.MS1 = new RTYC.Clock.MinuteSecond();
			this.HM1 = new RTYC.Clock.HourMinute();
			this.asC161 = new RTYC.MatrixDisplay.ASC16TEST();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.Location = new System.Drawing.Point(25, 252);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(21, 22);
			this.button1.TabIndex = 1;
			this.button1.Text = "7";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.B1);
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button2.Location = new System.Drawing.Point(145, 252);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(21, 22);
			this.button2.TabIndex = 3;
			this.button2.Text = "8";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.B2);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button3.Location = new System.Drawing.Point(295, 252);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(21, 22);
			this.button3.TabIndex = 5;
			this.button3.Text = "9";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.B3);
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button4.Location = new System.Drawing.Point(745, 252);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(21, 22);
			this.button4.TabIndex = 6;
			this.button4.Text = ":";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.B4);
			// 
			// T1
			// 
			this.T1.Interval = 1000;
			this.T1.Tick += new System.EventHandler(this.TM1);
			// 
			// L1
			// 
			this.L1.AutoSize = true;
			this.L1.Location = new System.Drawing.Point(52, 257);
			this.L1.Name = "L1";
			this.L1.Size = new System.Drawing.Size(41, 12);
			this.L1.TabIndex = 7;
			this.L1.Text = "label1";
			// 
			// L2
			// 
			this.L2.AutoSize = true;
			this.L2.Location = new System.Drawing.Point(172, 257);
			this.L2.Name = "L2";
			this.L2.Size = new System.Drawing.Size(41, 12);
			this.L2.TabIndex = 8;
			this.L2.Text = "label2";
			// 
			// L3
			// 
			this.L3.AutoSize = true;
			this.L3.Location = new System.Drawing.Point(322, 257);
			this.L3.Name = "L3";
			this.L3.Size = new System.Drawing.Size(41, 12);
			this.L3.TabIndex = 9;
			this.L3.Text = "label3";
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button5.Location = new System.Drawing.Point(415, 252);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(27, 22);
			this.button5.TabIndex = 11;
			this.button5.Text = "14";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.B5);
			// 
			// L4
			// 
			this.L4.AutoSize = true;
			this.L4.Location = new System.Drawing.Point(448, 257);
			this.L4.Name = "L4";
			this.L4.Size = new System.Drawing.Size(41, 12);
			this.L4.TabIndex = 12;
			this.L4.Text = "label4";
			// 
			// button6
			// 
			this.button6.AutoSize = true;
			this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button6.Location = new System.Drawing.Point(565, 252);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(27, 22);
			this.button6.TabIndex = 16;
			this.button6.Text = "16";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.B6);
			// 
			// L5
			// 
			this.L5.AutoSize = true;
			this.L5.Location = new System.Drawing.Point(598, 257);
			this.L5.Name = "L5";
			this.L5.Size = new System.Drawing.Size(41, 12);
			this.L5.TabIndex = 17;
			this.L5.Text = "label5";
			// 
			// button7
			// 
			this.button7.AutoSize = true;
			this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button7.Location = new System.Drawing.Point(25, 380);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(27, 22);
			this.button7.TabIndex = 20;
			this.button7.Text = "HM";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.B7);
			// 
			// L6
			// 
			this.L6.AutoSize = true;
			this.L6.Location = new System.Drawing.Point(58, 385);
			this.L6.Name = "L6";
			this.L6.Size = new System.Drawing.Size(41, 12);
			this.L6.TabIndex = 22;
			this.L6.Text = "label6";
			// 
			// button8
			// 
			this.button8.AutoSize = true;
			this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button8.Location = new System.Drawing.Point(295, 380);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(27, 22);
			this.button8.TabIndex = 25;
			this.button8.Text = "MS";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.B8);
			// 
			// L7
			// 
			this.L7.AutoSize = true;
			this.L7.Location = new System.Drawing.Point(328, 385);
			this.L7.Name = "L7";
			this.L7.Size = new System.Drawing.Size(41, 12);
			this.L7.TabIndex = 26;
			this.L7.Text = "label7";
			// 
			// T2
			// 
			this.T2.Interval = 1000;
			this.T2.Tick += new System.EventHandler(this.TM2);
			// 
			// button9
			// 
			this.button9.AutoSize = true;
			this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button9.Location = new System.Drawing.Point(549, 380);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(33, 22);
			this.button9.TabIndex = 28;
			this.button9.Text = "HMS";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.B9);
			// 
			// L8
			// 
			this.L8.AutoSize = true;
			this.L8.Location = new System.Drawing.Point(588, 385);
			this.L8.Name = "L8";
			this.L8.Size = new System.Drawing.Size(41, 12);
			this.L8.TabIndex = 29;
			this.L8.Text = "label8";
			// 
			// T3
			// 
			this.T3.Interval = 1000;
			this.T3.Tick += new System.EventHandler(this.TM3);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// button10
			// 
			this.button10.AutoSize = true;
			this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button10.Location = new System.Drawing.Point(24, 664);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(39, 22);
			this.button10.TabIndex = 31;
			this.button10.Text = "Dial";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.B10);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Red;
			this.button11.Location = new System.Drawing.Point(429, 449);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(90, 91);
			this.button11.TabIndex = 32;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.B11);
			// 
			// L9
			// 
			this.L9.AutoSize = true;
			this.L9.Location = new System.Drawing.Point(69, 669);
			this.L9.Name = "L9";
			this.L9.Size = new System.Drawing.Size(41, 12);
			this.L9.TabIndex = 33;
			this.L9.Text = "label9";
			// 
			// CL1
			// 
			this.CL1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.CL1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.CL1.BackColor = System.Drawing.SystemColors.Control;
			this.CL1.CausesValidation = false;
			this.CL1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.CL1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CL1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CL1.GroundColor = System.Drawing.SystemColors.Control;
			this.CL1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.CL1.Location = new System.Drawing.Point(745, 49);
			this.CL1.Margin = new System.Windows.Forms.Padding(0);
			this.CL1.Name = "CL1";
			this.CL1.OffColor = System.Drawing.SystemColors.Control;
			this.CL1.OnColor = System.Drawing.SystemColors.ControlText;
			this.CL1.Size = new System.Drawing.Size(25, 200);
			this.CL1.State = false;
			this.CL1.TabIndex = 18;
			this.CL1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// NN1
			// 
			this.NN1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.NN1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.NN1.BackColor = System.Drawing.SystemColors.Control;
			this.NN1.CausesValidation = false;
			this.NN1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.NN1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NN1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.NN1.GroundColor = System.Drawing.SystemColors.Control;
			this.NN1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.NN1.Location = new System.Drawing.Point(295, 49);
			this.NN1.Margin = new System.Windows.Forms.Padding(0);
			this.NN1.Name = "NN1";
			this.NN1.OffColor = System.Drawing.SystemColors.Control;
			this.NN1.OnColor = System.Drawing.SystemColors.ControlText;
			this.NN1.Size = new System.Drawing.Size(120, 200);
			this.NN1.TabIndex = 15;
			this.NN1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// EG1
			// 
			this.EG1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.EG1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.EG1.BackColor = System.Drawing.SystemColors.Control;
			this.EG1.CausesValidation = false;
			this.EG1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.EG1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EG1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.EG1.GroundColor = System.Drawing.SystemColors.Control;
			this.EG1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.EG1.Location = new System.Drawing.Point(145, 49);
			this.EG1.Margin = new System.Windows.Forms.Padding(0);
			this.EG1.Name = "EG1";
			this.EG1.OffColor = System.Drawing.SystemColors.Control;
			this.EG1.OnColor = System.Drawing.SystemColors.ControlText;
			this.EG1.Size = new System.Drawing.Size(150, 200);
			this.EG1.TabIndex = 14;
			this.EG1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// SV1
			// 
			this.SV1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SV1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.SV1.BackColor = System.Drawing.SystemColors.Control;
			this.SV1.CausesValidation = false;
			this.SV1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.SV1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SV1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.SV1.GroundColor = System.Drawing.SystemColors.Control;
			this.SV1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.SV1.Location = new System.Drawing.Point(25, 49);
			this.SV1.Margin = new System.Windows.Forms.Padding(0);
			this.SV1.Name = "SV1";
			this.SV1.OffColor = System.Drawing.SystemColors.Control;
			this.SV1.OnColor = System.Drawing.SystemColors.ControlText;
			this.SV1.Size = new System.Drawing.Size(120, 200);
			this.SV1.TabIndex = 13;
			this.SV1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// FT1
			// 
			this.FT1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FT1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.FT1.BackColor = System.Drawing.SystemColors.Control;
			this.FT1.CausesValidation = false;
			this.FT1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.FT1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FT1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FT1.GroundColor = System.Drawing.SystemColors.Control;
			this.FT1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.FT1.Location = new System.Drawing.Point(415, 49);
			this.FT1.Margin = new System.Windows.Forms.Padding(0);
			this.FT1.Name = "FT1";
			this.FT1.OffColor = System.Drawing.SystemColors.Control;
			this.FT1.OnColor = System.Drawing.SystemColors.ControlText;
			this.FT1.Size = new System.Drawing.Size(150, 200);
			this.FT1.TabIndex = 10;
			this.FT1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// ST1
			// 
			this.ST1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ST1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.ST1.BackColor = System.Drawing.SystemColors.Control;
			this.ST1.CausesValidation = false;
			this.ST1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.ST1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ST1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ST1.GroundColor = System.Drawing.SystemColors.Control;
			this.ST1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.ST1.Location = new System.Drawing.Point(565, 49);
			this.ST1.Margin = new System.Windows.Forms.Padding(0);
			this.ST1.Name = "ST1";
			this.ST1.OffColor = System.Drawing.SystemColors.Control;
			this.ST1.OnColor = System.Drawing.SystemColors.ControlText;
			this.ST1.Size = new System.Drawing.Size(180, 200);
			this.ST1.TabIndex = 11;
			this.ST1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// T4
			// 
			this.T4.Tick += new System.EventHandler(this.TM4);
			// 
			// DL1
			// 
			this.DL1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.DL1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.DL1.CausesValidation = false;
			this.DL1.DisplaySecond = true;
			this.DL1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DL1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.DL1.Location = new System.Drawing.Point(25, 405);
			this.DL1.Margin = new System.Windows.Forms.Padding(0);
			this.DL1.Name = "DL1";
			this.DL1.Size = new System.Drawing.Size(256, 256);
			this.DL1.TabIndex = 30;
			this.DL1.Value = new System.DateTime(((long)(0)));
			// 
			// HMS1
			// 
			this.HMS1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HMS1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.HMS1.CausesValidation = false;
			this.HMS1.ColonState = true;
			this.HMS1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HMS1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.HMS1.Location = new System.Drawing.Point(549, 277);
			this.HMS1.Margin = new System.Windows.Forms.Padding(0);
			this.HMS1.Name = "HMS1";
			this.HMS1.Size = new System.Drawing.Size(398, 100);
			this.HMS1.TabIndex = 27;
			this.HMS1.Time = new System.DateTime(((long)(0)));
			// 
			// MS1
			// 
			this.MS1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.MS1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.MS1.CausesValidation = false;
			this.MS1.ColonState = true;
			this.MS1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MS1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MS1.Location = new System.Drawing.Point(287, 277);
			this.MS1.Margin = new System.Windows.Forms.Padding(0);
			this.MS1.Name = "MS1";
			this.MS1.Size = new System.Drawing.Size(262, 100);
			this.MS1.TabIndex = 24;
			this.MS1.Time = new System.DateTime(((long)(0)));
			// 
			// HM1
			// 
			this.HM1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.HM1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.HM1.CausesValidation = false;
			this.HM1.ColonState = true;
			this.HM1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HM1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.HM1.Location = new System.Drawing.Point(25, 277);
			this.HM1.Margin = new System.Windows.Forms.Padding(0);
			this.HM1.Name = "HM1";
			this.HM1.Size = new System.Drawing.Size(262, 100);
			this.HM1.TabIndex = 23;
			this.HM1.Time = new System.DateTime(((long)(0)));
			// 
			// asC161
			// 
			this.asC161.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.asC161.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.asC161.CausesValidation = false;
			this.asC161.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.asC161.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.asC161.Location = new System.Drawing.Point(324, 435);
			this.asC161.Margin = new System.Windows.Forms.Padding(0);
			this.asC161.Name = "asC161";
			this.asC161.Size = new System.Drawing.Size(60, 120);
			this.asC161.Style = RTYC.MatrixDisplay.MatrixDisplayStyle.PixelStyle.Rectangle;
			this.asC161.TabIndex = 34;
			this.asC161.Word = " ";
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 850);
			this.Controls.Add(this.asC161);
			this.Controls.Add(this.L9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.DL1);
			this.Controls.Add(this.L8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.HMS1);
			this.Controls.Add(this.L7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.MS1);
			this.Controls.Add(this.HM1);
			this.Controls.Add(this.L6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.CL1);
			this.Controls.Add(this.L5);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.NN1);
			this.Controls.Add(this.EG1);
			this.Controls.Add(this.SV1);
			this.Controls.Add(this.L4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.FT1);
			this.Controls.Add(this.L3);
			this.Controls.Add(this.L2);
			this.Controls.Add(this.L1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ST1);
			this.Controls.Add(this.button11);
			this.Name = "WinMain";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.WinMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Timer T1;
		private IContainer components;
		private Label L1;
		private Label L2;
		private Label L3;
		private SegmentDisplay.Fourteen FT1;
		private Button button5;
		private Label L4;
		private SegmentDisplay.Seven SV1;
		private SegmentDisplay.Eight EG1;
		private SegmentDisplay.Nine NN1;
		private SegmentDisplay.Sixteen ST1;
		private Button button6;
		private Label L5;
		private SegmentDisplay.Colon CL1;
		private Button button7;
		private Label L6;
		private Clock.HourMinute HM1;
		private Clock.MinuteSecond MS1;
		private Button button8;
		private Label L7;
		private Timer T2;
		private Clock.HourMinuteSecond HMS1;
		private Button button9;
		private Label L8;
		private Timer T3;
		private ErrorProvider errorProvider1;
		private Button button10;
		private Clock.Dial DL1;
		private Button button11;
		private Label L9;
		private Timer T4;
		private MatrixDisplay.ASC16TEST asC161;
	}
}

