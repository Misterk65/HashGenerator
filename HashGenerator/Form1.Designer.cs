namespace HashGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusfilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelVer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCheck = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxOriginalFile = new System.Windows.Forms.GroupBox();
            this.lblOrgFile = new System.Windows.Forms.Label();
            this.btnCopyToClipSha = new System.Windows.Forms.Button();
            this.btnCopyToClipMd5 = new System.Windows.Forms.Button();
            this.txtSha256 = new System.Windows.Forms.TextBox();
            this.lblSha256 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.lblMd5 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpBoxFileToCheck = new System.Windows.Forms.GroupBox();
            this.btnShatoCompareToClip = new System.Windows.Forms.Button();
            this.btnMd5toCompareToClip = new System.Windows.Forms.Button();
            this.txtShaToCompare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMD5ToCompare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileToCompare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfileToCompare = new System.Windows.Forms.Button();
            this.chkBoxFileCheckEnable = new System.Windows.Forms.CheckBox();
            this.lblFileToComparePath = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.groupBoxOriginalFile.SuspendLayout();
            this.grpBoxFileToCheck.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = " | ";
            // 
            // toolStripStatusfilePath
            // 
            this.toolStripStatusfilePath.Name = "toolStripStatusfilePath";
            this.toolStripStatusfilePath.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelVer,
            this.toolStripStatusLabel1,
            this.toolStripStatusfilePath,
            this.toolStripStatusLabel2,
            this.toolStripStatusCheck});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVer
            // 
            this.toolStripStatusLabelVer.Name = "toolStripStatusLabelVer";
            this.toolStripStatusLabelVer.Size = new System.Drawing.Size(46, 17);
            this.toolStripStatusLabelVer.Text = "Version";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusCheck
            // 
            this.toolStripStatusCheck.Name = "toolStripStatusCheck";
            this.toolStripStatusCheck.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusCheck.Text = "None";
            // 
            // groupBoxOriginalFile
            // 
            this.groupBoxOriginalFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOriginalFile.Controls.Add(this.lblOrgFile);
            this.groupBoxOriginalFile.Controls.Add(this.btnCopyToClipSha);
            this.groupBoxOriginalFile.Controls.Add(this.btnCopyToClipMd5);
            this.groupBoxOriginalFile.Controls.Add(this.txtSha256);
            this.groupBoxOriginalFile.Controls.Add(this.lblSha256);
            this.groupBoxOriginalFile.Controls.Add(this.txtMd5);
            this.groupBoxOriginalFile.Controls.Add(this.lblMd5);
            this.groupBoxOriginalFile.Controls.Add(this.txtFile);
            this.groupBoxOriginalFile.Controls.Add(this.lblFile);
            this.groupBoxOriginalFile.Controls.Add(this.btnOpenFile);
            this.groupBoxOriginalFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOriginalFile.Location = new System.Drawing.Point(12, 33);
            this.groupBoxOriginalFile.Name = "groupBoxOriginalFile";
            this.groupBoxOriginalFile.Size = new System.Drawing.Size(560, 140);
            this.groupBoxOriginalFile.TabIndex = 12;
            this.groupBoxOriginalFile.TabStop = false;
            this.groupBoxOriginalFile.Text = "Original File";
            // 
            // lblOrgFile
            // 
            this.lblOrgFile.AutoSize = true;
            this.lblOrgFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrgFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrgFile.Location = new System.Drawing.Point(63, 110);
            this.lblOrgFile.MaximumSize = new System.Drawing.Size(376, 15);
            this.lblOrgFile.MinimumSize = new System.Drawing.Size(376, 15);
            this.lblOrgFile.Name = "lblOrgFile";
            this.lblOrgFile.Size = new System.Drawing.Size(376, 15);
            this.lblOrgFile.TabIndex = 21;
            this.lblOrgFile.Text = "label4";
            this.lblOrgFile.MouseHover += new System.EventHandler(this.lblOrgFile_MouseHover);
            // 
            // btnCopyToClipSha
            // 
            this.btnCopyToClipSha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipSha.Location = new System.Drawing.Point(445, 82);
            this.btnCopyToClipSha.Name = "btnCopyToClipSha";
            this.btnCopyToClipSha.Size = new System.Drawing.Size(107, 23);
            this.btnCopyToClipSha.TabIndex = 20;
            this.btnCopyToClipSha.Text = "&SHA To Clipboard";
            this.btnCopyToClipSha.UseVisualStyleBackColor = true;
            this.btnCopyToClipSha.Click += new System.EventHandler(this.btnCopyToClipSha_Click_1);
            // 
            // btnCopyToClipMd5
            // 
            this.btnCopyToClipMd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipMd5.Location = new System.Drawing.Point(445, 56);
            this.btnCopyToClipMd5.Name = "btnCopyToClipMd5";
            this.btnCopyToClipMd5.Size = new System.Drawing.Size(107, 23);
            this.btnCopyToClipMd5.TabIndex = 19;
            this.btnCopyToClipMd5.Text = "&MD 5 To Clipboard";
            this.btnCopyToClipMd5.UseVisualStyleBackColor = true;
            this.btnCopyToClipMd5.Click += new System.EventHandler(this.btnCopyToClipMd5_Click_1);
            // 
            // txtSha256
            // 
            this.txtSha256.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSha256.Location = new System.Drawing.Point(63, 82);
            this.txtSha256.Name = "txtSha256";
            this.txtSha256.Size = new System.Drawing.Size(376, 20);
            this.txtSha256.TabIndex = 18;
            // 
            // lblSha256
            // 
            this.lblSha256.AutoSize = true;
            this.lblSha256.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSha256.Location = new System.Drawing.Point(9, 82);
            this.lblSha256.Name = "lblSha256";
            this.lblSha256.Size = new System.Drawing.Size(47, 13);
            this.lblSha256.TabIndex = 17;
            this.lblSha256.Text = "SHA256";
            // 
            // txtMd5
            // 
            this.txtMd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMd5.Location = new System.Drawing.Point(63, 56);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.Size = new System.Drawing.Size(376, 20);
            this.txtMd5.TabIndex = 16;
            // 
            // lblMd5
            // 
            this.lblMd5.AutoSize = true;
            this.lblMd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMd5.Location = new System.Drawing.Point(9, 56);
            this.lblMd5.Name = "lblMd5";
            this.lblMd5.Size = new System.Drawing.Size(30, 13);
            this.lblMd5.TabIndex = 15;
            this.lblMd5.Text = "MD5";
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(63, 30);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(376, 20);
            this.txtFile.TabIndex = 14;
            this.txtFile.TextChanged += new System.EventHandler(this.txtFile_TextChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFile.Location = new System.Drawing.Point(9, 30);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 13;
            this.lblFile.Text = "File";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.AutoSize = true;
            this.btnOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpenFile.Location = new System.Drawing.Point(445, 30);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(29, 23);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(497, 363);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // grpBoxFileToCheck
            // 
            this.grpBoxFileToCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxFileToCheck.Controls.Add(this.lblFileToComparePath);
            this.grpBoxFileToCheck.Controls.Add(this.btnShatoCompareToClip);
            this.grpBoxFileToCheck.Controls.Add(this.btnMd5toCompareToClip);
            this.grpBoxFileToCheck.Controls.Add(this.txtShaToCompare);
            this.grpBoxFileToCheck.Controls.Add(this.label1);
            this.grpBoxFileToCheck.Controls.Add(this.txtMD5ToCompare);
            this.grpBoxFileToCheck.Controls.Add(this.label2);
            this.grpBoxFileToCheck.Controls.Add(this.txtFileToCompare);
            this.grpBoxFileToCheck.Controls.Add(this.label3);
            this.grpBoxFileToCheck.Controls.Add(this.btnfileToCompare);
            this.grpBoxFileToCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxFileToCheck.Location = new System.Drawing.Point(12, 209);
            this.grpBoxFileToCheck.Name = "grpBoxFileToCheck";
            this.grpBoxFileToCheck.Size = new System.Drawing.Size(560, 140);
            this.grpBoxFileToCheck.TabIndex = 13;
            this.grpBoxFileToCheck.TabStop = false;
            this.grpBoxFileToCheck.Text = "File to check";
            // 
            // btnShatoCompareToClip
            // 
            this.btnShatoCompareToClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShatoCompareToClip.Location = new System.Drawing.Point(445, 82);
            this.btnShatoCompareToClip.Name = "btnShatoCompareToClip";
            this.btnShatoCompareToClip.Size = new System.Drawing.Size(107, 23);
            this.btnShatoCompareToClip.TabIndex = 20;
            this.btnShatoCompareToClip.Text = "S&HA To Clipboard";
            this.btnShatoCompareToClip.UseVisualStyleBackColor = true;
            this.btnShatoCompareToClip.Click += new System.EventHandler(this.btnShatoCompareToClip_Click);
            // 
            // btnMd5toCompareToClip
            // 
            this.btnMd5toCompareToClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMd5toCompareToClip.Location = new System.Drawing.Point(445, 56);
            this.btnMd5toCompareToClip.Name = "btnMd5toCompareToClip";
            this.btnMd5toCompareToClip.Size = new System.Drawing.Size(107, 23);
            this.btnMd5toCompareToClip.TabIndex = 19;
            this.btnMd5toCompareToClip.Text = "M&D 5 To Clipboard";
            this.btnMd5toCompareToClip.UseVisualStyleBackColor = true;
            this.btnMd5toCompareToClip.Click += new System.EventHandler(this.btnMd5toCompareToClip_Click);
            // 
            // txtShaToCompare
            // 
            this.txtShaToCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShaToCompare.Location = new System.Drawing.Point(63, 82);
            this.txtShaToCompare.Name = "txtShaToCompare";
            this.txtShaToCompare.Size = new System.Drawing.Size(376, 20);
            this.txtShaToCompare.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "SHA256";
            // 
            // txtMD5ToCompare
            // 
            this.txtMD5ToCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMD5ToCompare.Location = new System.Drawing.Point(63, 56);
            this.txtMD5ToCompare.Name = "txtMD5ToCompare";
            this.txtMD5ToCompare.Size = new System.Drawing.Size(376, 20);
            this.txtMD5ToCompare.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "MD5";
            // 
            // txtFileToCompare
            // 
            this.txtFileToCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileToCompare.Location = new System.Drawing.Point(63, 30);
            this.txtFileToCompare.Name = "txtFileToCompare";
            this.txtFileToCompare.Size = new System.Drawing.Size(376, 20);
            this.txtFileToCompare.TabIndex = 14;
            this.txtFileToCompare.TextChanged += new System.EventHandler(this.txtFileToCompare_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "File";
            // 
            // btnfileToCompare
            // 
            this.btnfileToCompare.AutoSize = true;
            this.btnfileToCompare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnfileToCompare.Location = new System.Drawing.Point(445, 30);
            this.btnfileToCompare.Name = "btnfileToCompare";
            this.btnfileToCompare.Size = new System.Drawing.Size(29, 23);
            this.btnfileToCompare.TabIndex = 11;
            this.btnfileToCompare.Text = "...";
            this.btnfileToCompare.UseVisualStyleBackColor = true;
            this.btnfileToCompare.Click += new System.EventHandler(this.button4_Click);
            // 
            // chkBoxFileCheckEnable
            // 
            this.chkBoxFileCheckEnable.AutoSize = true;
            this.chkBoxFileCheckEnable.Location = new System.Drawing.Point(24, 182);
            this.chkBoxFileCheckEnable.Name = "chkBoxFileCheckEnable";
            this.chkBoxFileCheckEnable.Size = new System.Drawing.Size(111, 17);
            this.chkBoxFileCheckEnable.TabIndex = 14;
            this.chkBoxFileCheckEnable.Text = "&Enable File check";
            this.chkBoxFileCheckEnable.UseVisualStyleBackColor = true;
            this.chkBoxFileCheckEnable.CheckedChanged += new System.EventHandler(this.chkBoxFileCheckEnable_CheckedChanged);
            // 
            // lblFileToComparePath
            // 
            this.lblFileToComparePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileToComparePath.AutoSize = true;
            this.lblFileToComparePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFileToComparePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileToComparePath.Location = new System.Drawing.Point(63, 112);
            this.lblFileToComparePath.MinimumSize = new System.Drawing.Size(376, 15);
            this.lblFileToComparePath.Name = "lblFileToComparePath";
            this.lblFileToComparePath.Size = new System.Drawing.Size(376, 15);
            this.lblFileToComparePath.TabIndex = 22;
            this.lblFileToComparePath.Text = "label4";
            this.lblFileToComparePath.MouseHover += new System.EventHandler(this.lblFileToComparePath_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeApplicationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.closeApplicationToolStripMenuItem.Text = "Close &Application";
            this.closeApplicationToolStripMenuItem.Click += new System.EventHandler(this.closeApplicationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.chkBoxFileCheckEnable);
            this.Controls.Add(this.grpBoxFileToCheck);
            this.Controls.Add(this.groupBoxOriginalFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnCalculate);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 460);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxOriginalFile.ResumeLayout(false);
            this.groupBoxOriginalFile.PerformLayout();
            this.grpBoxFileToCheck.ResumeLayout(false);
            this.grpBoxFileToCheck.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusfilePath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBoxOriginalFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCheck;
        private System.Windows.Forms.Button btnCopyToClipSha;
        private System.Windows.Forms.Button btnCopyToClipMd5;
        private System.Windows.Forms.TextBox txtSha256;
        private System.Windows.Forms.Label lblSha256;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Label lblMd5;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpBoxFileToCheck;
        private System.Windows.Forms.Button btnShatoCompareToClip;
        private System.Windows.Forms.Button btnMd5toCompareToClip;
        private System.Windows.Forms.TextBox txtShaToCompare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMD5ToCompare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileToCompare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfileToCompare;
        private System.Windows.Forms.CheckBox chkBoxFileCheckEnable;
        private System.Windows.Forms.Label lblOrgFile;
        private System.Windows.Forms.Label lblFileToComparePath;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

