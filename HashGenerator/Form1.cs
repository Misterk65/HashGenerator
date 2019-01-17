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
        private string filePathToCompare = "Not Selected";
        private bool chkState = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Hash Generator";
            txtFile.Enabled = false;
            txtMd5.Enabled = false;
            txtSha256.Enabled = false;
            txtFileToCompare.Enabled = false;
            txtShaToCompare.Enabled = false;
            txtMD5ToCompare.Enabled = false;
            btnCalculate.Enabled = false;
            toolStripStatusLabelVer.Text = "Ver.: " + GetVersion();
            toolStripStatusCheck.Text = "";
            toolStripStatusLabel1.Visible = false;
            toolStripStatusLabel2.Visible = false;
            grpBoxFileToCheck.Enabled = false;
            chkBoxFileCheckEnable.Checked = false;
            lblOrgFile.Text = "File: " + filePath;
            lblFileToComparePath.Text = "";
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

        private byte[] GetHashMD5(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Md5.ComputeHash(stream);
            }
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
        
        private void btnCopyToClipMd5_Click_1(object sender, EventArgs e)
        {
            if (txtMd5.Text!=String.Empty)
            {
                Clipboard.SetText(txtMd5.Text); 
            }
            else if (txtFile.Text==String.Empty)
            {
                MessageBox.Show("MD5 not yet calculated, please select a file and calculate first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("MD5 not yet calculated, please click the calculate button first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCopyToClipSha_Click_1(object sender, EventArgs e)
        {
            if (txtSha256.Text != String.Empty)
            {
                Clipboard.SetText(txtSha256.Text);
            }
            else if (txtFile.Text == String.Empty)
            {
                MessageBox.Show("SHA256 not yet calculated, please select a file and calculate first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("SHA256 not yet calculated, please click the calculate button first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!chkBoxFileCheckEnable.Checked)
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
                else
                {
                    if (txtFileToCompare.Text != String.Empty)
                    {
                        txtMd5.Text = BytesToString(GetHashMD5(txtFile.Text));
                        txtSha256.Text = BytesToString(GetHashSha256(txtFile.Text));
                        txtMD5ToCompare.Text = BytesToString(GetHashMD5(txtFileToCompare.Text));
                        txtShaToCompare.Text = BytesToString(GetHashSha256(txtFileToCompare.Text));
                        compareTheFields();
                    }
                    else
                    {
                        MessageBox.Show("Please select a file to be hashed!", "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void compareTheFields()
        {
            toolStripStatusLabel1.Visible = true;
            toolStripStatusLabel2.Visible = true;

            if ((txtMd5.Text==txtMD5ToCompare.Text)&& (txtSha256.Text == txtShaToCompare.Text))
            {
                toolStripStatusCheck.BackColor = Color.Green;
                toolStripStatusCheck.ForeColor = Color.Yellow;
                toolStripStatusCheck.Text = "File is Authentic";
            }
            else
            {
                toolStripStatusCheck.BackColor = Color.Red;
                toolStripStatusCheck.ForeColor = Color.Yellow;
                toolStripStatusCheck.Text = "File is not Authentic";
            }
        }

        private void chkBoxFileCheckEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkState == false)
            {
                btnCalculate.Enabled = false;
                grpBoxFileToCheck.Enabled = true;
                chkState=true;
                lblFileToComparePath.Text = "File: " + filePathToCompare;
            }
            else
            {
                if (txtFile.Text!=String.Empty)
                {
                    btnCalculate.Enabled = true; 
                }
                else
                {
                    btnCalculate.Enabled = false;
                }

                grpBoxFileToCheck.Enabled = false;
                chkState=false;
                lblFileToComparePath.Text = "";
                txtFileToCompare.Text = "";
                resetGroup2Controls();
            }
        }

        private void lblOrgFile_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(lblOrgFile, filePath);
        }

        private void lblFileToComparePath_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.InitialDelay = 0;
            tt.ShowAlways = true;
            tt.SetToolTip(lblFileToComparePath, filePathToCompare);
        }


        private string SelectFile()
        {
            string Output = "";

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Zip files (*.zip)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    Output = openFileDialog.FileName;
                    
                }
            }

            return Output;
        }

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            resetGroup1Controls();
            filePath = SelectFile();
            txtFile.Text = filePath;
            lblOrgFile.Text = "File: " + filePath;

            if (filePath.Length >= 80)
            {
                string[] cropPath = filePath.Split('\\');
                lblOrgFile.Text = "File: " + cropPath[0] + "\\" +
                                  cropPath[1] + "\\" +
                                  cropPath[2] + "\\" +
                                  cropPath[3] + "\\...\\" +
                                  cropPath[cropPath.Length - 1];
            }

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resetGroup2Controls();
            filePathToCompare = SelectFile();
            txtFileToCompare.Text = filePathToCompare;
            lblFileToComparePath.Text = "File: " + filePathToCompare;

            if (filePath.Length >= 100)
            {
                string[] cropPath = filePathToCompare.Split('\\');
                lblFileToComparePath.Text = "File: " + cropPath[0] + "\\" +
                                            cropPath[1] + "\\" +
                                            cropPath[2] + "\\" +
                                            cropPath[3] + "\\...\\" +
                                            cropPath[cropPath.Length - 1];
            }


        }

        private void btnMd5toCompareToClip_Click(object sender, EventArgs e)
        {
            if (txtMD5ToCompare.Text != String.Empty)
            {
                Clipboard.SetText(txtMD5ToCompare.Text);
            }
            else if (txtFileToCompare.Text == String.Empty)
            {
                MessageBox.Show("MD5 not yet calculated, please select a file and calculate first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("MD5 not yet calculated, please click the calculate button first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShatoCompareToClip_Click(object sender, EventArgs e)
        {
            if (txtShaToCompare.Text != String.Empty)
            {
                Clipboard.SetText(txtShaToCompare.Text);
            }
            else if (txtFileToCompare.Text == String.Empty)
            {
                MessageBox.Show("SHA256 not yet calculated, please select a file and calculate first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("SHA256 not yet calculated, please click the calculate button first!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }

        private void txtFileToCompare_TextChanged(object sender, EventArgs e)
        {
            btnCalculate.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        
        }

        private void closeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void resetGroup1Controls()
        {
            txtMd5.Text = "";
            txtSha256.Text = "";
        }

        private void resetGroup2Controls()
        {
            txtMD5ToCompare.Text = "";
            txtShaToCompare.Text = "";
            toolStripStatusCheck.BackColor = default(Color);
            toolStripStatusCheck.ForeColor = default(Color);
            toolStripStatusCheck.Text = "";
            toolStripStatusLabel1.Visible = false;
            toolStripStatusLabel2.Visible = false;
        }
    }
}
