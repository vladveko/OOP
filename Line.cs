using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Line:Shape
    {
        public Point[] points;
        public Color color;

        public Line(float x1Val, float y1Val, float x2Val, float y2Val, Color col)
        {
            points = new Point[2];
            points[0] = new Point(x1Val, y1Val);
            points[1] = new Point(x2Val, y2Val);
            color = col;
        }
        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(color, 2);
            graph.DrawLine(pen, points[0].x, points[0].y, points[1].x, points[1].y);
        }
    }
}
