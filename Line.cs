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
    public class Line : Shape
    {
        public PointF[] points;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Line()
        { }

        public Line(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            points = new PointF[2];
            points[0] = new PointF(x1Val, y1Val);
            points[1] = new PointF(x2Val, y2Val);
            fill = f;

            color = col;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            Pen pen = new Pen(color, 2);
            g.DrawLine(pen, p1Val.X, p1Val.Y, p2Val.X, p2Val.Y);
        }

        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 2);
            graph.DrawLine(pen, points[0].X, points[0].Y, points[1].X, points[1].Y);
        }
    }
}
