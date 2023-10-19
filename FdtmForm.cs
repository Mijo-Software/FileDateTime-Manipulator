using System.Diagnostics;
using MijoSoftware.AssemblyInformation;

namespace FileDateTime_Manipulator
{
	/// <summary>
	/// FileDateTime Manipulator Form
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class FdtmForm : Form
	{
		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public FdtmForm() => InitializeComponent();

		#endregion

		#region Helpers

		/// <summary>
		/// Get the debugger display
		/// </summary>
		/// <returns>debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
			toolStripStatusLabelInformation.Text = text;
		}

		/// <summary>
		/// Enable all disabled controls after a adding a file or a folder
		/// </summary>
		private void EnableAllControls()
		{
			RadioButtonCreationDateLocalTime_CheckedChanged(sender: null, e: EventArgs.Empty);
			RadioButtonLastAccessDateLocalTime_CheckedChanged(sender: null, e: EventArgs.Empty);
			RadioButtonLastWriteDateLocalTime_CheckedChanged(sender: null, e: EventArgs.Empty);

			radioButtonCreationDateLocalTime.Enabled = true;
			radioButtonCreationDateUtc.Enabled = true;
			radioButtonLastAccessDateLocalTime.Enabled = true;
			radioButtonLastAccessDateUtc.Enabled = true;
			radioButtonLastWriteDateLocalTime.Enabled = true;
			radioButtonLastWriteDateUtc.Enabled = true;

			radioButtonCreationDateLocalTime.Checked = true;
			radioButtonLastAccessDateLocalTime.Checked = true;
			radioButtonLastWriteDateLocalTime.Checked = true;

			labelNewCreationDate.Enabled = true;
			labelNewAccessDate.Enabled = true;
			labelNewWriteDate.Enabled = true;

			dateTimePickerCreated.Enabled = true;
			dateTimePickerAccessed.Enabled = true;
			dateTimePickerWrited.Enabled = true;

			radioButtonNewCreationDateLocalTime.Enabled = true;
			radioButtonNewCreationDateUtc.Enabled = true;
			radioButtonNewLastAccessDateLocalTime.Enabled = true;
			radioButtonNewLastAccessDateUtc.Enabled = true;
			radioButtonNewLastWriteDateLocalTime.Enabled = true;
			radioButtonNewLastWriteDateUtc.Enabled = true;

			buttonApply.Enabled = true;
		}

		#endregion

