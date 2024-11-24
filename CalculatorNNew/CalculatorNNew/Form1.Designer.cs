namespace CalculatorNNew
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
            panel1 = new Panel();
            TxtDisplay1 = new TextBox();
            TxtDisplay2 = new TextBox();
            buttonGrad1 = new CalculatorNew.ButtonGrad();
            buttonGrad2 = new CalculatorNew.ButtonGrad();
            buttonGrad3 = new CalculatorNew.ButtonGrad();
            panel2 = new Panel();
            buttonGrad4 = new CalculatorNew.ButtonGrad();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 44, 44);
            panel1.Controls.Add(TxtDisplay1);
            panel1.Controls.Add(TxtDisplay2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(208, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 567);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // TxtDisplay1
            // 
            TxtDisplay1.BackColor = Color.FromArgb(44, 44, 44);
            TxtDisplay1.BorderStyle = BorderStyle.None;
            TxtDisplay1.Font = new Font("Gadugi", 30F, FontStyle.Bold, GraphicsUnit.Point);
            TxtDisplay1.ForeColor = Color.Silver;
            TxtDisplay1.Location = new Point(77, 125);
            TxtDisplay1.Multiline = true;
            TxtDisplay1.Name = "TxtDisplay1";
            TxtDisplay1.Size = new Size(328, 58);
            TxtDisplay1.TabIndex = 1;
            TxtDisplay1.Text = "213";
            TxtDisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtDisplay2
            // 
            TxtDisplay2.BackColor = Color.FromArgb(44, 44, 44);
            TxtDisplay2.BorderStyle = BorderStyle.None;
            TxtDisplay2.Font = new Font("Gadugi", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDisplay2.ForeColor = Color.Silver;
            TxtDisplay2.Location = new Point(74, 92);
            TxtDisplay2.Multiline = true;
            TxtDisplay2.Name = "TxtDisplay2";
            TxtDisplay2.Size = new Size(328, 27);
            TxtDisplay2.TabIndex = 0;
            TxtDisplay2.Text = "213";
            TxtDisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonGrad1
            // 
            buttonGrad1.FlatAppearance.BorderSize = 0;
            buttonGrad1.FlatStyle = FlatStyle.Flat;
            buttonGrad1.ForeColor = Color.White;
            buttonGrad1.Location = new Point(12, 59);
            buttonGrad1.Margin = new Padding(0);
            buttonGrad1.Name = "buttonGrad1";
            buttonGrad1.Size = new Size(185, 66);
            buttonGrad1.TabIndex = 1;
            buttonGrad1.Text = "Calculator";
            buttonGrad1.UseVisualStyleBackColor = true;
            buttonGrad1.Click += buttonGrad1_Click;
            // 
            // buttonGrad2
            // 
            buttonGrad2.FlatAppearance.BorderSize = 0;
            buttonGrad2.FlatStyle = FlatStyle.Flat;
            buttonGrad2.ForeColor = Color.White;
            buttonGrad2.Location = new Point(12, 149);
            buttonGrad2.Margin = new Padding(0);
            buttonGrad2.Name = "buttonGrad2";
            buttonGrad2.Size = new Size(185, 66);
            buttonGrad2.TabIndex = 2;
            buttonGrad2.Text = "NDS-Calclator";
            buttonGrad2.UseVisualStyleBackColor = true;
            buttonGrad2.Click += buttonGrad2_Click;
            // 
            // buttonGrad3
            // 
            buttonGrad3.FlatAppearance.BorderSize = 0;
            buttonGrad3.FlatStyle = FlatStyle.Flat;
            buttonGrad3.ForeColor = Color.White;
            buttonGrad3.Location = new Point(12, 240);
            buttonGrad3.Margin = new Padding(0);
            buttonGrad3.Name = "buttonGrad3";
            buttonGrad3.Size = new Size(185, 66);
            buttonGrad3.TabIndex = 3;
            buttonGrad3.Text = "NDFL-Calculator";
            buttonGrad3.UseVisualStyleBackColor = true;
            buttonGrad3.Click += buttonGrad3_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(-5, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 35);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // buttonGrad4
            // 
            buttonGrad4.ForeColor = Color.White;
            buttonGrad4.Location = new Point(12, 334);
            buttonGrad4.Name = "buttonGrad4";
            buttonGrad4.Size = new Size(185, 66);
            buttonGrad4.TabIndex = 4;
            buttonGrad4.Text = "Customs Clearance";
            buttonGrad4.UseVisualStyleBackColor = true;
            buttonGrad4.Click += buttonGrad4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(613, 567);
            Controls.Add(buttonGrad4);
            Controls.Add(buttonGrad2);
            Controls.Add(panel2);
            Controls.Add(buttonGrad3);
            Controls.Add(buttonGrad1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CalculatorNew.ButtonGrad buttonGrad1;
        private CalculatorNew.ButtonGrad buttonGrad2;
        private CalculatorNew.ButtonGrad buttonGrad3;
        private Panel panel2;
        private TextBox TxtDisplay2;
        private TextBox TxtDisplay1;
        private CalculatorNew.ButtonGrad buttonGrad4;
    }
}