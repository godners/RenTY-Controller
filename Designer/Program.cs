// Ignore Spelling: RTYC

using System;
using System.Windows.Forms;

namespace RTYC.Designer
{
	internal static class Program
	{
		internal static Form FormMain;
		[STAThread] internal static void Main () { Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false); FormMain = new WinMain(); Application.Run(FormMain); }
	}
}
