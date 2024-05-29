// Ignore Spelling: RTYC

using System;
using RTYC.SegmentDisplay;
using System.Drawing;
using static System.Math;
using static RTYC.SegmentDisplay.SegmentDisplayStyle;

namespace RTYC.Clock
{
	/// <summary>Clock - Show Hour and Minute via Four Segments</summary>
	public class HourMinute : Segment
	{
		#region Region - Value
		private DateTime TimeValue = DateTime.MinValue;
		/// <summary>Time Value</summary>
		public DateTime Time { get => TimeValue; set { TimeValue = value; DrawAll(); } }
		private Boolean ColonValue = true;
		/// <summary>Colon State: True = ON, False = OFF</summary>
		public Boolean ColonState { get => ColonValue; set { ColonValue = value; DrawAll(); } }
		#endregion
		#region Region - Display Control Function
		private Int32 VC (Int32 I)
		{
			switch (I)
			{
				case 0: return (Int32)Floor(Time.Hour / 10D);
				case 1: return Time.Hour % 10;
				case 3: return (Int32)Floor(Time.Minute / 10D);
				case 4: return Time.Minute % 10;
				default: return -48;
			}
		}
		private WordStyle NC (Int32 I) => (WordStyle)(VC(I) + 48);
		private protected override void DrawAll () { SD0.Word = NC(0); SD1.Word = NC(1); SD2.State = ColonState; SD3.Word = NC(3); SD4.Word = NC(4); }
		#endregion
		#region Region - Style Control Function
		private protected override Single Aspect => 2.62F;
		private protected override void LockAspectWork ()
		{
			SD0.Location = P(25, 25); SD1.Location = P(170, 25); SD2.Location = P(315, 25); SD3.Location = P(365, 25); SD4.Location = P(510, 25);
			SD0.Size = S(120, 200); SD1.Size = S(120, 200); SD2.Size = S(25, 200); SD3.Size = S(120, 200); SD4.Size = S(120, 200);
		}
		private protected override void ColorS2C () { ForeColor = SD2.OnColor; BackColor = SD2.GroundColor; }
		#endregion
		#region Region - Designer Function
		private Seven SD0, SD1, SD3, SD4; private Colon SD2;
		private protected override Size ControlInitSize => new Size(665, 250);
		private protected override SegmentDisplay.SegmentDisplay[] SDS => new SegmentDisplay.SegmentDisplay[] { SD0, SD1, SD2, SD3, SD4 };
		private protected override void AssignSegments ()
		{
			SD0.Name = "SD0"; SD0.Location = P(25, 25); SD0.TabIndex = 0; SD0.Margin = InitPadding; SD0.TabStop = false; SD0.Size = SevenInitSize;
			SD1.Name = "SD1"; SD1.Location = P(170, 25); SD1.TabIndex = 1; SD1.Margin = InitPadding; SD1.TabStop = false; SD1.Size = SevenInitSize;
			SD2.Name = "SD2"; SD2.Location = P(315, 25); SD2.TabIndex = 2; SD2.Margin = InitPadding; SD2.TabStop = false; SD2.Size = ColonInitSize;
			SD3.Name = "SD3"; SD3.Location = P(365, 25); SD3.TabIndex = 3; SD3.Margin = InitPadding; SD3.TabStop = false; SD3.Size = SevenInitSize;
			SD4.Name = "SD4"; SD4.Location = P(510, 25); SD4.TabIndex = 4; SD4.Margin = InitPadding; SD4.TabStop = false; SD4.Size = SevenInitSize;
		}
		private protected override void AddSegments () { Controls.Add(SD0); Controls.Add(SD1); Controls.Add(SD2); Controls.Add(SD3); Controls.Add(SD4); }
		private protected override void InitControls () { SD1 = new Seven(); SD0 = new Seven(); SD2 = new Colon(); SD3 = new Seven(); SD4 = new Seven(); }
		#endregion
	}
}
