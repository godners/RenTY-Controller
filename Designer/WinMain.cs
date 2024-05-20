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
namespace RTYC.Designer
{
	public partial class WinMain : Form
	{
		public WinMain () => InitializeComponent();

		private void WinMain_Load (object sender, EventArgs e)
		{
			//Debug.Print(seven1.BackColor.ToArgb().ToString());
			seven1.SetColor(TemplateName.Red);
			eight1.SetColor(TemplateName.Green);
			nine1.SetColor(TemplateName.Orange);
		}
		private readonly Char[] DigitChar = new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ' ' };
		Int32 SD7 = 0;
		private void NextSeven () { seven1.DrawChar(DigitChar[SD7 % DigitChar.Length]); label1.Text = DigitChar[SD7++ % DigitChar.Length].ToString(); }
		private void Button1_Click (object sender, EventArgs e) => NextSeven();
		private void NextEight () { eight1.DrawChar(DigitChar[SD8 % DigitChar.Length]); label2.Text = DigitChar[SD8++ % DigitChar.Length].ToString(); }
		private void RollEight () => eight1.DotON = !eight1.DotON;
		Int32 SD8 = 0;
		private void Button2_Click (object sender, EventArgs e) { NextEight(); RollEight(); }
		Int32 SD9=0;
		private void NextNine () { nine1.DrawChar(DigitChar[SD9 % DigitChar.Length]); label3.Text = DigitChar[SD9++ % DigitChar.Length].ToString(); }
		private void Button3_Click (object sender, EventArgs e) => NextNine();

		














		private void NextAll() { NextSeven(); NextEight(); RollEight(); NextNine(); }
		private void Timer1_Tick (object sender, EventArgs e) => NextAll(); 
		private void Button4_Click (object sender, EventArgs e) => timer1.Enabled = !timer1.Enabled;

		
	}
}