		#region Load event handlers

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void FdtmForm_Load(object sender, EventArgs e)
		{
			dateTimePickerCreated.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerAccessed.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerWrited.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
		}

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Set the text of the information label in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SetStatusLabel_Enter(object sender, EventArgs e)
		{
			switch (sender)
			{
				case TextBox textBox: SetStatusbarText(text: textBox.AccessibleDescription); break;
				case Button button: SetStatusbarText(text: button.AccessibleDescription); break;
				case RadioButton radioButton: SetStatusbarText(text: radioButton.AccessibleDescription); break;
				case CheckBox checkBox: SetStatusbarText(text: checkBox.AccessibleDescription); break;
				case DateTimePicker dateTimePicker: SetStatusbarText(text: dateTimePicker.AccessibleDescription); break;
				case Label label: SetStatusbarText(text: label.AccessibleDescription); break;
				case PictureBox pictureBox: SetStatusbarText(text: pictureBox.AccessibleDescription); break;
				case CheckedListBox checkedListBox: SetStatusbarText(text: checkedListBox.AccessibleDescription); break;
				case ComboBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case DataGridView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case GroupBox group: SetStatusbarText(text: group.AccessibleDescription); break;
				case ListBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case ListView view: SetStatusbarText(text: view.AccessibleDescription); break;
				case MaskedTextBox box: SetStatusbarText(text: box.AccessibleDescription); break;
				case NumericUpDown numericUpDown: SetStatusbarText(text: numericUpDown.AccessibleDescription); break;
				case MonthCalendar monthCalendar: SetStatusbarText(text: monthCalendar.AccessibleDescription); break;
				case PropertyGrid propertyGrid: SetStatusbarText(text: propertyGrid.AccessibleDescription); break;
				case RichTextBox richTextBox: SetStatusbarText(text: richTextBox.AccessibleDescription); break;
				case ScrollBar scrollBar: SetStatusbarText(text: scrollBar.AccessibleDescription); break;
				case TrackBar trackBar: SetStatusbarText(text: trackBar.AccessibleDescription); break;
				case WebBrowser webBrowser: SetStatusbarText(text: webBrowser.AccessibleDescription); break;
				case DomainUpDown domainUpDown: SetStatusbarText(text: domainUpDown.AccessibleDescription); break;
				case ToolStripButton toolStripButton: SetStatusbarText(text: toolStripButton.AccessibleDescription); break;
				case ToolStripMenuItem toolStripMenuItem: SetStatusbarText(text: toolStripMenuItem.AccessibleDescription); break;
				case ToolStripLabel toolStripLabel: SetStatusbarText(text: toolStripLabel.AccessibleDescription); break;
				case ToolStripComboBox toolStripComboBox: SetStatusbarText(text: toolStripComboBox.AccessibleDescription); break;
				case ToolStripDropDown toolStripDropDown: SetStatusbarText(text: toolStripDropDown.AccessibleDescription); break;
				case ToolStripDropDownButton toolStripDropDownButton: SetStatusbarText(text: toolStripDropDownButton.AccessibleDescription); break;
				case ToolStripDropDownItem toolStripDropDownItem: SetStatusbarText(text: toolStripDropDownItem.AccessibleDescription); break;
				case ToolStripProgressBar progressBar: SetStatusbarText(text: progressBar.AccessibleDescription); break;
				case ToolStripSeparator toolStripSeparator: SetStatusbarText(text: toolStripSeparator.AccessibleDescription); break;
				case ToolStripTextBox toolStripTextBox: SetStatusbarText(text: toolStripTextBox.AccessibleDescription); break;
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clear the text of the information label in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusLabel_Leave(object sender, EventArgs e) => SetStatusbarText(text: string.Empty);

		#endregion

		#region Click event handlers

		/// <summary>
		/// Select a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSelectFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = openFileDialog.FileName;
				EnableAllControls();
			}
		}

