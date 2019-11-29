using System;
using System.Windows.Forms;
using FileDateTimeManipulator.Properties;
using MijoSoftware.AssemblyInformation;

namespace FileDateTimeManipulator
{
	public partial class AboutForm : Form
	{
		private readonly Settings settings = new Settings();

		private void LoadFatcowIcons() => buttonOkay.Image = Resources.fatcow_tick_button_16;

		private void LoadFugueIcons() => buttonOkay.Image = Resources.fugue_tick_button_16;

		private void LoadSilkIcons() => buttonOkay.Image = Resources.silk_accept_16;

		public AboutForm() => InitializeComponent();

		private void AboutForm_Load(object sender, EventArgs e)
		{
			labelTitle.Text = AssemblyInfo.AssemblyTitle;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelDescription.Text = AssemblyInfo.AssemblyDescription;
			Text = $"{Text} {labelTitle.Text} {AssemblyInfo.AssemblyVersion}";
			switch (settings.userIconSet)
			{
				default: case "fatcow": LoadFatcowIcons(); break;
				case "fugue": LoadFugueIcons(); break;
				case "silk": LoadSilkIcons(); break;
			}
		}

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((Control)sender).AccessibleDescription;

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;
	}
}
