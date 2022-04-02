
namespace WinForms.Forms
{
    partial class Calc
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
            this.labelDisplay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMultiplication = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.buttonCL = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.labelHistory = new System.Windows.Forms.Label();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.ButtonDot = new System.Windows.Forms.Button();
            this.checkBoxBinary = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelDisplay
            // 
            this.labelDisplay.BackColor = System.Drawing.Color.White;
            this.labelDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDisplay.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDisplay.Location = new System.Drawing.Point(18, 73);
            this.labelDisplay.Name = "labelDisplay";
            this.labelDisplay.Size = new System.Drawing.Size(244, 38);
            this.labelDisplay.TabIndex = 0;
            this.labelDisplay.Text = "0";
            this.labelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(17, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(79, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(141, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(17, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(79, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(141, 207);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(17, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 49);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(79, 152);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 49);
            this.button8.TabIndex = 5;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(141, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 49);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPlus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(203, 207);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(56, 49);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMultiplication
            // 
            this.buttonMultiplication.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMultiplication.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMultiplication.Location = new System.Drawing.Point(203, 152);
            this.buttonMultiplication.Name = "buttonMultiplication";
            this.buttonMultiplication.Size = new System.Drawing.Size(56, 49);
            this.buttonMultiplication.TabIndex = 10;
            this.buttonMultiplication.Text = "x";
            this.buttonMultiplication.UseVisualStyleBackColor = false;
            this.buttonMultiplication.Click += new System.EventHandler(this.buttonMultiplication_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.SystemColors.Control;
            this.buttonResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResult.Location = new System.Drawing.Point(203, 317);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(56, 52);
            this.buttonResult.TabIndex = 9;
            this.buttonResult.Text = "=";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDivision.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDivision.Location = new System.Drawing.Point(141, 317);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(56, 52);
            this.buttonDivision.TabIndex = 16;
            this.buttonDivision.Text = "÷";
            this.buttonDivision.UseVisualStyleBackColor = false;
            this.buttonDivision.Click += new System.EventHandler(this.buttonDivision_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.SystemColors.Control;
            this.buttonMinus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(203, 262);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(56, 49);
            this.buttonMinus.TabIndex = 15;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Control;
            this.button0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(79, 317);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(56, 52);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.Control;
            this.button16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(17, 317);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 23);
            this.button16.TabIndex = 13;
            this.button16.Text = "±";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // buttonCL
            // 
            this.buttonCL.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCL.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCL.Location = new System.Drawing.Point(203, 123);
            this.buttonCL.Name = "buttonCL";
            this.buttonCL.Size = new System.Drawing.Size(56, 23);
            this.buttonCL.TabIndex = 17;
            this.buttonCL.Text = "⌫";
            this.buttonCL.UseVisualStyleBackColor = false;
            this.buttonCL.Click += new System.EventHandler(this.buttonCL_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCE.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCE.Location = new System.Drawing.Point(141, 123);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(56, 23);
            this.buttonCE.TabIndex = 18;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.SystemColors.Control;
            this.buttonC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonC.Location = new System.Drawing.Point(79, 123);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(56, 23);
            this.buttonC.TabIndex = 19;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.BackColor = System.Drawing.Color.White;
            this.labelHistory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistory.Location = new System.Drawing.Point(17, 32);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(244, 26);
            this.labelHistory.TabIndex = 20;
            this.labelHistory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSquare
            // 
            this.buttonSquare.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSquare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSquare.Location = new System.Drawing.Point(17, 123);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(56, 23);
            this.buttonSquare.TabIndex = 21;
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // ButtonDot
            // 
            this.ButtonDot.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDot.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonDot.Location = new System.Drawing.Point(17, 346);
            this.ButtonDot.Name = "ButtonDot";
            this.ButtonDot.Size = new System.Drawing.Size(56, 23);
            this.ButtonDot.TabIndex = 22;
            this.ButtonDot.Text = "•";
            this.ButtonDot.UseVisualStyleBackColor = false;
            this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
            // 
            // checkBoxBinary
            // 
            this.checkBoxBinary.AutoSize = true;
            this.checkBoxBinary.Location = new System.Drawing.Point(18, 10);
            this.checkBoxBinary.Name = "checkBoxBinary";
            this.checkBoxBinary.Size = new System.Drawing.Size(83, 19);
            this.checkBoxBinary.TabIndex = 25;
            this.checkBoxBinary.Text = "checkBox1";
            this.checkBoxBinary.UseVisualStyleBackColor = true;
            this.checkBoxBinary.CheckedChanged += new System.EventHandler(this.checkBoxBinary_CheckedChanged);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(277, 381);
            this.Controls.Add(this.checkBoxBinary);
            this.Controls.Add(this.ButtonDot);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonCL);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMultiplication);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Calc";
            this.Opacity = 0.85D;
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Calc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMultiplication;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button buttonCL;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button ButtonDot;
        private System.Windows.Forms.CheckBox checkBoxBinary;
    }
}