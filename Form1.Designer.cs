namespace Homework_1
{
    partial class Form1
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
            this.listOutput = new System.Windows.Forms.ListBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.grpLang = new System.Windows.Forms.GroupBox();
            this.grpOpt = new System.Windows.Forms.GroupBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.rbBul = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.checkSymbols = new System.Windows.Forms.CheckBox();
            this.checkWords = new System.Windows.Forms.CheckBox();
            this.checkVowels = new System.Windows.Forms.CheckBox();
            this.checkDigits = new System.Windows.Forms.CheckBox();
            this.checkLongest = new System.Windows.Forms.CheckBox();
            this.grpLang.SuspendLayout();
            this.grpOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOutput
            // 
            this.listOutput.FormattingEnabled = true;
            this.listOutput.HorizontalScrollbar = true;
            this.listOutput.Location = new System.Drawing.Point(407, 38);
            this.listOutput.Name = "listOutput";
            this.listOutput.Size = new System.Drawing.Size(381, 394);
            this.listOutput.TabIndex = 0;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 38);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(383, 190);
            this.txtInput.TabIndex = 1;
            // 
            // grpLang
            // 
            this.grpLang.Controls.Add(this.rbEng);
            this.grpLang.Controls.Add(this.rbBul);
            this.grpLang.Location = new System.Drawing.Point(12, 234);
            this.grpLang.Name = "grpLang";
            this.grpLang.Size = new System.Drawing.Size(200, 54);
            this.grpLang.TabIndex = 2;
            this.grpLang.TabStop = false;
            this.grpLang.Text = "Език";
            // 
            // grpOpt
            // 
            this.grpOpt.Controls.Add(this.checkLongest);
            this.grpOpt.Controls.Add(this.checkDigits);
            this.grpOpt.Controls.Add(this.checkVowels);
            this.grpOpt.Controls.Add(this.checkWords);
            this.grpOpt.Controls.Add(this.checkSymbols);
            this.grpOpt.Location = new System.Drawing.Point(12, 294);
            this.grpOpt.Name = "grpOpt";
            this.grpOpt.Size = new System.Drawing.Size(200, 144);
            this.grpOpt.TabIndex = 3;
            this.grpOpt.TabStop = false;
            this.grpOpt.Text = "Настройки";
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(233, 242);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(162, 46);
            this.btnSwap.TabIndex = 4;
            this.btnSwap.Text = "Смени главни и малки";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.BackColor = System.Drawing.Color.Turquoise;
            this.btnAnalyse.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAnalyse.ForeColor = System.Drawing.Color.White;
            this.btnAnalyse.Location = new System.Drawing.Point(233, 294);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(162, 144);
            this.btnAnalyse.TabIndex = 5;
            this.btnAnalyse.Text = "Анализ";
            this.btnAnalyse.UseVisualStyleBackColor = false;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblOutput.Location = new System.Drawing.Point(404, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(141, 16);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "Лист с резултати:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput.Location = new System.Drawing.Point(8, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(129, 16);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Въведете текст:";
            // 
            // rbBul
            // 
            this.rbBul.AutoSize = true;
            this.rbBul.Location = new System.Drawing.Point(6, 19);
            this.rbBul.Name = "rbBul";
            this.rbBul.Size = new System.Drawing.Size(80, 17);
            this.rbBul.TabIndex = 0;
            this.rbBul.TabStop = true;
            this.rbBul.Text = "Български";
            this.rbBul.UseVisualStyleBackColor = true;
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Location = new System.Drawing.Point(101, 19);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(79, 17);
            this.rbEng.TabIndex = 1;
            this.rbEng.TabStop = true;
            this.rbEng.Text = "Английски";
            this.rbEng.UseVisualStyleBackColor = true;
            // 
            // checkSymbols
            // 
            this.checkSymbols.AutoSize = true;
            this.checkSymbols.Location = new System.Drawing.Point(6, 19);
            this.checkSymbols.Name = "checkSymbols";
            this.checkSymbols.Size = new System.Drawing.Size(85, 17);
            this.checkSymbols.TabIndex = 0;
            this.checkSymbols.Text = "№ Символи";
            this.checkSymbols.UseVisualStyleBackColor = true;
            // 
            // checkWords
            // 
            this.checkWords.AutoSize = true;
            this.checkWords.Location = new System.Drawing.Point(7, 42);
            this.checkWords.Name = "checkWords";
            this.checkWords.Size = new System.Drawing.Size(68, 17);
            this.checkWords.TabIndex = 1;
            this.checkWords.Text = "№ Думи";
            this.checkWords.UseVisualStyleBackColor = true;
            // 
            // checkVowels
            // 
            this.checkVowels.AutoSize = true;
            this.checkVowels.Location = new System.Drawing.Point(6, 65);
            this.checkVowels.Name = "checkVowels";
            this.checkVowels.Size = new System.Drawing.Size(76, 17);
            this.checkVowels.TabIndex = 2;
            this.checkVowels.Text = "№ Гласни";
            this.checkVowels.UseVisualStyleBackColor = true;
            // 
            // checkDigits
            // 
            this.checkDigits.AutoSize = true;
            this.checkDigits.Location = new System.Drawing.Point(6, 88);
            this.checkDigits.Name = "checkDigits";
            this.checkDigits.Size = new System.Drawing.Size(74, 17);
            this.checkDigits.TabIndex = 3;
            this.checkDigits.Text = "№ Цифри";
            this.checkDigits.UseVisualStyleBackColor = true;
            // 
            // checkLongest
            // 
            this.checkLongest.AutoSize = true;
            this.checkLongest.Location = new System.Drawing.Point(6, 111);
            this.checkLongest.Name = "checkLongest";
            this.checkLongest.Size = new System.Drawing.Size(107, 17);
            this.checkLongest.TabIndex = 4;
            this.checkLongest.Text = "Най-дълга дума";
            this.checkLongest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.grpOpt);
            this.Controls.Add(this.grpLang);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.listOutput);
            this.Name = "Form1";
            this.Text = "Анализатор на текст и символни низове - Боян Трендафилов, ФН f125769";
            this.grpLang.ResumeLayout(false);
            this.grpLang.PerformLayout();
            this.grpOpt.ResumeLayout(false);
            this.grpOpt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox grpLang;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbBul;
        private System.Windows.Forms.GroupBox grpOpt;
        private System.Windows.Forms.CheckBox checkLongest;
        private System.Windows.Forms.CheckBox checkDigits;
        private System.Windows.Forms.CheckBox checkVowels;
        private System.Windows.Forms.CheckBox checkWords;
        private System.Windows.Forms.CheckBox checkSymbols;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
    }
}

