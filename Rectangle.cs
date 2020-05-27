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
    public class Rectangle:Shape
    {
        public float width;
        public float height;
        public PointF[] points;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Rectangle()
        { }

        public Rectangle(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            float x1, y1, x2, y2;
            if (x1Val < x2Val)
            {
                x1 = x1Val;
                x2 = x2Val;
            }
            else
            {
                x2 = x1Val;
                x1 = x2Val;
            }

            if (y1Val < y2Val)
            {
                y1 = y1Val;
                y2 = y2Val;
            }
            else
            {
                y2 = y1Val;
                y1 = y2Val;
            }

            points = new PointF[4];
            width = x2 - x1;
            height = y2 - y1;
            points[0] = new PointF(x1, y1);
            points[1] = new PointF(x2, y1);
            points[2] = new PointF(x2, y2);
            points[3] = new PointF(x1, y2);

            color = col;
            fill = f;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            float x1, y1, x2, y2;
            if (p1Val.X < p2Val.X)
            {
                x1 = p1Val.X;
                x2 = p2Val.X;
            }
            else
            {
                x2 = p1Val.X;
                x1 = p2Val.X;
            }

            if (p1Val.Y < p2Val.Y)
            {
                y1 = p1Val.Y;
                y2 = p2Val.Y;
            }
            else
            {
                y2 = p1Val.Y;
                y1 = p2Val.Y;
            }

            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillRectangle(brush, x1, y1, x2 - x1, y2 - y1);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawRectangle(pen, x1, y1, x2 - x1, y2 - y1);
            }
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillRectangle(brush, points[0].X, points[0].Y, width, height);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawRectangle(pen, points[0].X, points[0].Y, width, height);
            }
        }
    }
}
