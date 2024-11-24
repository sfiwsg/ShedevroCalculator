using System.Drawing.Drawing2D;

namespace CalculatorNNew
{
    public partial class Form1 : Form
    {

        private Form active;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Получаем графику для панели
            Graphics g = e.Graphics;

            // Задаем градиент от черного к серому
            using (LinearGradientBrush brush = new LinearGradientBrush(panel2.ClientRectangle, Color.Black, Color.FromArgb(30, 30, 30), LinearGradientMode.Vertical))
            {
                // Заливаем панель градиентом
                g.FillRectangle(brush, panel2.ClientRectangle);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelForm(new Calculator());
        }


        private void PanelForm(Form fm)
        {
            if (active != null)
                active.Close();
            active = fm;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fm);
            this.panel1.Tag = fm;
            fm.BringToFront();
            fm.Show();
        }

        private void buttonGrad1_Click(object sender, EventArgs e)
        {
            PanelForm(new Calculator());
        }

        private void buttonGrad2_Click(object sender, EventArgs e)
        {
            PanelForm(new NdsCalculator());
        }

        private void buttonGrad3_Click(object sender, EventArgs e)
        {
            PanelForm(new NdflCalculator());
        }

        private void buttonGrad4_Click(object sender, EventArgs e)
        {
            PanelForm(new Form4());
        }

        private void buttonGrad5_Click(object sender, EventArgs e)
        {
            PanelForm(new Form5());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}