// Ignore Spelling: RTYC
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.SegmentDisplay
{
	public partial class Fourteen : SegmentDisplay
	{
		/// <summary>Initialize Component</summary>
		public Fourteen () => InitializeComponent();
		private protected override Single Aspect => 0.75F;
		private protected override Dictionary<UInt16, Region> SegmentRegion => new Dictionary<UInt16, Region>
		{
			{ 0X0, RP(new Single[] { 11, 10, 21, 20, 129, 20, 139, 10, 129, 0, 21, 0 }) },
			{ 0X1, RP(new Single[] { 140, 11, 130, 21, 130, 89, 140, 99, 150, 89, 150, 21 }) },
			{ 0X2, RP(new Single[] { 140, 101, 130, 106, 130, 179, 140, 189, 150, 179, 150, 106 }) },
			{ 0X3, RP(new Single[] { 11, 190, 21, 200, 129, 200, 139, 190, 129, 190, 21, 180 }) },
			{ 0X4, RP(new Single[] { 10, 101, 0, 111, 0, 179, 10, 189, 20, 179, 20, 111 }) },
			{ 0X5, RP(new Single[] { 10, 11, 0, 21, 0, 89, 10, 99, 20, 89, 20, 21 }) },
			{ 0X6, RP(new Single[] { 11, 100, 21, 110, 84, 100, 74, 100, 64, 90, 21, 90 }) },
			{ 0X7, RP(new Single[] { 76, 100, 86, 110, 129, 110, 139, 100, 129, 90, 86, 90 }) },
			{ 0X8, RP(new Single[] { 21, 21, 21, 26.38F, 60.598F, 89, 64, 89, 64, 83.62F, 24.402F, 21 }) },
			{ 0X9, RP(new Single[] { 65, 22, 65, 89, 75, 99, 85, 89, 85, 22 }) },
			{ 0XA, RP(new Single[] { 129, 21, 128.598F, 21, 86, 83.62F, 86, 89, 89.402F, 89, 129, 26.38F }) },
			{ 0XB, RP(new Single[] { 64, 111, 60.598F, 111, 21, 173.62F, 21, 24.402F, 64, 116.38F }) },
			{ 0XC, RP(new Single[] { 75, 101, 65, 111, 65, 178, 85, 178, 85, 111 }) },
			{ 0XD, RP(new Single[] { 86, 111, 86, 24.402F, 125.598F, 179, 129, 179, 129, 125.598F, 89.402F, 111 }) },
			{ 0XE, REmpty }, { 0XF, REmpty }
		};
		private protected override Dictionary<WordStyle, UInt16> WordMapping => new Dictionary<WordStyle, UInt16>
		{
			// //////////////
		};
		private protected override Dictionary<Byte, Region> SymbolRegions => new Dictionary<Byte, Region>
		{ { 0, REmpty }, { 1, REmpty }, { 2, REmpty }, { 3, REmpty }, { 4, REmpty }, { 5, REmpty }, { 6, REmpty }, { 7, REmpty } };
		private protected override Dictionary<DotStyle, Byte> DotMapping => new Dictionary<DotStyle, Byte>
		{ { DotStyle.None, 0 }, { DotStyle.Dot, 0 }, { DotStyle.Comma, 0 } };
	}
}
