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
            this.button2 = new System.Windows.Forms.Button();
            this.BarStyle = new System.Windows.Forms.Label();
            this.listBoxStyle = new System.Windows.Forms.ListBox();
            this.comboBoxBarTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // progressBarStyle
            // 
            this.progressBarStyle.Location = new System.Drawing.Point(12, 45);
            this.progressBarStyle.Name = "progressBarStyle";
            this.progressBarStyle.Size = new System.Drawing.Size(382, 29);
            this.progressBarStyle.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 94);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(83, 35);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BarStyle
            // 
            this.BarStyle.AutoSize = true;
            this.BarStyle.Location = new System.Drawing.Point(460, 45);
            this.BarStyle.Name = "BarStyle";
            this.BarStyle.Size = new System.Drawing.Size(67, 20);
            this.BarStyle.TabIndex = 3;
            this.BarStyle.Text = "Bar Style";
            // 
            // listBoxStyle
            // 
            this.listBoxStyle.FormattingEnabled = true;
            this.listBoxStyle.ItemHeight = 20;
            this.listBoxStyle.Location = new System.Drawing.Point(533, 45);
            this.listBoxStyle.Name = "listBoxStyle";
            this.listBoxStyle.Size = new System.Drawing.Size(255, 84);
            this.listBoxStyle.TabIndex = 4;
            this.listBoxStyle.SelectedIndexChanged += new System.EventHandler(this.listBoxStyle_SelectedIndexChanged);
            // 
            // comboBoxBarTime
            // 
            this.comboBoxBarTime.FormattingEnabled = true;
            this.comboBoxBarTime.Location = new System.Drawing.Point(533, 150);
            this.comboBoxBarTime.Name = "comboBoxBarTime";
            this.comboBoxBarTime.Size = new System.Drawing.Size(255, 28);
            this.comboBoxBarTime.TabIndex = 5;
            this.comboBoxBarTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxBarTime_SelectedIndexChanged);
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxBarTime);
            this.Controls.Add(this.listBoxStyle);
            this.Controls.Add(this.BarStyle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBarStyle);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarStyle;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label BarStyle;
        private System.Windows.Forms.ListBox listBoxStyle;
        private System.Windows.Forms.ComboBox comboBoxBarTime;
    }
}