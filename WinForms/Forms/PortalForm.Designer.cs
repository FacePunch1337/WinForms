
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
            this.linkLabelCipher = new System.Windows.Forms.LinkLabel();
            this.linkLabelFractals = new System.Windows.Forms.LinkLabel();
            this.linkLabelHash = new System.Windows.Forms.LinkLabel();
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
            this.linkCalc.Location = new System.Drawing.Point(13, 43);
            this.linkCalc.Name = "linkCalc";
            this.linkCalc.Size = new System.Drawing.Size(77, 15);
            this.linkCalc.TabIndex = 1;
            this.linkCalc.TabStop = true;
            this.linkCalc.Text = "Калькулятор";
            this.linkCalc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCalc_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Прогресс";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelCipher
            // 
            this.linkLabelCipher.AutoSize = true;
            this.linkLabelCipher.Location = new System.Drawing.Point(13, 103);
            this.linkLabelCipher.Name = "linkLabelCipher";
            this.linkLabelCipher.Size = new System.Drawing.Size(66, 15);
            this.linkLabelCipher.TabIndex = 3;
            this.linkLabelCipher.TabStop = true;
            this.linkLabelCipher.Text = "Шифратор";
            this.linkLabelCipher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCipher_LinkClicked);
            // 
            // linkLabelFractals
            // 
            this.linkLabelFractals.AutoSize = true;
            this.linkLabelFractals.Location = new System.Drawing.Point(13, 133);
            this.linkLabelFractals.Name = "linkLabelFractals";
            this.linkLabelFractals.Size = new System.Drawing.Size(62, 15);
            this.linkLabelFractals.TabIndex = 4;
            this.linkLabelFractals.TabStop = true;
            this.linkLabelFractals.Text = "Фракталы";
            this.linkLabelFractals.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFractals_LinkClicked);
            // 
            // linkLabelHash
            // 
            this.linkLabelHash.AutoSize = true;
            this.linkLabelHash.Location = new System.Drawing.Point(15, 159);
            this.linkLabelHash.Name = "linkLabelHash";
            this.linkLabelHash.Size = new System.Drawing.Size(84, 15);
            this.linkLabelHash.TabIndex = 5;
            this.linkLabelHash.TabStop = true;
            this.linkLabelHash.Text = "Хеширование";
            this.linkLabelHash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHash_LinkClicked);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelHash);
            this.Controls.Add(this.linkLabelFractals);
            this.Controls.Add(this.linkLabelCipher);
            this.Controls.Add(this.linkLabel1);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelCipher;
        private System.Windows.Forms.LinkLabel linkLabelFractals;
        private System.Windows.Forms.LinkLabel linkLabelHash;
    }
}