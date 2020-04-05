using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    class Ellipse : Shape
    {
        public float a, b;
        public Point center;
        public Color color;
        public Ellipse(float xVal, float yVal, float aVal, float bVal, Color col)
        {
            a = aVal;
            b = bVal;
            center = new Point(xVal, yVal);
            color = col;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush brush = new SolidBrush(color);
            graph.FillEllipse(brush, center.x - a, center.y - b, a, b);
        }
    }
}
