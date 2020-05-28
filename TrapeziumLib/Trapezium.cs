using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapeClass;

namespace TrapeziumLib
{
    [Serializable]
    public class Trapezium : Shape
    {
        public PointF[] points;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Trapezium()
        { }

        public Trapezium(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            points = new PointF[4];
            float dlt = (x2Val - x1Val) / 3;
            points[0] = new PointF(x1Val, y2Val);
            points[1] = new PointF(x1Val + dlt, y1Val);
            points[2] = new PointF(x2Val - dlt, y1Val);
            points[3] = new PointF(x2Val, y2Val);

            color = col;
            fill = f;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            PointF[] temp = new PointF[4];
            float dlt = (p2Val.X - p1Val.X) / 3;
            temp[0] = new PointF(p1Val.X, p2Val.Y);
            temp[1] = new PointF(p1Val.X + dlt, p1Val.Y);
            temp[2] = new PointF(p2Val.X - dlt, p1Val.Y);
            temp[3] = p2Val;

            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillPolygon(brush, temp);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawPolygon(pen, temp);
            }
        }
        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillPolygon(brush, points);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawPolygon(pen, points);
            }
        }
    }
}
