using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Square:Shape
    {
        public float sideLen;
        public Point[] points;
        public Color color;

        public Square(float xVal, float yVal, float len, Color col)
        {
            sideLen = len;
            points = new Point[4];
            points[0] = new Point(xVal, yVal);
            points[1] = new Point(xVal + len, yVal);
            points[2] = new Point(xVal + len, yVal + len);
            points[3] = new Point(xVal, yVal + len);
            color = col;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush brush = new SolidBrush(color);
            graph.FillRectangle(brush, points[0].x, points[0].y, sideLen, sideLen);
        }
    }
}
