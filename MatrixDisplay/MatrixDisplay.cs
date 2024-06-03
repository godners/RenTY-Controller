// Ignore Spelling: RTYC

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static RTYC.MatrixDisplay.MatrixDisplayStyle;

namespace RTYC.MatrixDisplay
{
	public abstract partial class MatrixDisplay : UserControl
	{
		#region Region - Calculation Pixel
		private protected abstract Size MatrixSize { get; }
		private Single PixelWidth => Convert.ToSingle(Width) / Convert.ToSingle(MatrixSize.Width);
		private Single PixelHeight => Convert.ToSingle(Height) / Convert.ToSingle(MatrixSize.Height);
		private SizeF PixelSize => new SizeF(PixelWidth, PixelHeight);
		private Single PixelLeft (Int32 MatrixLeft) => Convert.ToSingle(MatrixLeft) * PixelWidth;
		private Single PixelTop (Int32 MatrixTop) => Convert.ToSingle(MatrixTop) * PixelHeight;
		private PointF PixelLocation (Int32 MatrixLeft, Int32 MatrixTop) => new PointF(PixelLeft(MatrixLeft), PixelTop(MatrixTop));
		private RectangleF PixelRectangle (Int32 MatrixLeft, Int32 MatrixTop) => new RectangleF(PixelLocation(MatrixLeft, MatrixTop), PixelSize);
		#endregion
		#region Region - Draw Pixel
		private PixelStyle PStyle = PixelStyle.Rectangle;
		/// <summary>Pixel Style: Rectangle or Ellipse</summary>
		public PixelStyle Style { get => PStyle; set { PStyle = value; DrawAll(); } }
		private GraphicsPath GPath;
		private void RectanglePixel (Int32 MatrixLeft, Int32 MatrixTop) => GPath.AddRectangle(PixelRectangle(MatrixLeft, MatrixTop));
		private void EllipsePixel (Int32 MatrixLeft, Int32 MatrixTop) => GPath.AddEllipse(PixelRectangle(MatrixLeft, MatrixTop));
		private protected void AddPixel (Int32 MatrixLeft, Int32 MatrixTop)
		{
			GPath.StartFigure();
			switch (Style)
			{
				case PixelStyle.Rectangle: RectanglePixel(MatrixLeft, MatrixTop); break;
				case PixelStyle.Ellipse: EllipsePixel(MatrixLeft, MatrixTop); break;
			}
		}
		private protected abstract void LoadPixel ();
		private Graphics G => CreateGraphics();
		private Brush PixelBrush => new SolidBrush(ForeColor);
		private void DrawAll () { GPath = new GraphicsPath(); LoadPixel(); GPath.CloseAllFigures(); G.Clear(BackColor); G.FillPath(PixelBrush, GPath); }
		#endregion
		#region Region - Load Data
		private String SWord = " ";
		private protected Byte[] BWord { get; set; }
		/// <summary>Display Word</summary>
		public String Word { get => SWord; set { SWord = value.Substring(0, 1); LoadData(); DrawAll(); } }
		private protected abstract Byte[] Library { get; }
		private protected abstract Int32 DataSize { get; }
		private protected abstract Byte[] LoadData ();
		#endregion
	}
}
