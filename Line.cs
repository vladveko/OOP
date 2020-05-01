using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Line : Shape
    {
        public Point[] points;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Line()
        { }

        public Line(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            points = new Point[2];
            points[0] = new Point(x1Val, y1Val);
            points[1] = new Point(x2Val, y2Val);
            fill = f;

            color = col;
        }

        public static void Preview(Point p1Val, Point p2Val, Graphics g, Color color, bool fill)
        {
            Pen pen = new Pen(color, 2);
            g.DrawLine(pen, p1Val.x, p1Val.y, p2Val.x, p2Val.y);
        }

        public override void Draw(Graphics graph)
        {
            Pen pen = new Pen(color, 2);
            graph.DrawLine(pen, points[0].x, points[0].y, points[1].x, points[1].y);
        }
    }
}
