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
		private void WinMain_Load (Object O, EventArgs E)
		{
			seven1.SetColor(TemplateName.Red); eight1.SetColor(TemplateName.Green); nine1.SetColor(TemplateName.Orange);
			fourteen1.SetColor(TemplateName.Black); sixteen1.SetColor(TemplateName.White); colon1.SetColor(TemplateName.Red);
			hourMinute1.SetSegmentColor(TemplateName.Red); minuteSecond1.SetSegmentColor(TemplateName.Green);
			hourMinuteSecond1.SetSegmentColor(TemplateName.Orange);
		}
		Int32 SD7 = 65; private void Button1_Click (Object O, EventArgs E) { label1.Text = ((WordStyle)SD7).ToString(); seven1.DrawWord((WordStyle)SD7++); }
		Int32 SD8 = 48; Int32 SDD = 0; private void Button2_Click (Object O, EventArgs E)
		{ label2.Text = ((WordStyle)SD8).ToString(); eight1.DrawWord((WordStyle)SD8++); eight1.DrawDot((DotStyle)(SDD == 1 ? SDD-- : SDD++)); }
		Int32 SD9=48; private void Button3_Click (Object O, EventArgs E) { label3.Text = ((WordStyle)SD9).ToString(); nine1.DrawWord((WordStyle)SD9++); }
		Int32 SD14 = 97; private void Button5_Click (Object O, EventArgs E)
		{ label4.Text = ((WordStyle)SD14).ToString(); fourteen1.DrawWord((WordStyle)SD14++); }
		Int32 SD16 = 97; private void Button6_Click (Object O, EventArgs E)
		{ label5.Text = ((WordStyle)SD16).ToString(); sixteen1.DrawWord((WordStyle)SD16++); sixteen1.DrawDot(DotStyle.Comma); }
		private void Button4_Click (Object O, EventArgs E) => colon1.State = !colon1.State;
		private void Timer1_Tick (Object O, EventArgs E)
		{ hourMinute1.Time = DateTime.Now; hourMinute1.ColonState = !hourMinute1.ColonState; label6.Text = DateTime.Now.ToString(); }
		private void Button7_Click (Object O, EventArgs E) => timer1.Enabled = !timer1.Enabled;
		private void Timer2_Tick (object sender, EventArgs e)
		{ minuteSecond1.Time = DateTime.Now; minuteSecond1.ColonState = !minuteSecond1.ColonState; label7.Text = DateTime.Now.ToString(); }
		private void Button8_Click (object sender, EventArgs e) => timer2.Enabled = !timer2.Enabled;
		private void Timer3_Tick (object sender, EventArgs e)
		{ hourMinuteSecond1.Time = DateTime.Now; hourMinuteSecond1.ColonState = !hourMinuteSecond1.ColonState; label8.Text = DateTime.Now.ToString(); }
		private void Button9_Click (object sender, EventArgs e) => timer3.Enabled = !timer3.Enabled;
		private void timer4_Tick (object sender, EventArgs e) { dial1.Value = DateTime.Now; label9.Text = DateTime.Now.ToString(); }
		private void button10_Click (object sender, EventArgs e) => timer4.Enabled = !timer4.Enabled;

	}
}
