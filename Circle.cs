using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Circle : Shape
    {
        public float rad;
        public Point center;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Circle()
        { }

        public Circle(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            center = new Point(x1Val, y1Val);
            rad = Math.Abs(x1Val - x2Val);
            color = col;
            fill = f;
        }

        public static void Preview(Point p1Val, Point p2Val, Graphics g, Color color, bool fill)
        {
            float rad = Math.Abs(p1Val.x - p2Val.x);

            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, p1Val.x - rad, p1Val.y - rad, 2 * rad, 2 * rad);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawEllipse(pen, p1Val.x - rad, p1Val.y - rad, 2 * rad, 2 * rad);
            }
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillEllipse(brush, center.x - rad, center.y - rad, 2 * rad, 2 * rad);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawEllipse(pen, center.x - rad, center.y - rad, 2 * rad, 2 * rad);
            }
        }
    }
}
