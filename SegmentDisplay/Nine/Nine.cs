// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.CharDefine;

namespace RTYC.SegmentDisplay
{
	public partial class Nine : UserControl
	{
		/// <summary>Initialize Component</summary>
		public Nine () => InitializeComponent();
		private Graphics G => CreateGraphics();
		private UInt16 ShownChar = 0;
		/// <summary>Shown Word</summary>
		public Char Word { get => SearchNine(ShownChar); set { if (!ExistNine(value)) return; ShownChar = SearchNine(value); DrawAll(); } }
		private void Nine_Load (object o, EventArgs e) { if (OffColor == Color.Empty) OffColor = base.BackColor; DrawAll(); }
		private void Nine_ReDraw (object o, EventArgs e) => DrawAll();
		private void Nine_Layout (object o, LayoutEventArgs e) => DrawAll();
		private void Nine_Paint (object o, PaintEventArgs e) => DrawAll();
	}
}
