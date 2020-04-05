using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Circle : Shape
    {
        public float rad;
        public Point center;
        public Color color;

        public Circle(float xVal, float yVal, float radius, Color col)
        {
            center = new Point(xVal, yVal);
            rad = radius;
            color = col;
        }
        
        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            SolidBrush brush = new SolidBrush(color);
            graph.FillEllipse(brush, center.x - rad, center.y - rad, rad, rad);
        }
    }
}
