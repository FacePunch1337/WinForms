
namespace WinForms.Forms
{
    partial class CipherForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelSelectFile = new System.Windows.Forms.Label();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.buttonSelectSourceFile = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.buttonSelectTarget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTargetFileName = new System.Windows.Forms.TextBox();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.pictureBoxEye = new System.Windows.Forms.PictureBox();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.buttonCipherCancel = new System.Windows.Forms.Button();
            this.progressCipherBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.panelTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).BeginInit();
            this.panelProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSampleToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeSampleToolStripMenuItem
            // 
            this.makeSampleToolStripMenuItem.Name = "makeSampleToolStripMenuItem";
            this.makeSampleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.makeSampleToolStripMenuItem.Text = "Make sample";
            this.makeSampleToolStripMenuItem.Click += new System.EventHandler(this.makeSampleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelSelectFile
            // 
            this.labelSelectFile.AutoSize = true;
            this.labelSelectFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelectFile.Location = new System.Drawing.Point(12, 36);
            this.labelSelectFile.Name = "labelSelectFile";
            this.labelSelectFile.Size = new System.Drawing.Size(98, 14);
            this.labelSelectFile.TabIndex = 1;
            this.labelSelectFile.Text = "Select a file";
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(145, 32);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(100, 23);
            this.textBoxSourceFileName.TabIndex = 2;
            // 
            // buttonSelectSourceFile
            // 
            this.buttonSelectSourceFile.Location = new System.Drawing.Point(251, 32);
            this.buttonSelectSourceFile.Name = "buttonSelectSourceFile";
            this.buttonSelectSourceFile.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectSourceFile.TabIndex = 3;
            this.buttonSelectSourceFile.Text = "...";
            this.buttonSelectSourceFile.UseVisualStyleBackColor = true;
            this.buttonSelectSourceFile.Click += new System.EventHandler(this.buttonSelectSourceFile_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(145, 61);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(12, 64);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(119, 14);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Enter a password";
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(12, 104);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(62, 23);
            this.buttonCipher.TabIndex = 6;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // buttonSelectTarget
            // 
            this.buttonSelectTarget.Location = new System.Drawing.Point(209, 15);
            this.buttonSelectTarget.Name = "buttonSelectTarget";
            this.buttonSelectTarget.Size = new System.Drawing.Size(30, 23);
            this.buttonSelectTarget.TabIndex = 7;
            this.buttonSelectTarget.Text = "...";
            this.buttonSelectTarget.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Target";
            // 
            // textBoxTargetFileName
            // 
            this.textBoxTargetFileName.Location = new System.Drawing.Point(47, 15);
            this.textBoxTargetFileName.Name = "textBoxTargetFileName";
            this.textBoxTargetFileName.Size = new System.Drawing.Size(156, 23);
            this.textBoxTargetFileName.TabIndex = 9;
            // 
            // panelTarget
            // 
            this.panelTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTarget.Controls.Add(this.label1);
            this.panelTarget.Controls.Add(this.buttonSelectTarget);
            this.panelTarget.Controls.Add(this.textBoxTargetFileName);
            this.panelTarget.Location = new System.Drawing.Point(541, 33);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(247, 51);
            this.panelTarget.TabIndex = 10;
            // 
            // pictureBoxEye
            // 
            this.pictureBoxEye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEye.InitialImage = null;
            this.pictureBoxEye.Location = new System.Drawing.Point(251, 61);
            this.pictureBoxEye.Name = "pictureBoxEye";
            this.pictureBoxEye.Size = new System.Drawing.Size(28, 23);
            this.pictureBoxEye.TabIndex = 12;
            this.pictureBoxEye.TabStop = false;
            this.pictureBoxEye.Click += new System.EventHandler(this.pictureBoxEye_Click);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.buttonCipherCancel);
            this.panelProgress.Controls.Add(this.progressCipherBar);
            this.panelProgress.Location = new System.Drawing.Point(80, 104);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(199, 23);
            this.panelProgress.TabIndex = 13;
            // 
            // buttonCipherCancel
            // 
            this.buttonCipherCancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCipherCancel.Location = new System.Drawing.Point(171, 0);
            this.buttonCipherCancel.Name = "buttonCipherCancel";
            this.buttonCipherCancel.Size = new System.Drawing.Size(28, 23);
            this.buttonCipherCancel.TabIndex = 1;
            this.buttonCipherCancel.Text = "X";
            this.buttonCipherCancel.UseVisualStyleBackColor = true;
            this.buttonCipherCancel.Click += new System.EventHandler(this.buttonCipherCancel_Click);
            // 
            // progressCipherBar
            // 
            this.progressCipherBar.Location = new System.Drawing.Point(0, 0);
            this.progressCipherBar.Name = "progressCipherBar";
            this.progressCipherBar.Size = new System.Drawing.Size(165, 23);
            this.progressCipherBar.TabIndex = 0;
            // 
            // CipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.pictureBoxEye);
            this.Controls.Add(this.panelTarget);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonSelectSourceFile);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Controls.Add(this.labelSelectFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CipherForm";
            this.Text = "CipherForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CipherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEye)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelSelectFile;
        private System.Windows.Forms.TextBox textBoxSourceFileName;
        private System.Windows.Forms.Button buttonSelectSourceFile;
        private System.Windows.Forms.ToolStripMenuItem makeSampleToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCipher;
        private System.Windows.Forms.Button buttonSelectTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTargetFileName;
        private System.Windows.Forms.Panel panelTarget;
        private System.Windows.Forms.PictureBox pictureBoxEye;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Button buttonCipherCancel;
        private System.Windows.Forms.ProgressBar progressCipherBar;
    }
}