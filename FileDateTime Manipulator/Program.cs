using System;
using System.Windows.Forms;

namespace FileDateTimeManipulator
{
	/// <summary>
	/// Program
	/// </summary>
	internal static class Program
	{
		/// <summary>
		/// Main entrance point of the application
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			using FdtmForm mainWindow = new FdtmForm();
			Application.Run(mainForm: mainWindow);
		}
	}
}
