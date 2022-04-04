
namespace WinForms.Forms
{
    partial class PortalForm
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
            this.linkLabelToControl = new System.Windows.Forms.LinkLabel();
            this.linkCalc = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelToControl
            // 
            this.linkLabelToControl.AutoSize = true;
            this.linkLabelToControl.Location = new System.Drawing.Point(15, 17);
            this.linkLabelToControl.Name = "linkLabelToControl";
            this.linkLabelToControl.Size = new System.Drawing.Size(166, 20);
            this.linkLabelToControl.TabIndex = 0;
            this.linkLabelToControl.TabStop = true;
            this.linkLabelToControl.Text = "Элементы управления";
            this.linkLabelToControl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelToControl_LinkClicked);
            // 
            // linkCalc
            // 
            this.linkCalc.AutoSize = true;
            this.linkCalc.Location = new System.Drawing.Point(15, 56);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(96, 20);
            this.linkCalc.TabIndex = 1;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Калькулятор";
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCalc_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 94);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Прогресс";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.linkCalc);
            this.Controls.Add(this.linkLabelToControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PortalForm";
            this.Text = "PortalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelToControl;
        private System.Windows.Forms.LinkLabel linkCalc;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}