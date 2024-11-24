namespace CalculatorNNew
{
    partial class Calculator
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
            TxtDisplay1 = new TextBox();
            TxtDisplay2 = new TextBox();
            Btn9 = new CalculatorNew.ButtonGrad();
            Btn8 = new CalculatorNew.ButtonGrad();
            Btn7 = new CalculatorNew.ButtonGrad();
            Btn6 = new CalculatorNew.ButtonGrad();
            Btn5 = new CalculatorNew.ButtonGrad();
            Btn4 = new CalculatorNew.ButtonGrad();
            Btn3 = new CalculatorNew.ButtonGrad();
            Btn2 = new CalculatorNew.ButtonGrad();
            Btn1 = new CalculatorNew.ButtonGrad();
            BtnDesimal = new CalculatorNew.ButtonGrad();
            Btn0 = new CalculatorNew.ButtonGrad();
            BtnC = new RoundedButton();
            BtnPercent = new RoundedButton();
            BtnSquare = new RoundedButton();
            BtnDivision = new RoundedButton();
            BtnMultiply = new RoundedButton();
            BtnEquals = new RoundedButton();
            BtnAdd = new RoundedButton();
            BtnMinus = new RoundedButton();
            SuspendLayout();
            // 
            // TxtDisplay1
            // 
            TxtDisplay1.BackColor = Color.FromArgb(44, 44, 44);
            TxtDisplay1.BorderStyle = BorderStyle.None;
            TxtDisplay1.Font = new Font("Gadugi", 30F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDisplay1.ForeColor = Color.Silver;
            TxtDisplay1.Location = new Point(22, 128);
            TxtDisplay1.Multiline = true;
            TxtDisplay1.Name = "TxtDisplay1";
            TxtDisplay1.Size = new Size(323, 58);
            TxtDisplay1.TabIndex = 3;
            TxtDisplay1.Text = "0";
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDisplay2
            // 
            TxtDisplay2.BackColor = Color.FromArgb(44, 44, 44);
            TxtDisplay2.BorderStyle = BorderStyle.None;
            TxtDisplay2.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDisplay2.ForeColor = Color.Silver;
            TxtDisplay2.Location = new Point(12, 95);
            TxtDisplay2.Multiline = true;
            TxtDisplay2.Name = "TxtDisplay2";
            TxtDisplay2.Size = new Size(328, 27);
            TxtDisplay2.TabIndex = 2;
            TxtDisplay2.Text = "0";
            TxtDisplay2.TextAlign = HorizontalAlignment.Right;
            TxtDisplay2.TextChanged += TxtDisplay2_TextChanged;
            // 
            // Btn9
            // 
            Btn9.FlatStyle = FlatStyle.Popup;
            Btn9.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn9.ForeColor = Color.Silver;
            Btn9.Location = new Point(200, 303);
            Btn9.Margin = new Padding(0);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(65, 60);
            Btn9.TabIndex = 10;
            Btn9.Text = "9";
            Btn9.UseVisualStyleBackColor = true;
            Btn9.Click += BtnNum_Click;
            // 
            // Btn8
            // 
            Btn8.FlatStyle = FlatStyle.Popup;
            Btn8.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn8.ForeColor = Color.Silver;
            Btn8.Location = new Point(119, 303);
            Btn8.Margin = new Padding(0);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(65, 60);
            Btn8.TabIndex = 9;
            Btn8.Text = "8";
            Btn8.UseVisualStyleBackColor = true;
            Btn8.Click += BtnNum_Click;
            // 
            // Btn7
            // 
            Btn7.FlatStyle = FlatStyle.Popup;
            Btn7.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn7.ForeColor = Color.Silver;
            Btn7.Location = new Point(39, 303);
            Btn7.Margin = new Padding(0);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(65, 60);
            Btn7.TabIndex = 8;
            Btn7.Text = "7";
            Btn7.UseVisualStyleBackColor = true;
            Btn7.Click += BtnNum_Click;
            // 
            // Btn6
            // 
            Btn6.FlatStyle = FlatStyle.Popup;
            Btn6.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn6.ForeColor = Color.Silver;
            Btn6.Location = new Point(200, 369);
            Btn6.Margin = new Padding(0);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(65, 60);
            Btn6.TabIndex = 14;
            Btn6.Text = "6";
            Btn6.UseVisualStyleBackColor = true;
            Btn6.Click += BtnNum_Click;
            // 
            // Btn5
            // 
            Btn5.FlatStyle = FlatStyle.Popup;
            Btn5.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn5.ForeColor = Color.Silver;
            Btn5.Location = new Point(119, 369);
            Btn5.Margin = new Padding(0);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(65, 60);
            Btn5.TabIndex = 13;
            Btn5.Text = "5";
            Btn5.UseVisualStyleBackColor = true;
            Btn5.Click += BtnNum_Click;
            // 
            // Btn4
            // 
            Btn4.FlatStyle = FlatStyle.Popup;
            Btn4.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn4.ForeColor = Color.Silver;
            Btn4.Location = new Point(39, 369);
            Btn4.Margin = new Padding(0);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(65, 60);
            Btn4.TabIndex = 12;
            Btn4.Text = "4";
            Btn4.UseVisualStyleBackColor = true;
            Btn4.Click += BtnNum_Click;
            // 
            // Btn3
            // 
            Btn3.FlatStyle = FlatStyle.Popup;
            Btn3.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn3.ForeColor = Color.Silver;
            Btn3.Location = new Point(200, 435);
            Btn3.Margin = new Padding(0);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(65, 60);
            Btn3.TabIndex = 18;
            Btn3.Text = "3";
            Btn3.UseVisualStyleBackColor = true;
            Btn3.Click += BtnNum_Click;
            // 
            // Btn2
            // 
            Btn2.FlatStyle = FlatStyle.Popup;
            Btn2.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn2.ForeColor = Color.Silver;
            Btn2.Location = new Point(119, 435);
            Btn2.Margin = new Padding(0);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(65, 60);
            Btn2.TabIndex = 17;
            Btn2.Text = "2";
            Btn2.UseVisualStyleBackColor = true;
            Btn2.Click += BtnNum_Click;
            // 
            // Btn1
            // 
            Btn1.FlatStyle = FlatStyle.Popup;
            Btn1.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn1.ForeColor = Color.Silver;
            Btn1.Location = new Point(39, 435);
            Btn1.Margin = new Padding(0);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(65, 60);
            Btn1.TabIndex = 16;
            Btn1.Text = "1";
            Btn1.UseVisualStyleBackColor = true;
            Btn1.Click += BtnNum_Click;
            // 
            // BtnDesimal
            // 
            BtnDesimal.FlatStyle = FlatStyle.Popup;
            BtnDesimal.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDesimal.ForeColor = Color.Silver;
            BtnDesimal.Location = new Point(200, 501);
            BtnDesimal.Margin = new Padding(0);
            BtnDesimal.Name = "BtnDesimal";
            BtnDesimal.Size = new Size(65, 60);
            BtnDesimal.TabIndex = 21;
            BtnDesimal.Text = ",";
            BtnDesimal.UseVisualStyleBackColor = true;
            BtnDesimal.Click += BtnNum_Click;
            // 
            // Btn0
            // 
            Btn0.FlatStyle = FlatStyle.Popup;
            Btn0.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Btn0.ForeColor = Color.Silver;
            Btn0.Location = new Point(39, 501);
            Btn0.Margin = new Padding(0);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(145, 60);
            Btn0.TabIndex = 20;
            Btn0.Text = "0";
            Btn0.UseVisualStyleBackColor = true;
            Btn0.Click += BtnNum_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.Gray;
            BtnC.CornerRadius = 20;
            BtnC.FlatStyle = FlatStyle.Popup;
            BtnC.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnC.ForeColor = Color.Silver;
            BtnC.Location = new Point(39, 236);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(65, 59);
            BtnC.TabIndex = 24;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnOperations_Click;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.Gray;
            BtnPercent.CornerRadius = 20;
            BtnPercent.FlatStyle = FlatStyle.Popup;
            BtnPercent.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnPercent.ForeColor = Color.Silver;
            BtnPercent.Location = new Point(119, 237);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(65, 59);
            BtnPercent.TabIndex = 25;
            BtnPercent.Text = "%";
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperations_Click;
            // 
            // BtnSquare
            // 
            BtnSquare.BackColor = Color.Gray;
            BtnSquare.CornerRadius = 20;
            BtnSquare.FlatStyle = FlatStyle.Popup;
            BtnSquare.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSquare.ForeColor = Color.Silver;
            BtnSquare.Location = new Point(200, 237);
            BtnSquare.Name = "BtnSquare";
            BtnSquare.Size = new Size(65, 59);
            BtnSquare.TabIndex = 26;
            BtnSquare.Text = "√";
            BtnSquare.UseVisualStyleBackColor = false;
            BtnSquare.Click += BtnOperations_Click;
            // 
            // BtnDivision
            // 
            BtnDivision.BackColor = Color.Tomato;
            BtnDivision.CornerRadius = 20;
            BtnDivision.FlatStyle = FlatStyle.Popup;
            BtnDivision.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDivision.ForeColor = Color.Silver;
            BtnDivision.Location = new Point(280, 237);
            BtnDivision.Name = "BtnDivision";
            BtnDivision.Size = new Size(65, 59);
            BtnDivision.TabIndex = 27;
            BtnDivision.Text = "/";
            BtnDivision.UseVisualStyleBackColor = false;
            BtnDivision.Click += BtnMathOperation_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.Tomato;
            BtnMultiply.CornerRadius = 20;
            BtnMultiply.FlatStyle = FlatStyle.Popup;
            BtnMultiply.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMultiply.ForeColor = Color.Silver;
            BtnMultiply.Location = new Point(280, 304);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(65, 59);
            BtnMultiply.TabIndex = 28;
            BtnMultiply.Text = "*";
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMathOperation_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = Color.Tomato;
            BtnEquals.CornerRadius = 20;
            BtnEquals.FlatStyle = FlatStyle.Popup;
            BtnEquals.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEquals.ForeColor = Color.Silver;
            BtnEquals.Location = new Point(280, 502);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(65, 59);
            BtnEquals.TabIndex = 29;
            BtnEquals.Text = "=";
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.Tomato;
            BtnAdd.CornerRadius = 20;
            BtnAdd.FlatStyle = FlatStyle.Popup;
            BtnAdd.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAdd.ForeColor = Color.Silver;
            BtnAdd.Location = new Point(280, 370);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(65, 59);
            BtnAdd.TabIndex = 29;
            BtnAdd.Text = "+";
            BtnAdd.UseVisualStyleBackColor = false;
            BtnAdd.Click += BtnMathOperation_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.BackColor = Color.Tomato;
            BtnMinus.CornerRadius = 20;
            BtnMinus.FlatStyle = FlatStyle.Popup;
            BtnMinus.Font = new Font("Bahnschrift Light", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMinus.ForeColor = Color.Silver;
            BtnMinus.Location = new Point(280, 436);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(65, 59);
            BtnMinus.TabIndex = 30;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = false;
            BtnMinus.Click += BtnMathOperation_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 44, 44);
            ClientSize = new Size(398, 600);
            Controls.Add(BtnMinus);
            Controls.Add(BtnAdd);
            Controls.Add(BtnEquals);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnDivision);
            Controls.Add(BtnSquare);
            Controls.Add(BtnPercent);
            Controls.Add(BtnC);
            Controls.Add(BtnDesimal);
            Controls.Add(Btn0);
            Controls.Add(Btn3);
            Controls.Add(Btn2);
            Controls.Add(Btn1);
            Controls.Add(Btn6);
            Controls.Add(Btn5);
            Controls.Add(Btn4);
            Controls.Add(Btn9);
            Controls.Add(Btn8);
            Controls.Add(Btn7);
            Controls.Add(TxtDisplay1);
            Controls.Add(TxtDisplay2);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load_1;
            Click += BtnOperations_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtDisplay1;
        private TextBox TxtDisplay2;
        private CalculatorNew.ButtonGrad Btn9;
        private CalculatorNew.ButtonGrad Btn8;
        private CalculatorNew.ButtonGrad Btn7;
        private CalculatorNew.ButtonGrad Btn6;
        private CalculatorNew.ButtonGrad Btn5;
        private CalculatorNew.ButtonGrad Btn4;
        private CalculatorNew.ButtonGrad Btn3;
        private CalculatorNew.ButtonGrad Btn2;
        private CalculatorNew.ButtonGrad Btn1;
        private CalculatorNew.ButtonGrad BtnDesimal;
        private CalculatorNew.ButtonGrad Btn0;
        private RoundedButton BtnC;
        private RoundedButton BtnPercent;
        private RoundedButton BtnSquare;
        private RoundedButton BtnDivision;
        private RoundedButton BtnMultiply;
        private RoundedButton BtnEquals;
        private RoundedButton BtnAdd;
        private RoundedButton BtnMinus;
    }
}