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
			this.button6 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.button7 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.button8 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.button9 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.colon1 = new RTYC.SegmentDisplay.Colon();
			this.nine1 = new RTYC.SegmentDisplay.Nine();
			this.eight1 = new RTYC.SegmentDisplay.Eight();
			this.seven1 = new RTYC.SegmentDisplay.Seven();
			this.fourteen1 = new RTYC.SegmentDisplay.Fourteen();
			this.sixteen1 = new RTYC.SegmentDisplay.Sixteen();
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.dial1 = new RTYC.Clock.Dial();
			this.hourMinuteSecond1 = new RTYC.Clock.HourMinuteSecond();
			this.minuteSecond1 = new RTYC.Clock.MinuteSecond();
			this.hourMinute1 = new RTYC.Clock.HourMinute();
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
			this.button1.Click += new System.EventHandler(this.Button1_Click);
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
			this.button2.Click += new System.EventHandler(this.Button2_Click);
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
			this.button3.Click += new System.EventHandler(this.Button3_Click);
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
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 257);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 7;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(172, 257);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(322, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 9;
			this.label3.Text = "label3";
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
			this.button5.Click += new System.EventHandler(this.Button5_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(448, 257);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 12;
			this.label4.Text = "label4";
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
			this.button6.Click += new System.EventHandler(this.Button6_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(598, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 17;
			this.label5.Text = "label5";
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
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(58, 385);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 12);
			this.label6.TabIndex = 22;
			this.label6.Text = "label6";
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
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(328, 385);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 12);
			this.label7.TabIndex = 26;
			this.label7.Text = "label7";
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
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
			this.button9.Click += new System.EventHandler(this.Button9_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(588, 385);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 12);
			this.label8.TabIndex = 29;
			this.label8.Text = "label8";
			// 
			// timer3
			// 
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.Timer3_Tick);
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
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.Red;
			this.button11.Location = new System.Drawing.Point(904, 432);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(90, 91);
			this.button11.TabIndex = 32;
			this.button11.Text = "button11";
			this.button11.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(69, 669);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 12);
			this.label9.TabIndex = 33;
			this.label9.Text = "label9";
			// 
			// colon1
			// 
			this.colon1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.colon1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.colon1.BackColor = System.Drawing.SystemColors.Control;
			this.colon1.CausesValidation = false;
			this.colon1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.colon1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.colon1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.colon1.GroundColor = System.Drawing.SystemColors.Control;
			this.colon1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.colon1.Location = new System.Drawing.Point(745, 49);
			this.colon1.Margin = new System.Windows.Forms.Padding(0);
			this.colon1.Name = "colon1";
			this.colon1.OffColor = System.Drawing.SystemColors.Control;
			this.colon1.OnColor = System.Drawing.SystemColors.ControlText;
			this.colon1.Size = new System.Drawing.Size(25, 200);
			this.colon1.State = false;
			this.colon1.TabIndex = 18;
			this.colon1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// nine1
			// 
			this.nine1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nine1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.nine1.BackColor = System.Drawing.SystemColors.Control;
			this.nine1.CausesValidation = false;
			this.nine1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.nine1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nine1.ForeColor = System.Drawing.SystemColors.ControlText;
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
			// sixteen1
			// 
			this.sixteen1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.sixteen1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.sixteen1.BackColor = System.Drawing.SystemColors.Control;
			this.sixteen1.CausesValidation = false;
			this.sixteen1.Dot = RTYC.SegmentDisplay.SegmentDisplayStyle.DotStyle.None;
			this.sixteen1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sixteen1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.sixteen1.GroundColor = System.Drawing.SystemColors.Control;
			this.sixteen1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.sixteen1.Location = new System.Drawing.Point(565, 49);
			this.sixteen1.Margin = new System.Windows.Forms.Padding(0);
			this.sixteen1.Name = "sixteen1";
			this.sixteen1.OffColor = System.Drawing.SystemColors.Control;
			this.sixteen1.OnColor = System.Drawing.SystemColors.ControlText;
			this.sixteen1.Size = new System.Drawing.Size(180, 200);
			this.sixteen1.TabIndex = 11;
			this.sixteen1.Word = RTYC.SegmentDisplay.SegmentDisplayStyle.WordStyle.None;
			// 
			// timer4
			// 
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// dial1
			// 
			this.dial1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.dial1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.dial1.CausesValidation = false;
			this.dial1.DisplaySecond = true;
			this.dial1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dial1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.dial1.Location = new System.Drawing.Point(25, 405);
			this.dial1.Margin = new System.Windows.Forms.Padding(0);
			this.dial1.Name = "dial1";
			this.dial1.Size = new System.Drawing.Size(256, 256);
			this.dial1.TabIndex = 30;
			this.dial1.Value = new System.DateTime(((long)(0)));
			// 
			// hourMinuteSecond1
			// 
			this.hourMinuteSecond1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.hourMinuteSecond1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.hourMinuteSecond1.CausesValidation = false;
			this.hourMinuteSecond1.ColonState = true;
			this.hourMinuteSecond1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourMinuteSecond1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.hourMinuteSecond1.Location = new System.Drawing.Point(549, 277);
			this.hourMinuteSecond1.Margin = new System.Windows.Forms.Padding(0);
			this.hourMinuteSecond1.Name = "hourMinuteSecond1";
			this.hourMinuteSecond1.Size = new System.Drawing.Size(398, 100);
			this.hourMinuteSecond1.TabIndex = 27;
			this.hourMinuteSecond1.Time = new System.DateTime(((long)(0)));
			// 
			// minuteSecond1
			// 
			this.minuteSecond1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.minuteSecond1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.minuteSecond1.CausesValidation = false;
			this.minuteSecond1.ColonState = true;
			this.minuteSecond1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minuteSecond1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.minuteSecond1.Location = new System.Drawing.Point(287, 277);
			this.minuteSecond1.Margin = new System.Windows.Forms.Padding(0);
			this.minuteSecond1.Name = "minuteSecond1";
			this.minuteSecond1.Size = new System.Drawing.Size(262, 100);
			this.minuteSecond1.TabIndex = 24;
			this.minuteSecond1.Time = new System.DateTime(((long)(0)));
			// 
			// hourMinute1
			// 
			this.hourMinute1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.hourMinute1.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
			this.hourMinute1.CausesValidation = false;
			this.hourMinute1.ColonState = true;
			this.hourMinute1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourMinute1.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.hourMinute1.Location = new System.Drawing.Point(25, 277);
			this.hourMinute1.Margin = new System.Windows.Forms.Padding(0);
			this.hourMinute1.Name = "hourMinute1";
			this.hourMinute1.Size = new System.Drawing.Size(262, 100);
			this.hourMinute1.TabIndex = 23;
			this.hourMinute1.Time = new System.DateTime(((long)(0)));
			// 
			// WinMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 850);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.dial1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.hourMinuteSecond1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.minuteSecond1);
			this.Controls.Add(this.hourMinute1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.colon1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button6);
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
			this.Controls.Add(this.sixteen1);
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
		private SegmentDisplay.Sixteen sixteen1;
		private Button button6;
		private Label label5;
		private SegmentDisplay.Colon colon1;
		private Button button7;
		private Label label6;
		private Clock.HourMinute hourMinute1;
		private Clock.MinuteSecond minuteSecond1;
		private Button button8;
		private Label label7;
		private Timer timer2;
		private Clock.HourMinuteSecond hourMinuteSecond1;
		private Button button9;
		private Label label8;
		private Timer timer3;
		private ErrorProvider errorProvider1;
		private Button button10;
		private Clock.Dial dial1;
		private Button button11;
		private Label label9;
		private Timer timer4;
	}
}

