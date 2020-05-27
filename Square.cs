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
    public class Square:Shape
    {
        public float sideLen;
        public PointF[] points;
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

            points = new PointF[4];
            points[0] = new PointF(x, y);
            points[1] = new PointF(x + sideLen, y);
            points[2] = new PointF(x + sideLen, y + sideLen);
            points[3] = new PointF(x, y + sideLen);
            color = col;
            fill = f;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            float x, y, len;

            len = Math.Abs(p1Val.X - p2Val.X);
            if (p1Val.X < p2Val.X)
                x = p1Val.X;
            else
                x = p1Val.X - len;

            if (p1Val.Y < p2Val.Y)
                y = p1Val.Y;
            else
                y = p1Val.Y - len;

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
                graph.FillRectangle(brush, points[0].X, points[0].Y, sideLen, sideLen);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawRectangle(pen, points[0].X, points[0].Y, sideLen, sideLen);
            }
        }
    }
}
