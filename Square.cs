using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Square:Shape
    {
        public float sideLen;
        public Point[] points;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Square()
        { }

        public Square(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            float x, y;

            sideLen = Math.Abs(x1Val - x2Val);
            if (x1Val < x2Val)
                x = x1Val;
            else
                x = x1Val - sideLen;

            if (y1Val < y2Val)
                y = y1Val;
            else
                y = y1Val - sideLen;

            points = new Point[4];
            points[0] = new Point(x, y);
            points[1] = new Point(x + sideLen, y);
            points[2] = new Point(x + sideLen, y + sideLen);
            points[3] = new Point(x, y + sideLen);
            color = col;
            fill = f;
        }

        public static void Preview(Point p1Val, Point p2Val, Graphics g, Color color, bool fill)
        {
            float x, y, len;

            len = Math.Abs(p1Val.x - p2Val.x);
            if (p1Val.x < p2Val.x)
                x = p1Val.x;
            else
                x = p1Val.x - len;

            if (p1Val.y < p2Val.y)
                y = p1Val.y;
            else
                y = p1Val.y - len;

            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillRectangle(brush, x, y, len, len);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawRectangle(pen, x, y, len, len);
            }
            
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillRectangle(brush, points[0].x, points[0].y, sideLen, sideLen);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawRectangle(pen, points[0].x, points[0].y, sideLen, sideLen);
            }
        }
    }
}
