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
    public partial class NdsCalculator : Form
    {
        public NdsCalculator()
        {
            InitializeComponent();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonGrad1_Click(object sender, EventArgs e)
        {
            double TextPole1 = Convert.ToDouble(textBox1.Text);
            double percent = 0.0;
            double TextPole2 = Convert.ToDouble(textBox1.Text); // Введена сума (з ПДВ)
            double percent2 = 0.0;
            double baseAmount = 0.0;

            if (materialSwitch2.Checked)
            {
                if (materialSwitch3.Checked)
                {
                    textBox2.Text = textBox1.Text;
                    percent = TextPole1 * 0.2;
                    textBox3.Text = Convert.ToString(percent);
                    textBox4.Text = Convert.ToString(percent + TextPole1);
                }
                else
                {
                    textBox2.Text = Convert.ToString(0);
                    textBox3.Text = Convert.ToString(0);
                    textBox4.Text = Convert.ToString(0);
                }
                if (materialSwitch4.Checked)
                {
                    textBox2.Text = textBox1.Text;
                    percent = TextPole1 * 0.1;
                    textBox3.Text = Convert.ToString(percent);
                    textBox4.Text = Convert.ToString(percent + TextPole1);
                }
                if (materialSwitch5.Checked)
                {
                    textBox2.Text = textBox1.Text;
                    percent = TextPole1 * 0.1667;
                    textBox3.Text = Convert.ToString(percent);
                    textBox4.Text = Convert.ToString(percent + TextPole1);
                }

            }
            if (materialSwitch1.Checked) // Виділяємо ПДВ
            {
                if (materialSwitch3.Checked) // Ставка ПДВ 20%
                {
                    baseAmount = TextPole2 / 1.2; // Сума без ПДВ
                    percent2 = TextPole2 - baseAmount; // ПДВ
                    textBox2.Text = Convert.ToString(TextPole2); // Сума з ПДВ (введена сума)
                    textBox3.Text = Convert.ToString(Math.Round(percent2, 2)); // Сума ПДВ (округлена)
                    textBox4.Text = Convert.ToString(Math.Round(baseAmount, 2)); // Сума без ПДВ
                }
                if (materialSwitch4.Checked) // Ставка ПДВ 10%
                {
                    baseAmount = TextPole2 / 1.1; // Сума без ПДВ
                    percent2 = TextPole2 - baseAmount; // ПДВ
                    textBox2.Text = Convert.ToString(TextPole2); // Сума з ПДВ (введена сума)
                    textBox3.Text = Convert.ToString(Math.Round(percent2, 2)); // Сума ПДВ
                    textBox4.Text = Convert.ToString(Math.Round(baseAmount, 2)); // Сума без ПДВ
                }
                if (materialSwitch5.Checked) // Ставка ПДВ 16.67%
                {
                    baseAmount = TextPole2 / 1.1667; // Сума без ПДВ
                    percent2 = TextPole2 - baseAmount; // ПДВ
                    textBox2.Text = Convert.ToString(TextPole2); // Сума з ПДВ (введена сума)
                    textBox3.Text = Convert.ToString(Math.Round(percent2, 2)); // Сума ПДВ
                    textBox4.Text = Convert.ToString(Math.Round(baseAmount, 2)); // Сума без ПДВ
                }
            }
        }
    }
}
