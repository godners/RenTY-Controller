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
		private protected Graphics G => CreateGraphics();
		private protected UInt16 ShownSegment = 0;
		/// <summary>Shown Word</summary>
		public WordStyle Word { get; set; }////////////////////////////
		private protected Byte ShownSymbol = 0;
		/// <summery>Shown Dot</summery>
		public DotStyle Dot { get; set; }////////////////////////////
		private protected abstract void SegmentDisplay_Load (Object O, EventArgs E);
	}
}
