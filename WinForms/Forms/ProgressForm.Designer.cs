namespace WinForms.Forms
{
    partial class ProgressForm
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
            this.progressBarStyle = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.BarStyle = new System.Windows.Forms.Label();
            this.listBoxStyle = new System.Windows.Forms.ListBox();
            this.comboBoxBarTime = new System.Windows.Forms.ComboBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarStyle
            // 
            this.progressBarStyle.Location = new System.Drawing.Point(12, 34);
            this.progressBarStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBarStyle.Name = "progressBarStyle";
            this.progressBarStyle.Size = new System.Drawing.Size(371, 36);
            this.progressBarStyle.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(466, 149);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(73, 26);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(614, 149);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(74, 26);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // BarStyle
            // 
            this.BarStyle.AutoSize = true;
            this.BarStyle.Location = new System.Drawing.Point(402, 34);
            this.BarStyle.Name = "BarStyle";
            this.BarStyle.Size = new System.Drawing.Size(52, 15);
            this.BarStyle.TabIndex = 3;
            this.BarStyle.Text = "Bar Style";
            // 
            // listBoxStyle
            // 
            this.listBoxStyle.FormattingEnabled = true;
            this.listBoxStyle.ItemHeight = 15;
            this.listBoxStyle.Location = new System.Drawing.Point(466, 34);
            this.listBoxStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxStyle.Name = "listBoxStyle";
            this.listBoxStyle.Size = new System.Drawing.Size(224, 64);
            this.listBoxStyle.TabIndex = 4;
            this.listBoxStyle.SelectedIndexChanged += new System.EventHandler(this.listBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxBarTime
            // 
            this.comboBoxBarTime.FormattingEnabled = true;
            this.comboBoxBarTime.Location = new System.Drawing.Point(466, 112);
            this.comboBoxBarTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBarTime.Name = "comboBoxBarTime";
            this.comboBoxBarTime.Size = new System.Drawing.Size(224, 23);
            this.comboBoxBarTime.TabIndex = 5;
            this.comboBoxBarTime.TextUpdate += new System.EventHandler(this.comboBoxText_Update);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(545, 149);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(63, 26);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.comboBoxBarTime);
            this.Controls.Add(this.listBoxStyle);
            this.Controls.Add(this.BarStyle);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarStyle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarStyle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label BarStyle;
        private System.Windows.Forms.ListBox listBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxBarTime;
        private System.Windows.Forms.Button buttonPause;
    }
}