using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Security.Cryptography;

namespace HashGenerator
{
    public partial class Form1 : Form
    {
        // The cryptographic service provider.
        private SHA256 Sha256 = SHA256.Create();
        private MD5 Md5 = MD5.Create();
        private string filePath="Not Selected";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hash Generator";
            toolStripStatusfilePath.Text = filePath;
            txtMd5.Enabled = false;
            txtSha256.Enabled = false;
            toolStripStatusLabelVer.Text = "Ver.: " + GetVersion();
        }
        // Compute the file's hash.
        private byte[] GetHashSha256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }

        // Return a byte array as a sequence of hex values.
        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        // Compute the file's hash code.
        private void BtnHash_Click(object sender, EventArgs e)
        {
            
        }

        private byte[] GetHashMD5(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Md5.ComputeHash(stream);
            }
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            //var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Zip files (*.zip)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    txtFile.Text = openFileDialog.FileName;
                    toolStripStatusfilePath.Text = filePath;
                    
                    if (filePath.Length >= 100)
                    {
                        string[] cropPath=filePath.Split('\\');
                        toolStripStatusfilePath.Text = cropPath[0] + "\\" +
                                                       cropPath[1] + "\\...\\" + 
                                                       cropPath[cropPath.Length - 1];
                    }

                    /*Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }*/
                }
            }
        }

        private void StatusStrip1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(statusStrip1, filePath);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFile.Text != String.Empty)
                {
                    txtMd5.Text = BytesToString(GetHashMD5(txtFile.Text));
                    txtSha256.Text = BytesToString(GetHashSha256(txtFile.Text));
                }
                else
                {
                    MessageBox.Show("Please select a file to be hashed!", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopyToClipMd5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtMd5.Text);
        }

        private void btnCopyToClipSha_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSha256.Text);
        }

        private string GetVersion()
        {
            //Version Label
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            version = version.Substring(0, version.Length - 2);
            return version;
        }
    }
}
