using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapeClass;

namespace labFigures
{
    [Serializable]
    public class Circle : Shape
    {
        public float rad;
        public PointF center;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Circle()
        { }

        public Circle(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            center = new PointF(x1Val, y1Val);
            rad = Math.Abs(x1Val - x2Val);
            color = col;
            fill = f;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            float rad = Math.Abs(p1Val.X - p2Val.X);

            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, p1Val.X - rad, p1Val.Y - rad, 2 * rad, 2 * rad);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawEllipse(pen, p1Val.X - rad, p1Val.Y - rad, 2 * rad, 2 * rad);
            }
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillEllipse(brush, center.X - rad, center.Y - rad, 2 * rad, 2 * rad);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawEllipse(pen, center.X - rad, center.Y - rad, 2 * rad, 2 * rad);
            }
        }
    }
}
