using System;
using System.Windows.Forms;
using MijoSoftware.AssemblyInformation;

namespace FileDateTimeManipulator
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();
		}

		private void AboutForm_Load(object sender, EventArgs e)
		{
			labelTitle.Text = AssemblyInfo.AssemblyTitle;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelDescription.Text = AssemblyInfo.AssemblyDescription;
			Text = $"{Text} {labelTitle.Text} {labelVersion.Text}";
		}
	}
}
