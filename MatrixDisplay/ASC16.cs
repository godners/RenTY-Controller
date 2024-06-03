// Ignore Spelling: RTYC ASC HZK

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using RTYC.MatrixDisplay.Properties;
using static RTYC.MatrixDisplay.MatrixDisplayStyle;

namespace RTYC.MatrixDisplay
{
	/// <summary>Matrix Display - ASCII 12 * 16</summary>
	public partial class ASC16TEST : UserControl
	{
		/// <summary>Matrix Display - ASCII 8 * 16</summary>
		public ASC16TEST () => InitializeComponent();

		private readonly Size MatrixSize = new Size(8, 16);  // override


		private Single PixelWidth => Convert.ToSingle(Width) / Convert.ToSingle(MatrixSize.Width);
		private Single PixelHeight => Convert.ToSingle(Height) / Convert.ToSingle(MatrixSize.Height);
		private SizeF PixelSize => new SizeF(PixelWidth, PixelHeight);
		private Single PixelLeft (Int32 MatrixLeft) => Convert.ToSingle(MatrixLeft) * PixelWidth;
		private Single PixelTop (Int32 MatrixTop) => Convert.ToSingle(MatrixTop) * PixelHeight;
		private PointF PixelLocation (Int32 MatrixLeft, Int32 MatrixTop) => new PointF(PixelLeft(MatrixLeft), PixelTop(MatrixTop));
		private RectangleF PixelRectangle (Int32 MatrixLeft, Int32 MatrixTop) => new RectangleF(PixelLocation(MatrixLeft, MatrixTop), PixelSize);




		private PixelStyle PStyle = PixelStyle.Rectangle;
		/// <summary>Pixel Style: Rectangle or Ellipse</summary>
		public PixelStyle Style { get => PStyle; set { PStyle = value; DrawAll(); } }
		private GraphicsPath GPath;


		private void RectanglePixel (Int32 MatrixLeft, Int32 MatrixTop) => GPath.AddRectangle(PixelRectangle(MatrixLeft, MatrixTop));
		private void EllipsePixel (Int32 MatrixLeft, Int32 MatrixTop) => GPath.AddEllipse(PixelRectangle(MatrixLeft, MatrixTop));
		private void AddPixel (Int32 MatrixLeft, Int32 MatrixTop)
		{
			switch (Style)
			{
				case PixelStyle.Rectangle: GPath.StartFigure(); RectanglePixel(MatrixLeft, MatrixTop); break;
				case PixelStyle.Ellipse: GPath.StartFigure(); EllipsePixel(MatrixLeft, MatrixTop); break;
			}
		}



		private String SWord = " ";
		/// <summary>Display Word</summary>
		public String Word { get => SWord; set { SWord = value.Substring(0, 1); DrawAll(); } }

		private readonly Byte[] Data = Resources.ASC16;// MatrixDisplay_Library.ASC16; // override

		private Byte[] CharMatrix () 
		{
			Int32 DataSize = MatrixSize.Width * MatrixSize.Height / 8; //override
			Int32 Offset = Word.ToCharArray()[0] * DataSize;
			Byte[] Buffer = new Byte[DataSize];
			Array.Copy(Data, Offset, Buffer, 0, DataSize);
			return Buffer;
		}

		private void MakePath ()
		{
			Byte [] Matrix = CharMatrix();
			for (Int32 Y = 0; Y < MatrixSize.Height; Y++) for (Int32 X = 0; X < MatrixSize.Width; X++)
				{ Int32 Index = Y; if ((Matrix[Index] & (0X80 >> X)) != 0) AddPixel(X, Y); }
		}







		private Graphics G => CreateGraphics();

		private Brush PixelBrush => new SolidBrush(ForeColor);
		private void DrawPixel () { GPath.CloseAllFigures(); G.FillPath(PixelBrush, GPath); }




		private void DrawAll () { GPath = new GraphicsPath(); MakePath(); G.Clear(BackColor); DrawPixel(); }


	}
}
