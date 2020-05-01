using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Rectangle:Shape
    {
        public float width;
        public float height;
        public Point[] points;
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

            points = new Point[4];
            width = x2 - x1;
            height = y2 - y1;
            points[0] = new Point(x1, y1);
            points[1] = new Point(x2, y1);
            points[2] = new Point(x2, y2);
            points[3] = new Point(x1, y2);

            color = col;
            fill = f;
        }

        public static void Preview(Point p1Val, Point p2Val, Graphics g, Color color, bool fill)
        {
            float x1, y1, x2, y2;
            if (p1Val.x < p2Val.x)
            {
                x1 = p1Val.x;
                x2 = p2Val.x;
            }
            else
            {
                x2 = p1Val.x;
                x1 = p2Val.x;
            }

            if (p1Val.y < p2Val.y)
            {
                y1 = p1Val.y;
                y2 = p2Val.y;
            }
            else
            {
                y2 = p1Val.y;
                y1 = p2Val.y;
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
                graph.FillRectangle(brush, points[0].x, points[0].y, width, height);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawRectangle(pen, points[0].x, points[0].y, width, height);
            }
        }
    }
}
