using FileDateTimeManipulator.Properties;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FileDateTimeManipulator
{
	/// <summary>
	/// Main Window
	/// </summary>
	public partial class FdtmForm : Form
	{
		private readonly Settings settings = new Settings();

		/// <summary>
		/// culture info for the date
		/// </summary>
		private readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		/// <summary>
		/// Selected date
		/// </summary>
		private byte selectedDate = 0;

		/// <summary>
		/// Enumation of selected date
		/// </summary>
		private enum SelectedDate
		{
			Created = 1, Accessed, Writed
		}

		#region Local methods

		/// <summary>
		/// detect if the disk object is a folder or not
		/// </summary>
		/// <param name="path">Path of the disk object</param>
		/// <returns></returns>
		private static bool IsFolder(string path) => File.GetAttributes(path: path).HasFlag(flag: FileAttributes.Directory);

		//private static bool IsFile(string path) => !IsFolder(path: path);

		/// <summary>
		/// Copy to clipboard
		/// </summary>
		/// <param name="text">text</param>
		private void CopyToClipboard(string text)
		{
			Clipboard.SetText(text: text);
			MessageBox.Show(
				owner: this,
				text: StringResources.titleCopiedToClipboard,
				caption: StringResources.messageCopiedToClipboard,
				buttons: MessageBoxButtons.OK,
				icon: MessageBoxIcon.Information);
		}

		/// <summary>
		/// Add a fike or a folder to the list
		/// </summary>
		/// <param name="path">Path of the file or the folder</param>
		private void AddDiskObject(string path)
		{
			string fileOrFolder;
			byte stateImageIndex;
			if (File.GetAttributes(path: path).HasFlag(flag: FileAttributes.Directory))
			{
				stateImageIndex = 0;
				fileOrFolder = StringResources.folder;
			}
			else
			{
				stateImageIndex = 1;
				fileOrFolder = StringResources.file;
			}
			ListViewItem listViewItem = new ListViewItem(text: fileOrFolder)
			{
				ToolTipText = path,
				StateImageIndex = stateImageIndex
			};
			if (IsFolder(path: path))
			{
				DirectoryInfo folderInfo = new DirectoryInfo(path: path);
				listViewItem.SubItems.Add(text: folderInfo.Name);
				listViewItem.SubItems.Add(text: folderInfo.FullName);
				listViewItem.SubItems.Add(text: folderInfo.CreationTime.ToString(provider: culture));
				listViewItem.SubItems.Add(text: folderInfo.LastAccessTime.ToString(provider: culture));
				listViewItem.SubItems.Add(text: folderInfo.LastWriteTime.ToString(provider: culture));
			}
			else
			{
				FileInfo fileInfo = new FileInfo(fileName: path);
				listViewItem.SubItems.Add(text: fileInfo.Name);
				listViewItem.SubItems.Add(text: fileInfo.FullName);
				listViewItem.SubItems.Add(text: fileInfo.CreationTime.ToString(provider: culture));
				listViewItem.SubItems.Add(text: fileInfo.LastAccessTime.ToString(provider: culture));
				listViewItem.SubItems.Add(text: fileInfo.LastWriteTime.ToString(provider: culture));
			}
			listViewFoldersAndFiles.Items.Add(value: listViewItem);
		}

		/// <summary>
		/// Enable all disabled controls
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
			buttonRemoveItem.Enabled = true;
			if (listViewFoldersAndFiles.Items.Count > 0)
			{
				listViewFoldersAndFiles.Select();
				listViewFoldersAndFiles.Items[index: 0].Selected = true;
			}
		}

		/// <summary>
		/// Disable all disabled controls
		/// </summary>
		private void DisableAllControls()
		{
			radioButtonCreationDateLocalTime.Enabled = false;
			radioButtonCreationDateUtc.Enabled = false;
			radioButtonLastAccessDateLocalTime.Enabled = false;
			radioButtonLastAccessDateUtc.Enabled = false;
			radioButtonLastWriteDateLocalTime.Enabled = false;
			radioButtonLastWriteDateUtc.Enabled = false;
			radioButtonCreationDateLocalTime.Checked = false;
			radioButtonLastAccessDateLocalTime.Checked = false;
			radioButtonLastWriteDateLocalTime.Checked = false;
			labelNewCreationDate.Enabled = false;
			labelNewAccessDate.Enabled = false;
			labelNewWriteDate.Enabled = false;
			dateTimePickerCreated.Enabled = false;
			dateTimePickerAccessed.Enabled = false;
			dateTimePickerWrited.Enabled = false;
			radioButtonNewCreationDateLocalTime.Enabled = false;
			radioButtonNewCreationDateUtc.Enabled = false;
			radioButtonNewLastAccessDateLocalTime.Enabled = false;
			radioButtonNewLastAccessDateUtc.Enabled = false;
			radioButtonNewLastWriteDateLocalTime.Enabled = false;
			radioButtonNewLastWriteDateUtc.Enabled = false;
			buttonApply.Enabled = false;
			buttonRemoveItem.Enabled = false;
			textBoxPath.Text = string.Empty;
			textBoxCreationDate.Text = string.Empty;
			textBoxLastAccessDate.Text = string.Empty;
			textBoxLastWriteDate.Text = string.Empty;
		}

		#endregion

		#region Constructor and destructor

		/// <summary>
		/// Constructor
		/// </summary>
		public FdtmForm() => InitializeComponent();

		#endregion

		#region Form* event handler

		/// <summary>
		/// Load the main window
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void FdtmForm_Load(object sender, EventArgs e)
		{
			dateTimePickerCreated.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerAccessed.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerWrited.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			switch (settings.userIconSet)
			{
				default: case "fatcow": ToolStripMenuItemFatcowIcons_MouseEnter(sender: sender, e: EventArgs.Empty); break;
				case "fugue": ToolStripMenuItemFugueIcons_MouseEnter(sender: sender, e: EventArgs.Empty); break;
				case "silk": ToolStripMenuItemSilkIcons_MouseEnter(sender: sender, e: EventArgs.Empty); break;
			}
			buttonRemoveItem.Enabled = false;
		}

		#endregion

		#region CheckedChanged event handler

		/// <summary>
		/// Update the creation date in local time to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxCreationDate.Text = Directory.GetCreationTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxCreationDate.Text = File.GetCreationTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Update the creation date in UTC to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxCreationDate.Text = Directory.GetCreationTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxCreationDate.Text = File.GetCreationTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Update the last access date in local time to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxLastAccessDate.Text = Directory.GetLastAccessTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxLastAccessDate.Text = File.GetLastAccessTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Update the last access date in UTC to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxLastAccessDate.Text = Directory.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxLastAccessDate.Text = File.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Update the last write date in local time to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxLastWriteDate.Text = Directory.GetLastWriteTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxLastWriteDate.Text = File.GetLastWriteTime(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Update the last write date in UTC to show
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			FileAttributes attr = File.GetAttributes(path: textBoxPath.Text);
			switch (attr & FileAttributes.Directory)
			{
				case FileAttributes.Directory:
					textBoxLastWriteDate.Text = Directory.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
				default:
					textBoxLastWriteDate.Text = File.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
					break;
			}
		}

		/// <summary>
		/// Add a new creation date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewCreationDateLocalTime_CheckedChanged(object sender, EventArgs e) => dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToLocalTime();

		/// <summary>
		/// Add a new creation date in UTC
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewCreationDateUtc_CheckedChanged(object sender, EventArgs e) => dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToUniversalTime();

		/// <summary>
		/// Add a new last access date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e) => dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToLocalTime();

		/// <summary>
		/// Add a new last access date in UTC
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastAccessDateUtc_CheckedChanged(object sender, EventArgs e) => dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToUniversalTime();

		/// <summary>
		/// Add a new last write date in local time
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e) => dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToLocalTime();

		/// <summary>
		/// Add a new last write date in UTC
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void RadioButtonNewLastWriteDateUtc_CheckedChanged(object sender, EventArgs e) => dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToUniversalTime();

		#endregion

		#region Drag'n'Drop event handler

		/// <summary>
		/// Indicate the drag of drag'n'drop
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameter <paramref name="sender"/> is not needed, but must be indicated.</remarks>
		private void FdtmForm_DragOver(object sender, DragEventArgs e)
		{
			toolStripStatusLabel.Text = StringResources.dragAndDrop;
			if (e.Data.GetDataPresent(format: DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Link;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// <summary>
		/// Indicate the drop of drag'n'drop
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void FdtmForm_DragDrop(object sender, DragEventArgs e)
		{
			string[] diskObjects = (string[])e.Data.GetData(format: DataFormats.FileDrop, autoConvert: false);
			if (diskObjects != null)
			{
				textBoxPath.Text = diskObjects[0]; //select the first one
				foreach (string diskObject in diskObjects)
				{
					AddDiskObject(path: diskObject);
				}
				EnableAllControls();
				buttonApply.Enabled = true;
				//foreach (string file in files) this.label.Text += File + "\n";
			}
		}

		#endregion

		#region Click event handler

		/// <summary>
		/// Indicate to select a file
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSelectFiles_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = openFileDialog.FileName;
				foreach (string file in openFileDialog.FileNames)
				{
					AddDiskObject(path: file);
				}
				listViewFoldersAndFiles.Items[index: 0].Selected = true;
				EnableAllControls();
			}
		}

		/// <summary>
		/// Indicate to select a folder
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonSelectFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = folderBrowserDialog.SelectedPath;
				AddDiskObject(path: folderBrowserDialog.SelectedPath);
				listViewFoldersAndFiles.Items[index: 0].Selected = true;
				EnableAllControls();
			}
		}

		/// <summary>
		/// Remove selected files and folders
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonRemoveItem_Click(object sender, EventArgs e)
		{
			if (listViewFoldersAndFiles.SelectedItems.Count > 0)
			{
				int selectedIndex = listViewFoldersAndFiles.Items.IndexOf(listViewFoldersAndFiles.SelectedItems[index: 0]);
				listViewFoldersAndFiles.Items.Remove(item: listViewFoldersAndFiles.SelectedItems[index: 0]);
				if (selectedIndex >= listViewFoldersAndFiles.Items.Count)
				{
					selectedIndex = listViewFoldersAndFiles.Items.Count - 1;
				}
				if (listViewFoldersAndFiles.Items.Count > 0)
				{
					listViewFoldersAndFiles.Select();
					listViewFoldersAndFiles.Items[index: selectedIndex].Selected = true;
				}
			}
			if (listViewFoldersAndFiles.Items.Count <= 0)
			{
				DisableAllControls();
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
			DateTime creationTime = dateTimePickerWrited.Value;
			DateTime lastAccessTime = dateTimePickerWrited.Value;
			DateTime lastWriteTime = dateTimePickerWrited.Value;
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
					Directory.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastWriteTime);
				}
				else
				{
					File.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastWriteTime);
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
					? Directory.GetCreationTime(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetCreationTime(path: textBoxPath.Text).ToString(provider: culture)
				: isFolder
					? Directory.GetCreationTimeUtc(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetCreationTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
			textBoxLastAccessDate.Text = radioButtonLastAccessDateLocalTime.Checked
				? isFolder
					? Directory.GetLastAccessTime(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetLastAccessTime(path: textBoxPath.Text).ToString(provider: culture)
				: isFolder
					? Directory.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
			textBoxLastWriteDate.Text = radioButtonLastWriteDateLocalTime.Checked
				? isFolder
					? Directory.GetLastWriteTime(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetLastWriteTime(path: textBoxPath.Text).ToString(provider: culture)
				: isFolder
					? Directory.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString(provider: culture)
					: File.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString(provider: culture);
			MessageBox.Show(text: StringResources.allDataChanged, caption: StringResources.information, buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
		}

		/// <summary>
		/// Show the program information
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			using (AboutForm about = new AboutForm())
			{
				about.ShowDialog();
			}
		}

		/// <summary>
		/// Close the application
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ButtonClose_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Copy to clipboard for context menu of icon themes
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemCopyToClipboard_Click(object sender, EventArgs e)
		{
			switch (selectedDate)
			{
				case (byte)SelectedDate.Created:
					CopyToClipboard(text: dateTimePickerCreated.Text);
					break;
				case (byte)SelectedDate.Accessed:
					CopyToClipboard(text: dateTimePickerAccessed.Text);
					break;
				case (byte)SelectedDate.Writed:
					CopyToClipboard(text: dateTimePickerWrited.Text);
					break;
			}
		}

		#endregion

		#region Enter and MouseEnter event handler

		/// <summary>
		/// Set the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void SetStatusbar_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((Control)sender).AccessibleDescription;

		/// <summary>
		/// Set the information text of a ToolStripMenuItem in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>	
		private void SetStatusbarOfToolStripMenuItem_Enter(object sender, EventArgs e) => toolStripStatusLabel.Text = ((ToolStripMenuItem)sender).AccessibleDescription;

		/// <summary>
		/// Set the information text and select the creation date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		private void DateTimePickerCreated_Enter(object sender, EventArgs e)
		{
			selectedDate = (byte)SelectedDate.Created;
			SetStatusbar_Enter(sender: sender, e: e);
		}

		/// <summary>
		/// Set the information text and select the last access date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		private void DateTimePickerAccessed_Enter(object sender, EventArgs e)
		{
			selectedDate = (byte)SelectedDate.Accessed;
			SetStatusbar_Enter(sender: sender, e: e);
		}

		/// <summary>
		/// Set the information text and select the last write date
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		private void DateTimePickerWrited_Enter(object sender, EventArgs e)
		{
			selectedDate = (byte)SelectedDate.Writed;
			SetStatusbar_Enter(sender: sender, e: e);
		}

		/// <summary>
		/// Change the icon theme to Fatcow icons
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemFatcowIcons_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = toolStripMenuItemFatcowIcons.AccessibleDescription;
			buttonSelectFolders.Image = Resources.fatcow_folder_16;
			buttonRemoveItem.Image = Resources.fatcow_delete_16;
			buttonSelectFile.Image = Resources.fatcow_page_white_16;
			buttonClose.Image = Resources.fatcow_door_in_16;
			buttonInfo.Image = Resources.fatcow_information_16;
			buttonApply.Image = Resources.fatcow_tick_button_16;
			toolStripMenuItemCopyToClipboard.Image = Resources.fatcow_clipboard_empty_16;
			listViewFoldersAndFiles.StateImageList = imageListFatcow;
			toolStripMenuItemFatcowIcons.Checked = true;
			toolStripMenuItemFugueIcons.Checked = false;
			toolStripMenuItemSilkIcons.Checked = false;
			settings.userIconSet = "fatcow";
			settings.Save();
		}

		/// <summary>
		/// Change the icon theme to Fugue icons
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemFugueIcons_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = toolStripMenuItemFugueIcons.AccessibleDescription;
			buttonSelectFolders.Image = Resources.fugue_folder_horizontal_open_16;
			buttonRemoveItem.Image = Resources.fugue_minus_circle_16;
			buttonSelectFile.Image = Resources.fugue_document_16;
			buttonClose.Image = Resources.fugue_door_open_in_16;
			buttonInfo.Image = Resources.fugue_information_16;
			buttonApply.Image = Resources.fugue_tick_button_16;
			toolStripMenuItemCopyToClipboard.Image = Resources.fugue_clipboard_empty_16;
			listViewFoldersAndFiles.StateImageList = imageListFugue;
			toolStripMenuItemFatcowIcons.Checked = false;
			toolStripMenuItemFugueIcons.Checked = true;
			toolStripMenuItemSilkIcons.Checked = false;
			settings.userIconSet = "fugue";
			settings.Save();
		}

		/// <summary>
		/// Change the icon theme to Silk icons
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">drag event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ToolStripMenuItemSilkIcons_MouseEnter(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = toolStripMenuItemSilkIcons.AccessibleDescription;
			buttonSelectFolders.Image = Resources.silk_folder_16;
			buttonRemoveItem.Image = Resources.silk_delete_16;
			buttonSelectFile.Image = Resources.silk_page_white_16;
			buttonClose.Image = Resources.silk_door_in_16;
			buttonInfo.Image = Resources.silk_information_16;
			buttonApply.Image = Resources.silk_accept_16;
			toolStripMenuItemCopyToClipboard.Image = Resources.silk_clipboard_16;
			listViewFoldersAndFiles.StateImageList = imageListSilk;
			toolStripMenuItemFatcowIcons.Checked = false;
			toolStripMenuItemFugueIcons.Checked = false;
			toolStripMenuItemSilkIcons.Checked = true;
			settings.userIconSet = "silk";
			settings.Save();
		}

		#endregion

		#region Leave and MouseLeave event handler

		/// <summary>
		/// Clear the information text in the status bar
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void ClearStatusbar_Leave(object sender, EventArgs e) => toolStripStatusLabel.Text = string.Empty;

		#endregion

		private void ListViewFoldersAndFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewFoldersAndFiles.SelectedItems.Count == 1)
			{
				textBoxPath.Text = listViewFoldersAndFiles.SelectedItems[index: 0].GetSubItemAt(x: 1, y: 1).ToString();
			}
			else
			{
			}
		}
	}
}