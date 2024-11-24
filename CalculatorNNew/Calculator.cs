using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorNNew
{
    public partial class Calculator : Form
    {
        double result = 0.0;
        string operation = string.Empty;
        string fstNum = string.Empty;
        string secNum = string.Empty;

        public Calculator()
        {
            InitializeComponent();
        }

        private void TxtDisplay2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonGrad18_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad13_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad9_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad5_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad17_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad19_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad20_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad14_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad15_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad16_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad10_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad11_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad12_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad6_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad7_Click(object sender, EventArgs e)
        {
        }

        private void buttonGrad8_Click(object sender, EventArgs e)
        {
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {

            // Если текущее значение равно "0", очищаем поле для ввода нового числа
            if (TxtDisplay1.Text == "0")
                TxtDisplay1.Text = string.Empty;

            Button button = (Button)sender;

            // Если была нажата кнопка с запятой
            if (button == BtnDesimal)
            {
                // Проверяем, что запятая еще не содержится в строке
                if (!TxtDisplay1.Text.Contains(","))
                {
                    // Если запятой нет, то добавляем её
                    TxtDisplay1.Text += ",";
                }
            }
            else
            {
                // Добавляем любое число в строку
                TxtDisplay1.Text += button.Text;
            }

        }

        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (result != 0)
            {

            }
            else result = Double.Parse(TxtDisplay1.Text);

            Button button1 = (Button)sender;

            operation = button1.Text;

            if (TxtDisplay1.Text != "0")
            {
                TxtDisplay2.Text = fstNum = $"{result}{operation}";
                TxtDisplay1.Text = string.Empty;
            }

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secNum = TxtDisplay1.Text;
            TxtDisplay2.Text = $"{TxtDisplay2.Text} {TxtDisplay1.Text}=";
            if (TxtDisplay1.Text != string.Empty)
            {
                if (TxtDisplay1.Text == "0")
                {
                    TxtDisplay2.Text = string.Empty;
                }
                switch (operation)
                {
                    case "+":
                        TxtDisplay1.Text = (result + Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "-":
                        TxtDisplay1.Text = (result - Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "*":
                        TxtDisplay1.Text = (result * Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                    case "/":
                        TxtDisplay1.Text = (result / Double.Parse(TxtDisplay1.Text)).ToString();
                        break;
                }
                // Здесь обновляем значение result новым результатом
                result = Double.Parse(TxtDisplay1.Text);

                // После вычисления операции, сбрасываем операцию для новой
                operation = string.Empty;
            }

        }

        private void BtnOperations_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            operation = button3.Text;
            switch (operation)
            {
                case "√":
                    TxtDisplay2.Text = $"√({TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay1.Text)));
                    break;
                case "C":
                    TxtDisplay1.Text = "0";
                    TxtDisplay2.Text = "0";
                    result = 0;
                    break;
                case "%":
                    TxtDisplay2.Text = $"(%{TxtDisplay1.Text})";
                    TxtDisplay1.Text = Convert.ToString(Convert.ToDouble(TxtDisplay1.Text) / Convert.ToDouble(100));
                    break;

            }

        }

        private void Calculator_Load_1(object sender, EventArgs e)
        {

        }
    }
}
