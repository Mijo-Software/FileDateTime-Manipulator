using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FileDateTime_Manipulator
{
	public partial class FdtmForm : Form
	{
		#region Assemblyattributaccessoren

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyTitle()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyTitleAttribute), inherit: false);
			if (attributes.Length > 0)
			{
				AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
				if (titleAttribute.Title != "")
				{
					return titleAttribute.Title;
				}
			}
			return System.IO.Path.GetFileNameWithoutExtension(path: Assembly.GetExecutingAssembly().CodeBase);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyVersion() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyDescription()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyDescriptionAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyDescriptionAttribute)attributes[0]).Description;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyProduct()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyProductAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyProductAttribute)attributes[0]).Product;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyCopyright()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCopyrightAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public string GetAssemblyCompany()
		{
			object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(attributeType: typeof(AssemblyCompanyAttribute), inherit: false);
			if (attributes.Length == 0)
			{
				return "";
			}
			return ((AssemblyCompanyAttribute)attributes[0]).Company;
		}
		#endregion

		public FdtmForm()
		{
			InitializeComponent();
		}

		private void FdtmForm_Load(object sender, EventArgs e)
		{
			dateTimePickerCreated.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerAccessed.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
			dateTimePickerWrited.CustomFormat = Application.CurrentCulture.DateTimeFormat.RFC1123Pattern;
		}

		#region Click-Eventhandler

		private void ButtonSelectFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxPath.Text = openFileDialog.FileName;
				RadioButtonCreationDateLocalTime_CheckedChanged(sender: sender, e: e);
				RadioButtonLastAccessDateLocalTime_CheckedChanged(sender: sender, e: e);
				RadioButtonLastWriteDateLocalTime_CheckedChanged(sender: sender, e: e);

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
		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			DateTime
				creationTime = dateTimePickerWrited.Value,
				lastAccessTime = dateTimePickerWrited.Value,
				lastWriteTime = dateTimePickerWrited.Value;

			if (dateTimePickerCreated.Checked) File.SetCreationTime(path: textBoxPath.Text, creationTime: creationTime);
			if (dateTimePickerAccessed.Checked) File.SetLastAccessTime(path: textBoxPath.Text, lastAccessTime: lastAccessTime);
			if (dateTimePickerWrited.Checked) File.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastWriteTime);

			radioButtonCreationDateLocalTime.Checked = radioButtonNewCreationDateLocalTime.Checked;
			radioButtonCreationDateUtc.Checked = radioButtonNewCreationDateUtc.Checked;
			radioButtonLastAccessDateLocalTime.Checked = radioButtonNewLastAccessDateLocalTime.Checked;
			radioButtonLastAccessDateUtc.Checked = radioButtonNewLastAccessDateUtc.Checked;
			radioButtonLastWriteDateLocalTime.Checked = radioButtonNewLastWriteDateLocalTime.Checked;
			radioButtonLastWriteDateUtc.Checked = radioButtonNewLastWriteDateUtc.Checked;

			if (radioButtonCreationDateLocalTime.Checked)
			{
				textBoxCreationDate.Text = File.GetCreationTime(path: textBoxPath.Text).ToString();
			}
			else
			{
				textBoxCreationDate.Text = File.GetCreationTimeUtc(path: textBoxPath.Text).ToString();
			}

			if (radioButtonLastAccessDateLocalTime.Checked)
			{
				textBoxLastAccessDate.Text = File.GetLastAccessTime(path: textBoxPath.Text).ToString();
			}
			else
			{
				textBoxLastAccessDate.Text = File.GetLastAccessTimeUtc(path: textBoxPath.Text).ToString();
			}

			if (radioButtonLastWriteDateLocalTime.Checked)
			{
				textBoxLastWriteDate.Text = File.GetLastWriteTime(path: textBoxPath.Text).ToString();
			}
			else
			{
				textBoxLastWriteDate.Text = File.GetLastWriteTimeUtc(path: textBoxPath.Text).ToString();
			}

			MessageBox.Show(text: "All dates has been changed!", caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void ButtonInfo_Click(object sender, EventArgs e)
		{
			string message = GetAssemblyTitle() + " " + GetAssemblyVersion() + "\r\r\r" + GetAssemblyDescription() + "\r\r" + GetAssemblyCopyright();
			MessageBox.Show(text: message, caption: "Information", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
		}

		private void ButtonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region CheckedChanged-Eventhandler

		private void RadioButtonCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			textBoxCreationDate.Text = File.GetCreationTime(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			textBoxCreationDate.Text = File.GetCreationTimeUtc(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			textBoxLastAccessDate.Text = File.GetLastAccessTime(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			textBoxLastAccessDate.Text = File.GetLastAccessTimeUtc(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			textBoxLastWriteDate.Text = File.GetLastWriteTime(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			textBoxLastWriteDate.Text = File.GetLastWriteTimeUtc(path: openFileDialog.FileName).ToString();
		}

		private void RadioButtonNewCreationDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToLocalTime();
		}

		private void RadioButtonNewCreationDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerCreated.Value = dateTimePickerCreated.Value.ToUniversalTime();
		}

		private void RadioButtonNewLastAccessDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToLocalTime();
		}

		private void RadioButtonNewLastAccessDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerAccessed.Value = dateTimePickerAccessed.Value.ToUniversalTime();
		}

		private void RadioButtonNewLastWriteDateLocalTime_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToLocalTime();
		}

		private void RadioButtonNewLastWriteDateUtc_CheckedChanged(object sender, EventArgs e)
		{
			dateTimePickerWrited.Value = dateTimePickerWrited.Value.ToUniversalTime();
		}

		#endregion

		private void SetStatusLabelForTextBox(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((TextBox)sender).AccessibleDescription;
		}

		private void SetStatusLabelForButton(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((Button)sender).AccessibleDescription;
		}

		private void SetStatusLabelForRadioButton(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((RadioButton)sender).AccessibleDescription;
		}

		private void SetStatusLabelForDateTimePicker(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((DateTimePicker)sender).AccessibleDescription;
		}

		private void SetStatusLabelForLabel(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = ((Label)sender).AccessibleDescription;
		}

		private void ClearStatusLabel(object sender, EventArgs e)
		{
			toolStripStatusLabel.Text = String.Empty;
		}

	}
}
