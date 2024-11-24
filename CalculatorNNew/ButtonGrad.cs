using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNew
{
    public class ButtonGrad:Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Определим область кнопки
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Создаем путь для закругленных углов
            int radius = 20; // радиус углов
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            // Применим путь с закругленными углами к кнопке
            this.Region = new Region(path);

            // Определим градиент от серого к черному (сверху серый, снизу черный)
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Gray, Color.Black, LinearGradientMode.Vertical))
            {
                // Заливка кнопки градиентом
                g.FillPath(brush, path);
            }

            // Отрисовка текста кнопки
            TextRenderer.DrawText(g, this.Text, this.Font, rect, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
