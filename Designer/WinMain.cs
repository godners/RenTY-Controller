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
using System.Reflection;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.ColorTemplate;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;
using RTYC.Clock;

namespace RTYC.Designer
{
	public partial class WinMain : Form
	{
		public WinMain () => InitializeComponent();
		private void WinMain_Load (Object O, EventArgs E)
		{
			SV1.SetColor(TemplateName.Red); EG1.SetColor(TemplateName.Green); NN1.SetColor(TemplateName.Orange);
			FT1.SetColor(TemplateName.Black); ST1.SetColor(TemplateName.White); CL1.SetColor(TemplateName.Red);
			HM1.SetSegmentColor(TemplateName.Red); MS1.SetSegmentColor(TemplateName.Green);
			HMS1.SetSegmentColor(TemplateName.Orange);
		}
		private DateTime DTN => DateTime.Now; private String SDTN => $"{DTN:yyyy-MM-dd HH:mm:ss.fff}";
		private WordStyle WSV (Int32 I) => (WordStyle)I; private String WSS (Int32 I) => WSV(I).ToString();
		private void ET (Timer T) => T.Enabled = !T.Enabled;
		private void SetValue (Object Class, String Property, Object Value)
		{ PropertyInfo PI = Class.GetType().GetProperty(Property); Value = Convert.ChangeType(Value, PI.PropertyType); PI.SetValue(Class, Value); }
		private Object GetValue (Object Class, String Property)
		{ PropertyInfo PI = Class.GetType().GetProperty(Property); return PI.GetValue(Class); }
		private void SST (Segment S) => SetValue(S, "Time", DTN);
		private void SAC (Segment S) => SetValue(S, "ColonState", !(Boolean)GetValue(S, "ColonState"));


		Int32 SD7 = 65; private void B1 (Object O, EventArgs E) { L1.Text = WSS(SD7); SV1.DrawWord(WSV(SD7++)); }
		Int32 SD8 = 48, SDD = 0; private DotStyle SDDA => (DotStyle)(SDD == 1 ? SDD-- : SDD++);
		private void B2 (Object O, EventArgs E) { L2.Text = WSS(SD8); EG1.DrawWord(WSV(SD8++)); EG1.DrawDot(SDDA); }
		Int32 SD9=48; private void B3 (Object O, EventArgs E) { L3.Text = WSS(SD9); NN1.DrawWord(WSV(SD9++)); }
		Int32 SD14 = 97; private void B5 (Object O, EventArgs E) { L4.Text = WSS(SD14); FT1.DrawWord(WSV(SD14++)); }
		Int32 SD16 = 97, SDC = 0; private DotStyle SDCA { get { if (SDC == 2) { SDC = 0; return DotStyle.Comma; } else return (DotStyle)SDC++; } }
		private void B6 (Object O, EventArgs E) { L5.Text = WSS(SD16); ST1.DrawWord(WSV(SD16++)); ST1.DrawDot(SDCA); }
		private void B4 (Object O, EventArgs E) => CL1.State = !CL1.State;
		private void TM1 (Object O, EventArgs E) { SST(HM1); SAC(HM1); L6.Text = SDTN; }
		private void B7 (Object O, EventArgs E) => ET(T1);
		private void TM2 (Object O, EventArgs e) { SST(MS1); SAC(MS1); L7.Text = SDTN; }
		private void B8 (Object O, EventArgs e) => ET(T2);
		private void TM3 (Object O, EventArgs e) { SST(HMS1); SAC(HMS1); L8.Text = SDTN; }
		private void B9 (Object O, EventArgs e) => ET(T3);

		private void B11 (object sender, EventArgs e) => asC161.Word = "a";
		

		private void TM4 (Object O, EventArgs e) { DL1.Value = DTN; L9.Text = SDTN; }
		private void B10 (Object O, EventArgs e) => ET(T4);



	}
}
