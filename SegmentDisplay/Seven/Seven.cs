// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.CharDefine;

namespace RTYC.SegmentDisplay
{
	public partial class Seven : UserControl
	{
		/// <summary>Initialize Component</summary>
		public Seven () => InitializeComponent();
		private Graphics G => CreateGraphics();
		private Byte ShownChar = 0;
		/// <summary>Shown Word</summary>
		public Char Word { get => SearchSeven(ShownChar); set { if (!ExistSeven(value)) return; ShownChar = SegmentSeven(value); DrawAll(); } }
		private void Seven_Load (object o, EventArgs e) { if (OffColor == Color.Empty) OffColor = base.BackColor; DrawAll(); }
		private void Seven_ReDraw (object o, EventArgs e) => DrawAll();
		private void Seven_Layout (object o, LayoutEventArgs e) => DrawAll();
		private void Seven_Paint (object o, PaintEventArgs e) => DrawAll();
	}
}
