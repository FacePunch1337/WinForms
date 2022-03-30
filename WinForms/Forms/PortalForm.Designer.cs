
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
            this.SuspendLayout();
            // 
            // linkLabelToControl
            // 
            this.linkLabelToControl.AutoSize = true;
            this.linkLabelToControl.Location = new System.Drawing.Point(13, 13);
            this.linkLabelToControl.Name = "linkLabelToControl";
            this.linkLabelToControl.Size = new System.Drawing.Size(131, 15);
            this.linkLabelToControl.TabIndex = 0;
            this.linkLabelToControl.TabStop = true;
            this.linkLabelToControl.Text = "Элементы управления";
            this.linkLabelToControl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelToControl_LinkClicked);
            // 
            // linkCalc
            // 
            this.linkCalc.AutoSize = true;
            this.linkCalc.Location = new System.Drawing.Point(13, 42);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(77, 15);
            this.linkCalc.TabIndex = 1;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Калькулятор";
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCalc_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkCalc);
            this.Controls.Add(this.linkLabelToControl);
            this.Name = "PortalForm";
            this.Text = "PortalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelToControl;
        private System.Windows.Forms.LinkLabel linkCalc;
    }
}