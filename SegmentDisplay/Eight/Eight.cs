// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.CharDefine;

namespace RTYC.SegmentDisplay
{
	public partial class Eight : UserControl
	{
		/// <summary>Initialize Component</summary>
		public Eight () => InitializeComponent();
		private Graphics G => CreateGraphics();
		private Byte ShownChar = 0;
		/// <summary>Shown Word</summary>
		public Char Word { get => SearchSeven(ShownChar); set { if (!ExistSeven(value)) return; ShownChar = SegmentSeven(value); DrawAll(); } }
		private Boolean ShownDot = false;
		/// <summary>Shown Dot</summary>
		public Boolean DotON { get => ShownDot; set { ShownDot = value; DrawAll(); } }
		private void Eight_Load (object o, EventArgs e) { if (OffColor == Color.Empty) OffColor = base.BackColor; DrawAll(); }
		private void Eight_ReDraw (object o, EventArgs e) => DrawAll();
		private void Eight_Layout (object o, LayoutEventArgs e) => DrawAll();
		private void Eight_Paint (object o, PaintEventArgs e) => DrawAll();
	}
}
