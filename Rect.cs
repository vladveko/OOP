using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Rect:Shape
    {
        public float width;
        public float height;
        public Point[] points;
        public Color color;

        public Rect(float x1Val, float y1Val, float x2Val, float y2Val, Color col)
        {
            points = new Point[4];
            width = x2Val - x1Val;
            height = y2Val - y1Val;
            points[0] = new Point(x1Val, y1Val);
            points[1] = new Point(x2Val, y1Val);
            points[2] = new Point(x2Val, y2Val);
            points[3] = new Point(x1Val, y2Val);
            color = col;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush brush = new SolidBrush(color);
            graph.FillRectangle(brush, points[0].x, points[0].y, height, width);
        }
    }
}
