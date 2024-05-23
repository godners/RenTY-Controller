// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	public abstract partial class SegmentDisplay : UserControl
	{
		/// <summary>Initialize Component</summary>
		public SegmentDisplay () => InitializeComponent();
		private Graphics G => CreateGraphics();
		private UInt16 ShownSegment = 0;
		/// <summary>Shown Word</summary>
		public WordStyle Word { get => SearchWord(ShownSegment); set => DrawWord(value); }
		private Byte ShownSymbol = 0;
		/// <summery>Shown Dot</summery>
		public DotStyle Dot { get => SearchDot(ShownSymbol); set => DrawDot(value); }
		private void SegmentDisplay_Load (Object O, EventArgs E) { if (OffColor == Color.Empty) OffColor = base.BackColor; DrawAll(); }
	}
}
