using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace FileDateTime_Manipulator
{
	public partial class FdtmForm : Form
	{
		private FileInfo fileInfo;

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
		}

		private void ButtonSelectFile_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				fileInfo = new FileInfo(fileName: openFileDialog.FileName);
				textBoxPath.Text = fileInfo.FullName;
				textBoxCreationDate.Text = fileInfo.CreationTime.ToString();
				textBoxLastAccessDate.Text = fileInfo.LastAccessTime.ToString();
				textBoxLastWriteDate.Text = fileInfo.LastWriteTime.ToString();

				numericUpDownCreationDateYear.Enabled = true;
				numericUpDownAccessDateYear.Enabled = true;
				numericUpDownWriteDateYear.Enabled = true;
				numericUpDownCreationDateMonth.Enabled = true;
				numericUpDownAccessDateMonth.Enabled = true;
				numericUpDownWriteDateMonth.Enabled = true;
				numericUpDownCreationDateDay.Enabled = true;
				numericUpDownAccessDateDay.Enabled = true;
				numericUpDownWriteDateDay.Enabled = true;
				numericUpDownCreationDateHour.Enabled = true;
				numericUpDownAccessDateHour.Enabled = true;
				numericUpDownWriteDateHour.Enabled = true;
				numericUpDownCreationDateMinute.Enabled = true;
				numericUpDownAccessDateMinute.Enabled = true;
				numericUpDownWriteDateMinute.Enabled = true;
				numericUpDownCreationDateSecond.Enabled = true;
				numericUpDownAccessDateSecond.Enabled = true;
				numericUpDownWriteDateSecond.Enabled = true;
				buttonApply.Enabled = true;

				numericUpDownCreationDateYear.Value = fileInfo.CreationTime.Year;
				numericUpDownAccessDateYear.Value = fileInfo.LastAccessTime.Year;
				numericUpDownWriteDateYear.Value = fileInfo.LastWriteTime.Year;
				numericUpDownCreationDateMonth.Value = fileInfo.CreationTime.Month;
				numericUpDownAccessDateMonth.Value = fileInfo.LastAccessTime.Month;
				numericUpDownWriteDateMonth.Value = fileInfo.LastWriteTime.Month;
				numericUpDownCreationDateDay.Value = fileInfo.CreationTime.Day;
				numericUpDownAccessDateDay.Value = fileInfo.LastAccessTime.Day;
				numericUpDownWriteDateDay.Value = fileInfo.LastWriteTime.Day;
				numericUpDownCreationDateHour.Value = fileInfo.CreationTime.Hour;
				numericUpDownAccessDateHour.Value = fileInfo.LastAccessTime.Hour;
				numericUpDownWriteDateHour.Value = fileInfo.LastWriteTime.Hour;
				numericUpDownCreationDateMinute.Value = fileInfo.CreationTime.Minute;
				numericUpDownAccessDateMinute.Value = fileInfo.LastAccessTime.Minute;
				numericUpDownWriteDateMinute.Value = fileInfo.LastWriteTime.Minute;
				numericUpDownCreationDateSecond.Value = fileInfo.CreationTime.Second;
				numericUpDownAccessDateSecond.Value = fileInfo.LastAccessTime.Second;
				numericUpDownWriteDateSecond.Value = fileInfo.LastWriteTime.Second;
			}
		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			DateTime creationTime = new DateTime(
				year: (int)numericUpDownCreationDateYear.Value,
				month: (int)numericUpDownCreationDateMonth.Value,
				day: (int)numericUpDownCreationDateDay.Value,
				hour: (int)numericUpDownCreationDateHour.Value,
				minute: (int)numericUpDownCreationDateMinute.Value,
				second: (int)numericUpDownCreationDateSecond.Value);

			DateTime lastAccessTime = new DateTime(
				year: (int)numericUpDownAccessDateYear.Value,
				month: (int)numericUpDownAccessDateMonth.Value,
				day: (int)numericUpDownAccessDateDay.Value,
				hour: (int)numericUpDownAccessDateHour.Value,
				minute: (int)numericUpDownAccessDateMinute.Value,
				second: (int)numericUpDownAccessDateSecond.Value);

			DateTime lastWriteTime = new DateTime(
				year: (int)numericUpDownWriteDateYear.Value,
				month: (int)numericUpDownWriteDateMonth.Value,
				day: (int)numericUpDownWriteDateDay.Value,
				hour: (int)numericUpDownWriteDateHour.Value,
				minute: (int)numericUpDownWriteDateMinute.Value,
				second: (int)numericUpDownWriteDateSecond.Value);

			File.SetCreationTime(path: fileInfo.FullName, creationTime: creationTime);
			File.SetLastAccessTime(path: fileInfo.FullName, lastAccessTime: lastAccessTime);
			File.SetLastWriteTime(path: fileInfo.FullName, lastWriteTime: lastWriteTime);

			fileInfo = new FileInfo(fileName: textBoxPath.Text);
			textBoxCreationDate.Text = fileInfo.CreationTime.ToString();
			textBoxLastAccessDate.Text = fileInfo.LastAccessTime.ToString();
			textBoxLastWriteDate.Text = fileInfo.LastWriteTime.ToString();

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
	}
}
