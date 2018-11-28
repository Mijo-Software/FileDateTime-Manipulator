using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FileDateTime_Manipulator
{
	static class Program
	{
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FdtmForm());
		}
	}
}
