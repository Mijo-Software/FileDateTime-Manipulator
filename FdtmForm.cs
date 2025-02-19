using System.Diagnostics;
using NLog;

namespace FileDateTime_Manipulator
{
	/// <summary>
	/// FileDateTime Manipulator Form
	/// </summary>
	[DebuggerDisplay(value: $"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
	public partial class FdtmForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="FdtmForm"/> class.
		/// </summary>
		public FdtmForm()
		{
			try
			{
				InitializeComponent();
				this.KeyDown += new KeyEventHandler(FdtmForm_KeyDown);
				this.KeyPreview = true; // Ensures the form receives key events before the controls
				Logger.Info(message: "FdtmForm_KeyDown initialized");
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error during form initialization.", messageBox: "An error occurred during form initialization.");
			}
		}

		#endregion

		#region Helpers

		/// <summary>
		/// Get Debugger Display
		/// </summary>
		/// <returns>Return the debugger display</returns>
		private string GetDebuggerDisplay() => ToString();

		private static void ShowAndLogErrorMessage(Exception ex, string messageLogger, string messageBox)
		{
			Debug.WriteLine(value: ex);
			Logger.Error(exception: ex, message: messageLogger);
			_ = MessageBox.Show(text: messageBox, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Sets a specific text to the status bar
		/// </summary>
		/// <param name="text">The text with some information to display in the status bar</param>
		private void SetStatusbarText(string text)
		{
			try
			{
				toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
				toolStripStatusLabelInformation.Text = text;
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting status bar text.", messageBox: "An error occurred while setting the status bar text.");
			}
		}

		/// <summary>
		/// Enable all disabled controls after a adding a file or a folder
		/// </summary>
		private void EnableAllControls()
		{
			try
			{
				// Trigger CheckedChanged events
				RadioButtonCreationDateLocalTime_CheckedChanged(sender: this, e: EventArgs.Empty);
				RadioButtonLastAccessDateLocalTime_CheckedChanged(sender: this, e: EventArgs.Empty);
				RadioButtonLastWriteDateLocalTime_CheckedChanged(sender: this, e: EventArgs.Empty);

				// Enable radio buttons
				radioButtonCreationDateLocalTime.Enabled = true;
				radioButtonCreationDateUtc.Enabled = true;
				radioButtonLastAccessDateLocalTime.Enabled = true;
				radioButtonLastAccessDateUtc.Enabled = true;
				radioButtonLastWriteDateLocalTime.Enabled = true;
				radioButtonLastWriteDateUtc.Enabled = true;

				// Set default checked state
				radioButtonCreationDateLocalTime.Checked = true;
				radioButtonLastAccessDateLocalTime.Checked = true;
				radioButtonLastWriteDateLocalTime.Checked = true;

				// Enable labels
				labelNewCreationDate.Enabled = true;
				labelNewAccessDate.Enabled = true;
				labelNewWriteDate.Enabled = true;

				// Enable date pickers
				dateTimePickerCreated.Enabled = true;
				dateTimePickerAccessed.Enabled = true;
				dateTimePickerWrited.Enabled = true;

				// Enable new date radio buttons
				radioButtonNewCreationDateLocalTime.Enabled = true;
				radioButtonNewCreationDateUtc.Enabled = true;
				radioButtonNewLastAccessDateLocalTime.Enabled = true;
				radioButtonNewLastAccessDateUtc.Enabled = true;
				radioButtonNewLastWriteDateLocalTime.Enabled = true;
				radioButtonNewLastWriteDateUtc.Enabled = true;

				// Enable apply button
				buttonApply.Enabled = true;
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error enabling all controls.", messageBox: "An error occurred while enabling all controls.");
			}
		}

		/// <summary>
		/// Handles the Load event of the form
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data</param>
		private void FdtmForm_Load(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerCreated.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
				dateTimePickerAccessed.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
				dateTimePickerWrited.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error during form load.", messageBox: "An error occurred during form load.");
			}
		}

		#endregion

		#region Enter event handlers

		/// <summary>
		/// Called when the mouse pointer moves over a control
		/// </summary>
		/// <param name="sender">The event source</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
			{
				if (sender is Control { AccessibleDescription: { } } control)
				{
					SetStatusbarText(text: control.AccessibleDescription);
				}
				else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
				{
					SetStatusbarText(text: control2.AccessibleDescription);
				}
				else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
				{
					SetStatusbarText(text: control3.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting status bar text on enter.", messageBox: "An error occurred while setting the status bar text on enter.");
			}
		}

		#endregion

		#region Leave event handlers

		/// <summary>
		/// Clears the information text of the status bar
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ClearStatusBar_Leave(object sender, EventArgs e)
		{
			try
			{
				SetStatusbarText(text: string.Empty);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error clearing status bar text on leave.", messageBox: "An error occurred while clearing the status bar text on leave.");
			}
		}

		#endregion

		#region Click event handlers

		/// <summary>
		/// Selects a folder
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ButtonSelectFile_Click(object sender, EventArgs e)
		{
			try
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					textBoxPath.Text = openFileDialog.FileName;
					EnableAllControls();
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error selecting file.", messageBox: "An error occurred while selecting the file.");
			}
		}

		/// <summary>
		/// Selects a folder
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ButtonSelectFolder_Click(object sender, EventArgs e)
		{
			try
			{
				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					textBoxPath.Text = folderBrowserDialog.SelectedPath;
					EnableAllControls();
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error selecting folder.", messageBox: "An error occurred while selecting the folder.");
			}
		}

		/// <summary>
		/// Applies the changes
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ButtonApply_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime creationTime = dateTimePickerWrited.Value;
				DateTime lastAccessTime = dateTimePickerWrited.Value;
				DateTime lastWriteTime = dateTimePickerWrited.Value;

				string path = textBoxPath.Text;
				FileAttributes attr = File.GetAttributes(path);
				bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

				if (dateTimePickerCreated.Checked)
				{
					if (isFolder)
					{
						Directory.SetCreationTime(path, creationTime);
					}
					else
					{
						File.SetCreationTime(path, creationTime);
					}
				}

				if (dateTimePickerAccessed.Checked)
				{
					if (isFolder)
					{
						Directory.SetLastAccessTime(path, lastAccessTime);
					}
					else
					{
						File.SetLastAccessTime(path, lastAccessTime);
					}
				}

				if (dateTimePickerWrited.Checked)
				{
					if (isFolder)
					{
						Directory.SetLastWriteTime(path, lastWriteTime);
					}
					else
					{
						File.SetLastWriteTime(path, lastWriteTime);
					}
				}

				UpdateRadioButtonStates();
				UpdateTextBoxes(isFolder, path);

				_ = MessageBox.Show(text: "All dates have been changed!", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error applying changes.", messageBox: "An error occurred while applying the changes.");
			}
		}

		/// <summary>
		/// Updates the checked state of the radio buttons based on the new date settings.
		/// </summary>
		private void UpdateRadioButtonStates()
		{
			try
			{
				radioButtonCreationDateLocalTime.Checked = radioButtonNewCreationDateLocalTime.Checked;
				radioButtonCreationDateUtc.Checked = radioButtonNewCreationDateUtc.Checked;
				radioButtonLastAccessDateLocalTime.Checked = radioButtonNewLastAccessDateLocalTime.Checked;
				radioButtonLastAccessDateUtc.Checked = radioButtonNewLastAccessDateUtc.Checked;
				radioButtonLastWriteDateLocalTime.Checked = radioButtonNewLastWriteDateLocalTime.Checked;
				radioButtonLastWriteDateUtc.Checked = radioButtonNewLastWriteDateUtc.Checked;
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error updating radio button states.", messageBox: "An error occurred while updating the radio button states.");
			}
		}

		/// <summary>
		/// Updates the text boxes with the current date and time information.
		/// </summary>
		/// <param name="isFolder">Indicates whether the path is a folder.</param>
		/// <param name="path">The path of the file or folder.</param>
		private void UpdateTextBoxes(bool isFolder, string path)
		{
			try
			{
				textBoxCreationDate.Text = radioButtonCreationDateLocalTime.Checked
					? (isFolder ? Directory.GetCreationTime(path).ToString() : File.GetCreationTime(path).ToString())
					: (isFolder ? Directory.GetCreationTimeUtc(path).ToString() : File.GetCreationTimeUtc(path).ToString());

				textBoxLastAccessDate.Text = radioButtonLastAccessDateLocalTime.Checked
					? (isFolder ? Directory.GetLastAccessTime(path).ToString() : File.GetLastAccessTime(path).ToString())
					: (isFolder ? Directory.GetLastAccessTimeUtc(path).ToString() : File.GetLastAccessTimeUtc(path).ToString());

				textBoxLastWriteDate.Text = radioButtonLastWriteDateLocalTime.Checked
					? (isFolder ? Directory.GetLastWriteTime(path).ToString() : File.GetLastWriteTime(path).ToString())
					: (isFolder ? Directory.GetLastWriteTimeUtc(path).ToString() : File.GetLastWriteTimeUtc(path).ToString());
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error updating text boxes.", messageBox: "An error occurred while updating the text boxes.");
			}
		}

		/// <summary>
		/// Opens the information message
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			try
			{
				string message = $"{AssemblyInfo.AssemblyTitle} {AssemblyInfo.AssemblyVersion}\r\r\r{AssemblyInfo.AssemblyDescription}\r\r{AssemblyInfo.AssemblyCopyright}";
				_ = MessageBox.Show(text: message, caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error displaying information.", messageBox: "An error occurred while displaying the information.");
			}
		}

		/// <summary>
		/// Closes the application
		/// </summary>
		/// <param name="sender">The source of the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data</param>
		private void ButtonClose_Click(object sender, EventArgs e)
		{
			try
			{
				Close();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error closing the application.", messageBox: "An error occurred while closing the application.");
			}
		}

		#endregion

		#region CheckedChanged-Eventhandler

		/// <summary>
		/// Shows the date/time of the creation date in local time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxCreationDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetCreationTime, getFileTime: File.GetCreationTime);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting creation date in local time.", messageBox: "An error occurred while getting the creation date in local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the creation date in universal time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxCreationDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetCreationTimeUtc, getFileTime: File.GetCreationTimeUtc);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting creation date in universal time.", messageBox: "An error occurred while getting the creation date in universal time.");
			}
		}
		/// <summary>
		/// Shows the date/time of the last access date in local time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxLastAccessDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetLastAccessTime, getFileTime: File.GetLastAccessTime);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting last access date in local time.", messageBox: "An error occurred while getting the last access date in local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the last access date in universal time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxLastAccessDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetLastAccessTimeUtc, getFileTime: File.GetLastAccessTimeUtc);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting last access date in universal time.", messageBox: "An error occurred while getting the last access date in universal time.");
			}
		}
		/// <summary>
		/// Shows the date/time of the last write date in local time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxLastWriteDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetLastWriteTime, getFileTime: File.GetLastWriteTime);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting last write date in local time.", messageBox: "An error occurred while getting the last write date in local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the last write date in universal time.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxLastWriteDate.Text = GetFormattedDate(getDirectoryTime: Directory.GetLastWriteTimeUtc, getFileTime: File.GetLastWriteTimeUtc);
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting last write date in universal time.", messageBox: "An error occurred while getting the last write date in universal time.");
			}
		}

		/// <summary>
		/// Gets the formatted date based on whether the path is a directory or a file.
		/// </summary>
		/// <param name="getDirectoryTime">The function to get the date/time for a directory.</param>
		/// <param name="getFileTime">The function to get the date/time for a file.</param>
		/// <returns>The formatted date/time as a string.</returns>
		private string GetFormattedDate(Func<string, DateTime> getDirectoryTime, Func<string, DateTime> getFileTime)
		{
			try
			{
				string path = textBoxPath.Text;
				FileAttributes attr = File.GetAttributes(path);
				bool isFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;
				return isFolder ? getDirectoryTime(arg: path).ToString() : getFileTime(arg: path).ToString();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error getting formatted date.", messageBox: "An error occurred while getting the formatted date.");
				return string.Empty;
			}
		}

		/// <summary>
		/// Shows the date/time of the new creation date in local time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToLocalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new creation date to local time.", messageBox: "An error occurred while setting the new creation date to local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the last creation date in universal time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToUniversalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new creation date to universal time.", messageBox: "An error occurred while setting the new creation date to universal time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the new last access date in local time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToLocalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new last access date to local time.", messageBox: "An error occurred while setting the new last access date to local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the new last access date in universal time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToUniversalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new last access date to universal time.", messageBox: "An error occurred while setting the new last access date to universal time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the new last write date in local time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToLocalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new last write date to local time.", messageBox: "An error occurred while setting the new last write date to local time.");
			}
		}

		/// <summary>
		/// Shows the date/time of the new last write date in universal time
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void RadioButtonNewLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToUniversalTime();
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error setting new last write date to universal time.", messageBox: "An error occurred while setting the new last write date to universal time.");
			}
		}

		#endregion

		#region Drag'n'Drop

		/// <summary>
		/// Drags a file/folder over the application
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FdtmForm_DragOver(object sender, DragEventArgs e)
		{
			try
			{
				toolStripStatusLabelInformation.Text = "Drag and drop a file or a folder in this window";
				e.Effect = e.Data != null && e.Data.GetDataPresent(format: DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error during drag over.", messageBox: "An error occurred during drag over.");
			}
		}

		/// <summary>
		/// Drops file/folder over the application
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FdtmForm_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				// get all files dropped
				if (e.Data?.GetData(format: DataFormats.FileDrop, autoConvert: false) is string[] files)
				{
					textBoxPath.Text = files[0]; //select the first one
					EnableAllControls();
					buttonApply.Enabled = true;
					//foreach (string file in files) this.label.Text += File + "\n";
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error during drag over.", messageBox: "An error occurred during drag drop.");
			}
		}
		#endregion

		#region KeyDown event handler

		/// <summary>
		/// Handles the KeyDown event of the ExportDataSheetForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void FdtmForm_KeyDown(object? sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				ShowAndLogErrorMessage(ex, messageLogger: "Error handling KeyDown event.", messageBox: "An error occurred while handling the KeyDown event.");
			}
		}

		#endregion
	}
}