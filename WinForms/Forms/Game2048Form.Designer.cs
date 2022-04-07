
namespace WinForms.Forms
{
    partial class Game2048Form
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
            this.panelGameField = new System.Windows.Forms.Panel();
            this.cell33 = new System.Windows.Forms.Label();
            this.cell32 = new System.Windows.Forms.Label();
            this.cell31 = new System.Windows.Forms.Label();
            this.cell30 = new System.Windows.Forms.Label();
            this.cell23 = new System.Windows.Forms.Label();
            this.cell22 = new System.Windows.Forms.Label();
            this.cell21 = new System.Windows.Forms.Label();
            this.cell20 = new System.Windows.Forms.Label();
            this.cell13 = new System.Windows.Forms.Label();
            this.cell12 = new System.Windows.Forms.Label();
            this.cell11 = new System.Windows.Forms.Label();
            this.cell10 = new System.Windows.Forms.Label();
            this.cell03 = new System.Windows.Forms.Label();
            this.cell02 = new System.Windows.Forms.Label();
            this.cell01 = new System.Windows.Forms.Label();
            this.cell00 = new System.Windows.Forms.Label();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelStat = new System.Windows.Forms.Label();
            this.panelSensore = new System.Windows.Forms.Panel();
            this.panelGameField.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGameField
            // 
            this.panelGameField.Controls.Add(this.cell33);
            this.panelGameField.Controls.Add(this.cell32);
            this.panelGameField.Controls.Add(this.cell31);
            this.panelGameField.Controls.Add(this.cell30);
            this.panelGameField.Controls.Add(this.cell23);
            this.panelGameField.Controls.Add(this.cell22);
            this.panelGameField.Controls.Add(this.cell21);
            this.panelGameField.Controls.Add(this.cell20);
            this.panelGameField.Controls.Add(this.cell13);
            this.panelGameField.Controls.Add(this.cell12);
            this.panelGameField.Controls.Add(this.cell11);
            this.panelGameField.Controls.Add(this.cell10);
            this.panelGameField.Controls.Add(this.cell03);
            this.panelGameField.Controls.Add(this.cell02);
            this.panelGameField.Controls.Add(this.cell01);
            this.panelGameField.Controls.Add(this.cell00);
            this.panelGameField.Location = new System.Drawing.Point(12, 99);
            this.panelGameField.Name = "panelGameField";
            this.panelGameField.Size = new System.Drawing.Size(231, 234);
            this.panelGameField.TabIndex = 0;
            // 
            // cell33
            // 
            this.cell33.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell33.Location = new System.Drawing.Point(176, 178);
            this.cell33.Name = "cell33";
            this.cell33.Size = new System.Drawing.Size(48, 48);
            this.cell33.TabIndex = 15;
            this.cell33.Text = "0";
            this.cell33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell32
            // 
            this.cell32.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell32.Location = new System.Drawing.Point(120, 178);
            this.cell32.Name = "cell32";
            this.cell32.Size = new System.Drawing.Size(48, 48);
            this.cell32.TabIndex = 14;
            this.cell32.Text = "4096";
            this.cell32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell31
            // 
            this.cell31.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell31.Location = new System.Drawing.Point(64, 178);
            this.cell31.Name = "cell31";
            this.cell31.Size = new System.Drawing.Size(48, 48);
            this.cell31.TabIndex = 13;
            this.cell31.Text = "2048";
            this.cell31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell30
            // 
            this.cell30.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell30.Location = new System.Drawing.Point(8, 178);
            this.cell30.Name = "cell30";
            this.cell30.Size = new System.Drawing.Size(48, 48);
            this.cell30.TabIndex = 12;
            this.cell30.Text = "1024";
            this.cell30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell23
            // 
            this.cell23.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell23.Location = new System.Drawing.Point(176, 121);
            this.cell23.Name = "cell23";
            this.cell23.Size = new System.Drawing.Size(48, 48);
            this.cell23.TabIndex = 11;
            this.cell23.Text = "512";
            this.cell23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell22
            // 
            this.cell22.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell22.Location = new System.Drawing.Point(120, 121);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(48, 48);
            this.cell22.TabIndex = 10;
            this.cell22.Text = "256";
            this.cell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell21
            // 
            this.cell21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell21.Location = new System.Drawing.Point(64, 121);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(48, 48);
            this.cell21.TabIndex = 9;
            this.cell21.Text = "128";
            this.cell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell20
            // 
            this.cell20.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell20.Location = new System.Drawing.Point(8, 121);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(48, 48);
            this.cell20.TabIndex = 8;
            this.cell20.Text = "64";
            this.cell20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell13
            // 
            this.cell13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell13.Location = new System.Drawing.Point(176, 64);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(48, 48);
            this.cell13.TabIndex = 7;
            this.cell13.Text = "32";
            this.cell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell12
            // 
            this.cell12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell12.Location = new System.Drawing.Point(120, 64);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(48, 48);
            this.cell12.TabIndex = 6;
            this.cell12.Text = "16";
            this.cell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell11
            // 
            this.cell11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell11.Location = new System.Drawing.Point(64, 64);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(48, 48);
            this.cell11.TabIndex = 5;
            this.cell11.Text = "8";
            this.cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell10
            // 
            this.cell10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell10.Location = new System.Drawing.Point(8, 64);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(48, 48);
            this.cell10.TabIndex = 4;
            this.cell10.Text = "0";
            this.cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell03
            // 
            this.cell03.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell03.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell03.Location = new System.Drawing.Point(176, 8);
            this.cell03.Name = "cell03";
            this.cell03.Size = new System.Drawing.Size(48, 48);
            this.cell03.TabIndex = 3;
            this.cell03.Text = "4";
            this.cell03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell02
            // 
            this.cell02.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell02.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell02.Location = new System.Drawing.Point(120, 8);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(48, 48);
            this.cell02.TabIndex = 2;
            this.cell02.Text = "2";
            this.cell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell01
            // 
            this.cell01.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell01.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell01.Location = new System.Drawing.Point(64, 8);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(48, 48);
            this.cell01.TabIndex = 1;
            this.cell01.Text = "0";
            this.cell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell00
            // 
            this.cell00.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell00.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cell00.Location = new System.Drawing.Point(8, 8);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(48, 48);
            this.cell00.TabIndex = 0;
            this.cell00.Text = "0";
            this.cell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.panelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDisplay.Controls.Add(this.labelStat);
            this.panelDisplay.Location = new System.Drawing.Point(12, 12);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(112, 81);
            this.panelDisplay.TabIndex = 1;
            // 
            // labelStat
            // 
            this.labelStat.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStat.Location = new System.Drawing.Point(6, 13);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(102, 46);
            this.labelStat.TabIndex = 0;
            this.labelStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSensore
            // 
            this.panelSensore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSensore.Location = new System.Drawing.Point(132, 13);
            this.panelSensore.Name = "panelSensore";
            this.panelSensore.Size = new System.Drawing.Size(111, 80);
            this.panelSensore.TabIndex = 2;
            this.panelSensore.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSensore_MouseDown);
            this.panelSensore.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSensore_MouseUp);
            // 
            // Game2048Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 342);
            this.Controls.Add(this.panelSensore);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelGameField);
            this.Name = "Game2048Form";
            this.Text = "Game2048Form";
            this.Load += new System.EventHandler(this.Game2048Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048Form_KeyDown);
            this.panelGameField.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGameField;
        private System.Windows.Forms.Label cell03;
        private System.Windows.Forms.Label cell02;
        private System.Windows.Forms.Label cell01;
        private System.Windows.Forms.Label cell00;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Label cell33;
        private System.Windows.Forms.Label cell32;
        private System.Windows.Forms.Label cell31;
        private System.Windows.Forms.Label cell30;
        private System.Windows.Forms.Label cell23;
        private System.Windows.Forms.Label cell22;
        private System.Windows.Forms.Label cell21;
        private System.Windows.Forms.Label cell20;
        private System.Windows.Forms.Label cell13;
        private System.Windows.Forms.Label cell12;
        private System.Windows.Forms.Label cell11;
        private System.Windows.Forms.Label cell10;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Panel panelSensore;
    }
}