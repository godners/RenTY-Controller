// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using static System.Math;

namespace RTYC.Clock
{
	/// <summary>Clock - Show Time via Dial</summary>
	public partial class Dial : UserControl
	{
		#region Region - Initialize Function
		private readonly Single Aspect = 1F;
		private readonly Size InitSize = new Size(256, 256);
		private readonly Padding InitPadding = new Padding(0);
		private readonly Font InitFont = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
		private void LockAspect () { Size = new Size(Min(Size.Width, Size.Height), Min(Size.Width, Size.Height)); DrawAll(); }
		private void LockProperty ()
		{
			Padding = InitPadding; AutoSize = false; ImeMode = ImeMode.Disable; AutoValidate = AutoValidate.Disable;
			Cursor = DefaultCursor; Font = InitFont; RightToLeft = RightToLeft.No; CausesValidation = false;
		}
		private void AssignContral ()
		{
			AutoScaleMode = AutoScaleMode.None; AutoSizeMode = AutoSizeMode.GrowAndShrink; AutoValidate = AutoValidate.Disable;
			Font = InitFont; CausesValidation = false; ImeMode = ImeMode.Disable; Margin = InitPadding; Name = "Dial"; Size = InitSize;
		}
		private EventHandler EHDA => new EventHandler(DrawAll);
		private EventHandler EHPT => new EventHandler(LockProperty);
		private void DrawAll (Object O, EventArgs E) => DrawAll();
		private void DrawAll (Object O, LayoutEventArgs E) => DrawAll();
		private void DrawAll (Object O, PaintEventArgs E) => DrawAll();
		private void LockProperty (Object O, EventArgs E) => LockProperty();
		private void LockAspect (Object O, EventArgs E) => LockAspect();
		private void AddEvent ()
		{
			AutoSizeChanged += EHPT; AutoValidateChanged += EHPT; CausesValidationChanged += EHPT; CursorChanged += EHPT;
			FontChanged += EHPT; RightToLeftChanged += EHPT; PaddingChanged += EHPT; ImeModeChanged += EHPT; ForeColorChanged += EHDA;
			LocationChanged += EHDA; Move += EHDA; SizeChanged += EHDA; VisibleChanged += EHDA; SystemColorsChanged += EHDA;
			BackColorChanged += EHDA; EnabledChanged += EHDA; Load += new EventHandler(DrawAll); Paint += new PaintEventHandler(DrawAll);
			Layout += new LayoutEventHandler(DrawAll); Resize += new EventHandler(LockAspect);
		}
		/// <summary>Initialize Component</summary>
		public Dial () { SuspendLayout(); AssignContral(); AddEvent(); ResumeLayout(false); }
		private Graphics G => CreateGraphics();
		#endregion
		#region Region - Graphics Variables
		private Single Radius => Width / 2F;
		private PointF CP => new PointF(Radius, Radius); // Center Point
		private Double Angel (Single Value) => (15 - Value) * PI / 30F; // Degree To Angel
		private Single PX (Single PointRadius, Single Value) => Convert.ToInt32(Radius + Cos(Angel(Value)) * PointRadius); // X of Point from Radius and Value
		private Single PY (Single PointRadius, Single Value) => Convert.ToInt32(Radius - Sin(Angel(Value)) * PointRadius); // Y of Point from Radius and Value
		private PointF P (Single PointRadius, Single Value) => new PointF(PX(PointRadius, Value), PY(PointRadius, Value)); // Point from Radius and Value
		private PointF PFRR (Single Rate) => new PointF(Radius * Rate, Radius * Rate); // Point From Radius * Rate
		private SizeF SFRR (Single Rate) => new SizeF(Radius * Rate, Radius * Rate); // Size From Radius * Rate
		private RectangleF RFRR (Single PointRate, Single SizeRate) => new RectangleF(PFRR(PointRate), SFRR(SizeRate)); // Rectangle From Radius * Rate
		#endregion
		#region Region - Generate BackGround
		private GraphicsPath GDThin // GraphicsPath - Degree Thin
		{
			get
			{
				GraphicsPath GP = new GraphicsPath(); GP.StartFigure(); for (Int32 I = 0; I < 60; I++)
				{ if (I % 5 == 0) I++; GP.StartFigure(); GP.AddLine(P(Radius, I), P(Radius * 0.875F, I)); }
				GP.CloseAllFigures(); return GP;
			}
		}
		private GraphicsPath GDBold // GraphicsPath - Degree Bold
		{
			get
			{
				GraphicsPath GP = new GraphicsPath(); for (Int32 I = 0; I < 60; I += 5)
				{ GP.StartFigure(); GP.AddLine(P(Radius, I), P(Radius * 0.75F, I)); }
				GP.CloseAllFigures(); return GP;
			}
		}
		private Region RCenter // Region - Center
		{
			get
			{
				GraphicsPath GP = new GraphicsPath(); GP.AddEllipse(RFRR(0.75F, 0.5F));
				GP.AddEllipse(RFRR(0.8125F, 0.375F)); GP.AddEllipse(RFRR(0.9375F, 0.125F)); return new Region(GP);
			}
		}
		#endregion
		#region Region - Color Variables
		private Pen PDThin => new Pen(ForeColor, Radius * 0.0234375F) { StartCap = LineCap.Round, EndCap = LineCap.Round };
		private Pen PDBold => new Pen(ForeColor, Radius * 0.0390625F) { StartCap = LineCap.Round, EndCap = LineCap.Triangle };
		private Brush BCenter => new SolidBrush(ForeColor);
		private Pen PHour => new Pen(ForeColor, Radius * 0.03125F) { StartCap = LineCap.Flat, EndCap = LineCap.Triangle };
		private Pen PMinute => new Pen(ForeColor, Radius * 0.015625F) { StartCap = LineCap.Flat, EndCap = LineCap.Triangle };
		private Pen PSecond => new Pen(ForeColor, Radius * 0.0078125F) { StartCap = LineCap.Flat, EndCap = LineCap.Flat };
		private Brush BSecond => new SolidBrush(BackColor);
		#endregion
		#region Region - Graphics Function		
		private readonly DateTime[] DTNull = new DateTime[] { DateTime.MinValue, DateTime.MaxValue };
		private DateTime DTValue = DateTime.MinValue;
		/// <summary>Time Value</summary>
		public DateTime Value { get => DTValue; set { DTValue = value; DrawAll(); } }
		private Boolean DSValue = true;
		/// <summary>Display Second</summary>
		public Boolean DisplaySecond { get => DSValue; set { DSValue = value; DrawAll(); } }
		private void DrawGround () { G.DrawPath(PDThin, GDThin); G.DrawPath(PDBold, GDBold); G.FillRegion(BCenter, RCenter); }
		private void DrawHour () { Single V = Value.Hour % 12 * 5F + Value.Minute / 60F; G.DrawLine(PHour, P(Radius * 0.25F, V), P(Radius * 0.5F, V)); }
		private void DrawMinute () { Single V = Value.Minute + Value.Second / 60F; G.DrawLine(PMinute, P(Radius * 0.25F, V), P(Radius * 0.75F, V)); }
		private void DrawSecond ()
		{
			Single V = Value.Second + Value.Millisecond / 1000F, O = Radius * 0.03125F, R = Radius * 0.0625F;
			PointF PC = P(Radius*0.875F, V); PointF PL = new PointF(PC.X - O, PC.Y - O); SizeF SL = new SizeF(R, R);
			RectangleF RL = new RectangleF(PL, SL); G.FillEllipse(BSecond, RL); G.DrawEllipse(PSecond, RL);
		}
		private void DrawPins () { DrawHour(); DrawMinute(); if (DisplaySecond) DrawSecond(); }
		private void DrawAll () { G.Clear(BackColor); DrawGround(); if (!DTNull.Contains(DTValue)) DrawPins(); }
		#endregion
	}
}
