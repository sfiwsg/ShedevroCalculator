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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonGrad1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int an12n))
            {
                MessageBox.Show("Введи число!");
                return;
            }
            if (!int.TryParse(textBox1.Text, out int an121n))
            {
                MessageBox.Show("Введи число!");
                return;
            }

            //BENZIN+INHI
            if (comboBox1.Text == "Бензин")
            {
                if (comboBox2.Text == "інші")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //ЄАВТ
                if (comboBox2.Text == "ЄАВТ")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //ЄС

                if (comboBox2.Text == "ЄС")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //Канада
                if (comboBox2.Text == "Канада")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.05 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
            }

            //Дизель
            if (comboBox1.Text == "Дизель")
            {
                if (comboBox2.Text == "інші")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //ЄАВТ
                if (comboBox2.Text == "ЄАВТ")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //ЄС
                if (comboBox2.Text == "ЄС")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
                //KANADA
                if (comboBox2.Text == "Канада")
                {
                    if (comboBox3.Text == "1")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 1);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "2")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 2);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "3")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 3);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "4")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 4);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "5")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 5);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "6")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 6);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "7")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 7);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "8")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 8);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "9")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 9);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                    if (comboBox3.Text == "10")
                    {
                        double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                        //візне
                        textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                        //акц податок
                        textBox4.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) * 0.075 * 10);
                        //пдв
                        double textBox3Value = Convert.ToDouble(textBox3.Text);
                        double textBox4Value = Convert.ToDouble(textBox4.Text);
                        double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                        textBox5.Text = result.ToString();
                        //повна
                        double value3 = Convert.ToDouble(textBox3.Text);
                        double value4 = Convert.ToDouble(textBox4.Text);
                        double value5 = Convert.ToDouble(textBox5.Text);
                        double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                        textBox6.Text = result2.ToString();

                    }
                }
            }
            //ЕЛЕКТРО

            if (comboBox1.Text == "Електро")
            {
                if (!int.TryParse(textBox7.Text, out int ann))
                {
                    MessageBox.Show("Введи число!");
                    return;
                }
                if (!int.TryParse(textBox1.Text, out int an1n))
                {
                    MessageBox.Show("Введи число!");
                    return;
                }
                if (comboBox2.Text == "інші")
                {
                    double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                    //візне
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                    //акц податок
                    textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1);
                    //пдв
                    double textBox3Value = Convert.ToDouble(textBox3.Text);
                    double textBox4Value = Convert.ToDouble(textBox4.Text);
                    double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                    textBox5.Text = result.ToString();
                    //повна
                    //повна
                    double value3 = Convert.ToDouble(textBox3.Text);
                    double value4 = Convert.ToDouble(textBox4.Text);
                    double value5 = Convert.ToDouble(textBox5.Text);
                    double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                    textBox6.Text = result2.ToString();
                }
                if (comboBox2.Text == "ЄАВТ")
                {
                    double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                    //візне
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.10);
                    //акц податок
                    textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1);
                    //пдв
                    double textBox3Value = Convert.ToDouble(textBox3.Text);
                    double textBox4Value = Convert.ToDouble(textBox4.Text);
                    double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                    textBox5.Text = result.ToString();
                    //повна
                    //повна
                    double value3 = Convert.ToDouble(textBox3.Text);
                    double value4 = Convert.ToDouble(textBox4.Text);
                    double value5 = Convert.ToDouble(textBox5.Text);
                    double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                    textBox6.Text = result2.ToString();
                }
                if (comboBox2.Text == "Канада")
                {
                    double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                    //візне
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                    //акц податок
                    textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1);
                    //пдв
                    double textBox3Value = Convert.ToDouble(textBox3.Text);
                    double textBox4Value = Convert.ToDouble(textBox4.Text);
                    double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                    textBox5.Text = result.ToString();
                    //повна
                    //повна
                    double value3 = Convert.ToDouble(textBox3.Text);
                    double value4 = Convert.ToDouble(textBox4.Text);
                    double value5 = Convert.ToDouble(textBox5.Text);
                    double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                    textBox6.Text = result2.ToString();
                }
                if (comboBox2.Text == "ЄС")
                {
                    double CenaAvtoZaKordonom = Convert.ToDouble(textBox1.Text);
                    //візне
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0);
                    //акц податок
                    textBox4.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) * 1);
                    //пдв
                    double textBox3Value = Convert.ToDouble(textBox3.Text);
                    double textBox4Value = Convert.ToDouble(textBox4.Text);
                    double result = (CenaAvtoZaKordonom + textBox3Value + textBox4Value) * 0.20;
                    textBox5.Text = result.ToString();
                    //повна
                    //повна
                    double value3 = Convert.ToDouble(textBox3.Text);
                    double value4 = Convert.ToDouble(textBox4.Text);
                    double value5 = Convert.ToDouble(textBox5.Text);
                    double result2 = (Convert.ToDouble(textBox1.Text) + value3 + value4 + value5);
                    textBox6.Text = result2.ToString();
                }
            }
        }
    }
}
