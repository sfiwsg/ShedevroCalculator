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
    public partial class NdflCalculator : Form
    {
        public NdflCalculator()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGrad1_Click(object sender, EventArgs e)
        {
            double SumaNaRukax = 0.0;
            double IzvestnayaSuma = 0.0;
            double StavkaNaloga = 0.0;
            double result1 = 0.0;
            double result2 = 0.0;
            double result3 = 0.0;
            double result4 = 0.0;

            StavkaNaloga = Convert.ToDouble(gunaTextBox3.Text);

            // Якщо введена сума "на руки"
            if (!string.IsNullOrEmpty(gunaTextBox1.Text))
            {
                SumaNaRukax = Convert.ToDouble(gunaTextBox1.Text);

                result1 = SumaNaRukax / (1 - (StavkaNaloga / 100));
                gunaTextBox4.Text = result1.ToString("F2"); // Форматування до двох знаків після коми

                result2 = result1 - SumaNaRukax;
                gunaTextBox5.Text = result2.ToString("F2"); // Форматування до двох знаків після коми
            }
            // Якщо введена сума нарахування
            else if (!string.IsNullOrEmpty(gunaTextBox2.Text))
            {
                IzvestnayaSuma = Convert.ToDouble(gunaTextBox2.Text);

                result3 = IzvestnayaSuma * (1 - (StavkaNaloga / 100));
                gunaTextBox4.Text = result3.ToString("F2"); // Форматування до двох знаків після коми

                result4 = IzvestnayaSuma * (StavkaNaloga / 100);
                gunaTextBox5.Text = result4.ToString("F2"); // Форматування до двох знаків після коми
            }
            else
            {
                // Якщо жодна сума не введена
                MessageBox.Show("Введіть або суму 'на руки', або суму нарахування");
            }
        }

        private void NdflCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
