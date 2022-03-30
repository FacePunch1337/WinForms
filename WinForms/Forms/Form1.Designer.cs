
namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDemo = new System.Windows.Forms.Label();
            this.checkBoxDemo = new System.Windows.Forms.CheckBox();
            this.listBoxDemo = new System.Windows.Forms.ListBox();
            this.textBoxDemo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Hello World";
            // 
            // buttonDemo
            // 
            this.buttonDemo.Location = new System.Drawing.Point(112, 77);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(75, 23);
            this.buttonDemo.TabIndex = 1;
            this.buttonDemo.Text = "PRESS";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кнопка(Button):";
            // 
            // labelDemo
            // 
            this.labelDemo.AutoSize = true;
            this.labelDemo.Location = new System.Drawing.Point(12, 113);
            this.labelDemo.Name = "labelDemo";
            this.labelDemo.Size = new System.Drawing.Size(54, 15);
            this.labelDemo.TabIndex = 3;
            this.labelDemo.Text = "Надпись";
            // 
            // checkBoxDemo
            // 
            this.checkBoxDemo.AutoSize = true;
            this.checkBoxDemo.Location = new System.Drawing.Point(12, 141);
            this.checkBoxDemo.Name = "checkBoxDemo";
            this.checkBoxDemo.Size = new System.Drawing.Size(133, 19);
            this.checkBoxDemo.TabIndex = 4;
            this.checkBoxDemo.Text = "получать рассылку";
            this.checkBoxDemo.UseVisualStyleBackColor = true;
            this.checkBoxDemo.CheckedChanged += new System.EventHandler(this.checkBoxDemo_CheckedChanged);
            // 
            // listBoxDemo
            // 
            this.listBoxDemo.FormattingEnabled = true;
            this.listBoxDemo.ItemHeight = 15;
            this.listBoxDemo.Location = new System.Drawing.Point(263, 82);
            this.listBoxDemo.Name = "listBoxDemo";
            this.listBoxDemo.Size = new System.Drawing.Size(512, 334);
            this.listBoxDemo.TabIndex = 5;
            // 
            // textBoxDemo
            // 
            this.textBoxDemo.Location = new System.Drawing.Point(263, 53);
            this.textBoxDemo.Name = "textBoxDemo";
            this.textBoxDemo.Size = new System.Drawing.Size(512, 23);
            this.textBoxDemo.TabIndex = 6;
            this.textBoxDemo.TextChanged += new System.EventHandler(this.textBoxDemo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxDemo);
            this.Controls.Add(this.listBoxDemo);
            this.Controls.Add(this.checkBoxDemo);
            this.Controls.Add(this.labelDemo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonDemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDemo;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.ListBox listBoxDemo;
        private System.Windows.Forms.TextBox textBoxDemo;
    }
}

