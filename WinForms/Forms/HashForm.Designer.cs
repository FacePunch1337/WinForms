
namespace WinForms.Forms
{
    partial class HashForm
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
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxMD5 = new System.Windows.Forms.TextBox();
            this.buttonMD5 = new System.Windows.Forms.Button();
            this.buttonSHA1 = new System.Windows.Forms.Button();
            this.textBoxSHA1 = new System.Windows.Forms.TextBox();
            this.buttonSHA256 = new System.Windows.Forms.Button();
            this.textBoxSHA256 = new System.Windows.Forms.TextBox();
            this.buttonSHA384 = new System.Windows.Forms.Button();
            this.textBoxSHA384 = new System.Windows.Forms.TextBox();
            this.buttonSHA512 = new System.Windows.Forms.Button();
            this.textBoxSHA512 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSource
            // 
            this.textBoxSource.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSource.Location = new System.Drawing.Point(23, 23);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.Size = new System.Drawing.Size(898, 72);
            this.textBoxSource.TabIndex = 0;
            this.textBoxSource.Text = "Hello world";
            // 
            // textBoxMD5
            // 
            this.textBoxMD5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMD5.Location = new System.Drawing.Point(91, 98);
            this.textBoxMD5.Multiline = true;
            this.textBoxMD5.Name = "textBoxMD5";
            this.textBoxMD5.ReadOnly = true;
            this.textBoxMD5.Size = new System.Drawing.Size(830, 25);
            this.textBoxMD5.TabIndex = 1;
            // 
            // buttonMD5
            // 
            this.buttonMD5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMD5.Location = new System.Drawing.Point(23, 98);
            this.buttonMD5.Name = "buttonMD5";
            this.buttonMD5.Size = new System.Drawing.Size(62, 25);
            this.buttonMD5.TabIndex = 2;
            this.buttonMD5.Text = "MD5";
            this.buttonMD5.UseVisualStyleBackColor = true;
            this.buttonMD5.Click += new System.EventHandler(this.buttonMD5_Click);
            // 
            // buttonSHA1
            // 
            this.buttonSHA1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSHA1.Location = new System.Drawing.Point(23, 129);
            this.buttonSHA1.Name = "buttonSHA1";
            this.buttonSHA1.Size = new System.Drawing.Size(62, 25);
            this.buttonSHA1.TabIndex = 5;
            this.buttonSHA1.Text = "SHA1";
            this.buttonSHA1.UseVisualStyleBackColor = true;
            this.buttonSHA1.Click += new System.EventHandler(this.buttonSHA1_Click);
            // 
            // textBoxSHA1
            // 
            this.textBoxSHA1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA1.Location = new System.Drawing.Point(91, 129);
            this.textBoxSHA1.Name = "textBoxSHA1";
            this.textBoxSHA1.ReadOnly = true;
            this.textBoxSHA1.Size = new System.Drawing.Size(830, 22);
            this.textBoxSHA1.TabIndex = 4;
            // 
            // buttonSHA256
            // 
            this.buttonSHA256.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSHA256.Location = new System.Drawing.Point(23, 160);
            this.buttonSHA256.Name = "buttonSHA256";
            this.buttonSHA256.Size = new System.Drawing.Size(62, 25);
            this.buttonSHA256.TabIndex = 7;
            this.buttonSHA256.Text = "SHA256";
            this.buttonSHA256.UseVisualStyleBackColor = true;
            this.buttonSHA256.Click += new System.EventHandler(this.buttonSHA256_Click_1);
            // 
            // textBoxSHA256
            // 
            this.textBoxSHA256.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA256.Location = new System.Drawing.Point(91, 159);
            this.textBoxSHA256.Name = "textBoxSHA256";
            this.textBoxSHA256.ReadOnly = true;
            this.textBoxSHA256.Size = new System.Drawing.Size(830, 22);
            this.textBoxSHA256.TabIndex = 6;
            // 
            // buttonSHA384
            // 
            this.buttonSHA384.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSHA384.Location = new System.Drawing.Point(23, 191);
            this.buttonSHA384.Name = "buttonSHA384";
            this.buttonSHA384.Size = new System.Drawing.Size(62, 25);
            this.buttonSHA384.TabIndex = 9;
            this.buttonSHA384.Text = "SHA384";
            this.buttonSHA384.UseVisualStyleBackColor = true;
            this.buttonSHA384.Click += new System.EventHandler(this.buttonSHA384_Click);
            // 
            // textBoxSHA384
            // 
            this.textBoxSHA384.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA384.Location = new System.Drawing.Point(91, 191);
            this.textBoxSHA384.Name = "textBoxSHA384";
            this.textBoxSHA384.ReadOnly = true;
            this.textBoxSHA384.Size = new System.Drawing.Size(830, 22);
            this.textBoxSHA384.TabIndex = 8;
            // 
            // buttonSHA512
            // 
            this.buttonSHA512.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSHA512.Location = new System.Drawing.Point(23, 222);
            this.buttonSHA512.Name = "buttonSHA512";
            this.buttonSHA512.Size = new System.Drawing.Size(62, 25);
            this.buttonSHA512.TabIndex = 11;
            this.buttonSHA512.Text = "SHA512";
            this.buttonSHA512.UseVisualStyleBackColor = true;
            this.buttonSHA512.Click += new System.EventHandler(this.buttonSHA512_Click);
            // 
            // textBoxSHA512
            // 
            this.textBoxSHA512.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSHA512.Location = new System.Drawing.Point(91, 222);
            this.textBoxSHA512.Name = "textBoxSHA512";
            this.textBoxSHA512.ReadOnly = true;
            this.textBoxSHA512.Size = new System.Drawing.Size(830, 22);
            this.textBoxSHA512.TabIndex = 10;
            // 
            // HashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.buttonSHA512);
            this.Controls.Add(this.textBoxSHA512);
            this.Controls.Add(this.buttonSHA384);
            this.Controls.Add(this.textBoxSHA384);
            this.Controls.Add(this.buttonSHA256);
            this.Controls.Add(this.textBoxSHA256);
            this.Controls.Add(this.buttonSHA1);
            this.Controls.Add(this.textBoxSHA1);
            this.Controls.Add(this.buttonMD5);
            this.Controls.Add(this.textBoxMD5);
            this.Controls.Add(this.textBoxSource);
            this.Name = "HashForm";
            this.Text = "HashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxMD5;
        private System.Windows.Forms.Button buttonMD5;
        private System.Windows.Forms.Button buttonSHA1;
        private System.Windows.Forms.TextBox textBoxSHA1;
        private System.Windows.Forms.Button buttonSHA256;
        private System.Windows.Forms.TextBox textBoxSHA256;
        private System.Windows.Forms.Button buttonSHA384;
        private System.Windows.Forms.TextBox textBoxSHA384;
        private System.Windows.Forms.Button buttonSHA512;
        private System.Windows.Forms.TextBox textBoxSHA512;
    }
}