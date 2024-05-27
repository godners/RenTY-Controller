// Ignore Spelling: RTYC

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.ColorTemplate;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.Designer
{
	public partial class WinMain : Form
	{
		public WinMain () => InitializeComponent();
		private void WinMain_Load (object sender, EventArgs e)
		{
			seven1.SetColor(TemplateName.Red);
			eight1.SetColor(TemplateName.Green);
			nine1.SetColor(TemplateName.Orange);
			fourteen1.SetColor(TemplateName.Black);
			sixteen1.SetColor(TemplateName.White);
		}
		private readonly Char[] DigitChar = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' };
		Int32 SD7 = 65;
		private void Button1_Click (object sender, EventArgs e)
		{
			label1.Text = ((WordStyle)SD7).ToString(); seven1.DrawWord((WordStyle)SD7++);
		}
		Int32 SD8 = 48; Int32 SDD = 0;
		private void Button2_Click (object sender, EventArgs e) 
		{
			label2.Text = ((WordStyle)SD8).ToString(); eight1.DrawWord((WordStyle)SD8++); 
			eight1.DrawDot((DotStyle)(SDD == 1 ? SDD-- : SDD++));
		}
		Int32 SD9=48;		
		private void Button3_Click (object sender, EventArgs e) 
		{
			label3.Text = ((WordStyle)SD9).ToString(); nine1.DrawWord((WordStyle)SD9++);
		}

		Int32 SD14 = 97;		
		private void Button5_Click (object sender, EventArgs e)
		{
			label4.Text = ((WordStyle)SD14).ToString(); fourteen1.DrawWord((WordStyle)SD14++);			
		}
		Int32 SD16 = 97;
		private void button6_Click (object sender, EventArgs e)
		{
			label5.Text = ((WordStyle)SD16).ToString(); sixteen1.DrawWord((WordStyle)SD16++);
			sixteen1.DrawDot(DotStyle.Comma);
		}
		private void NextAll() { /*NextSeven();*/ /*NextEight();*/ /*RollEight();*/ /*NextNine();*/ }
		private void Timer1_Tick (object sender, EventArgs e) => NextAll(); 
		private void Button4_Click (object sender, EventArgs e) => timer1.Enabled = !timer1.Enabled;


	}
}
