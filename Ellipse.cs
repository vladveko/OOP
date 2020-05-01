using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Ellipse : Shape
    {
        public float a, b;
        public Point center;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Ellipse()
        { }

        public Ellipse(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            a = Math.Abs(x1Val - x2Val);
            b = Math.Abs(y1Val - y2Val);
            center = new Point(x1Val, y1Val);
            color = col;
            fill = f;
        }

        public static void Preview(Point p1Val, Point p2Val, Graphics g, Color color, bool fill)
        {
            
            float a = Math.Abs(p1Val.x - p2Val.x);
            float b = Math.Abs(p1Val.y - p2Val.y);
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, p1Val.x - a, p1Val.y - b, 2 * a, 2 * b);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawEllipse(pen, p1Val.x - a, p1Val.y - b, 2 * a, 2 * b);
            }
            
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillEllipse(brush, center.x - a, center.y - b, 2*a, 2*b);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawEllipse(pen, center.x - a, center.y - b, 2*a, 2*b);
            }
        }
    }
}
