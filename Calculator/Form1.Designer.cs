namespace Calculator
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
            label1 = new Label();
            textBoxDisplay = new TextBox();
            btnSaveHistory = new Button();
            listBoxHistory = new ListBox();
            btn7 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btnClear = new Button();
            btnEquals = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(76, 5);
            label1.Name = "label1";
            label1.Size = new Size(161, 40);
            label1.TabIndex = 0;
            label1.Text = "Калькулятор";
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.Location = new Point(12, 50);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(146, 27);
            textBoxDisplay.TabIndex = 1;
            // 
            // btnSaveHistory
            // 
            btnSaveHistory.Location = new Point(160, 48);
            btnSaveHistory.Name = "btnSaveHistory";
            btnSaveHistory.Size = new Size(161, 29);
            btnSaveHistory.TabIndex = 2;
            btnSaveHistory.Text = "Сохранить историю";
            btnSaveHistory.UseVisualStyleBackColor = true;
            btnSaveHistory.Click += btnSaveHistory_Click;
            // 
            // listBoxHistory
            // 
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(164, 83);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(157, 144);
            listBoxHistory.TabIndex = 3;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 83);
            btn7.Name = "btn7";
            btn7.Size = new Size(32, 29);
            btn7.TabIndex = 4;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(88, 153);
            btn3.Name = "btn3";
            btn3.Size = new Size(32, 29);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(50, 153);
            btn2.Name = "btn2";
            btn2.Size = new Size(32, 29);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(50, 188);
            btn0.Name = "btn0";
            btn0.Size = new Size(32, 29);
            btn0.TabIndex = 7;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 153);
            btn1.Name = "btn1";
            btn1.Size = new Size(32, 29);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(88, 118);
            btn6.Name = "btn6";
            btn6.Size = new Size(32, 29);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(88, 83);
            btn9.Name = "btn9";
            btn9.Size = new Size(32, 29);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(50, 118);
            btn5.Name = "btn5";
            btn5.Size = new Size(32, 29);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(50, 83);
            btn8.Name = "btn8";
            btn8.Size = new Size(32, 29);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 118);
            btn4.Name = "btn4";
            btn4.Size = new Size(32, 29);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 188);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(32, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(88, 188);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(32, 29);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(126, 188);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(32, 29);
            btnMultiply.TabIndex = 16;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(126, 153);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(32, 29);
            btnDivide.TabIndex = 17;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperation_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(126, 118);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(32, 29);
            btnSubtract.TabIndex = 18;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnOperation_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(126, 83);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(32, 29);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 245);
            Controls.Add(btnAdd);
            Controls.Add(btnSubtract);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnEquals);
            Controls.Add(btnClear);
            Controls.Add(btn4);
            Controls.Add(btn8);
            Controls.Add(btn5);
            Controls.Add(btn9);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn7);
            Controls.Add(listBoxHistory);
            Controls.Add(btnSaveHistory);
            Controls.Add(textBoxDisplay);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxDisplay;
        private Button btnSaveHistory;
        private ListBox listBoxHistory;
        private Button btn7;
        private Button btn3;
        private Button btn2;
        private Button btn0;
        private Button btn1;
        private Button btn6;
        private Button btn9;
        private Button btn5;
        private Button btn8;
        private Button btn4;
        private Button btnClear;
        private Button btnEquals;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnSubtract;
        private Button btnAdd;
    }
}