		/// <summary>
		/// Select a folder
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSelectFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = folderBrowserDialog.SelectedPath;
				EnableAllControls();
			}
		}

		/// <summary>
		/// Apply the changes
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonApply_Click(object sender, EventArgs e)
		{
			DateTime
				creationTime = dateTimePickerWrited.Value,
				lastAccessTime = dateTimePickerWrited.Value,
				lastWriteTime = dateTimePickerWrited.Value;

			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);

			bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

			if (dateTimePickerCreated.Checked)
			{
				if (isFolder)
				{
					Directory.SetCreationTime(path: textBoxPath.Text, creationTime: creationTime);
				}
				else
				{
					File.SetCreationTime(path: textBoxPath.Text, creationTime: creationTime);
				}
			}

			if (dateTimePickerAccessed.Checked)
			{
				if (isFolder)
				{
					Directory.SetLastAccessTime(path: textBoxPath.Text, lastAccessTime: lastAccessTime);
				}
				else
				{
					File.SetLastAccessTime(path: textBoxPath.Text, lastAccessTime: lastAccessTime);
				}
			}

			if (dateTimePickerWrited.Checked)
			{
				if (isFolder)
				{
					Directory.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastAccessTime);
				}
				else
				{
					File.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastAccessTime);
				}
			}

			radioButtonCreationDateLocalTime.Checked = radioButtonNewCreationDateLocalTime.Checked;
			radioButtonCreationDateUtc.Checked = radioButtonNewCreationDateUtc.Checked;
			radioButtonLastAccessDateLocalTime.Checked = radioButtonNewLastAccessDateLocalTime.Checked;
			radioButtonLastAccessDateUtc.Checked = radioButtonNewLastAccessDateUtc.Checked;
			radioButtonLastWriteDateLocalTime.Checked = radioButtonNewLastWriteDateLocalTime.Checked;
			radioButtonLastWriteDateUtc.Checked = radioButtonNewLastWriteDateUtc.Checked;

			textBoxCreationDate.Text = radioButtonCreationDateLocalTime.Checked
				? isFolder
					? Directory.GetCreationTime(path: textBoxPath.Text).ToString()
					: File.GetCreationTime(path: textBoxPath.Text).ToString()
				: isFolder
					? Directory.GetCreationTimeUtc(path: textBoxPath.Text).ToString()
					: File.GetCreationTimeUtc(path: textBoxPath.Text).ToString();

			textBoxLastAccessDate.Text = radioButtonLastAccessDateLocalTime.Checked
				? isFolder
					? Directory.GetLastAccessTime(path: textBoxPath.Text).ToString()
					: File.GetLastAccessTime(path: textBoxPath.Text).ToString()
				: isFolder
					? Directory.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString()
					: File.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString();

			textBoxLastWriteDate.Text = radioButtonLastWriteDateLocalTime.Checked
				? isFolder
					? Directory.GetLastWriteTime(path: textBoxPath.Text).ToString()
					: File.GetLastWriteTime(path: textBoxPath.Text).ToString()
				: isFolder
					? Directory.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString()
					: File.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString();

			MessageBox.Show(text: "All dates has been changed!", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Open the information message
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			string message = $"{AssemblyInfo.AssemblyTitle} {AssemblyInfo.AssemblyVersion}\r\r\r{AssemblyInfo.AssemblyDescription}\r\r{AssemblyInfo.AssemblyCopyright}";
			MessageBox.Show(text: message, caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Close the application
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonClose_Click(object sender, EventArgs e) => Close();

		#endregion

		#region CheckedChanged-Eventhandler

		/// <summary>
		/// Show the date/time of the creation date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxCreationDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetCreationTime(path: textBoxPath.Text).ToString()
				: File.GetCreationTime(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the creation date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxCreationDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetCreationTimeUtc(path: textBoxPath.Text).ToString()
				: File.GetCreationTimeUtc(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the last write date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxLastAccessDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetLastAccessTime(path: textBoxPath.Text).ToString()
				: File.GetLastAccessTime(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the last access date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxLastAccessDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString()
				: File.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the last write date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxLastWriteDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetLastWriteTime(path: textBoxPath.Text).ToString()
				: File.GetLastWriteTime(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the last write date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			textBoxLastWriteDate.Text = (attr & FileAttributes.Directory) == FileAttributes.Directory
				? Directory.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString()
				: File.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString();
		}

		/// <summary>
		/// Show the date/time of the new creation date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToLocalTime();

		/// <summary>
		/// Show the date/time of the last creation date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewCreationDateUtc_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToUniversalTime();

		/// <summary>
		/// Show the date/time of the new last access date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToLocalTime();

		/// <summary>
		/// Show the date/time of the new last access date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToUniversalTime();

		/// <summary>
		/// Show the date/time of the new last write date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToLocalTime();

		/// <summary>
		/// Show the date/time of the new last write date in universal time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
			=> dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToUniversalTime();

		#endregion

		#region Drag'n'Drop

		/// <summary>
		/// Drag a file/folder over the application
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void FdtmForm_DragOver(object sender, DragEventArgs e)
		{
			toolStripStatusLabelInformation.Text = "Drag and drop a file or a folder in this window";
			e.Effect = e.Data.GetDataPresent(format: DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
		}

		/// <summary>
		/// Drop file/folder over the application
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		private void FdtmForm_DragDrop(object sender, DragEventArgs e)
		{
			// get all files droppeds
			if (e.Data.GetData(format: DataFormats.FileDrop, autoConvert: false) is string[] files)
			{
				textBoxPath.Text = files[0]; //select the first one
				EnableAllControls();
				buttonApply.Enabled = true;
				//foreach (string file in files) this.label.Text += File + "\n";
			}
		}

		#endregion
	}
}
