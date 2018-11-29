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
				textBoxPath.Text = openFileDialog.FileName;
				textBoxCreationDate.Text = File.GetCreationTime(path: openFileDialog.FileName).ToString();
				textBoxLastAccessDate.Text = File.GetLastAccessTime(path: openFileDialog.FileName).ToString();
				textBoxLastWriteDate.Text = File.GetLastWriteTime(path: openFileDialog.FileName).ToString();

				dateTimePickerCreated.Enabled = true;
				dateTimePickerAccessed.Enabled = true;
				dateTimePickerWrited.Enabled = true;
				buttonApply.Enabled = true;
			}
		}

		private void ButtonApply_Click(object sender, EventArgs e)
		{
			DateTime
				creationTime = dateTimePickerCreated.Value,
				lastAccessTime = dateTimePickerCreated.Value,
				lastWriteTime = dateTimePickerCreated.Value;

			if (dateTimePickerCreated.Checked) File.SetCreationTime(path: textBoxPath.Text, creationTime: creationTime);
			if (dateTimePickerAccessed.Checked) File.SetLastAccessTime(path: textBoxPath.Text, lastAccessTime: lastAccessTime);
			if (dateTimePickerWrited.Checked) File.SetLastWriteTime(path: textBoxPath.Text, lastWriteTime: lastWriteTime);

			textBoxCreationDate.Text = File.GetCreationTime(path: textBoxPath.Text).ToString();
			textBoxLastAccessDate.Text = File.GetLastAccessTime(path: textBoxPath.Text).ToString();
			textBoxLastWriteDate.Text = File.GetLastWriteTime(path: textBoxPath.Text).ToString();

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
