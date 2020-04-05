using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Point:Shape
    {
        public float x;
        public float y;
        public Color color;

        public Point(float xValue, float yValue, Color col)
        {
            x = xValue;
            y = yValue;
            color = col;
        }
        public Point(float xValue, float yValue)
        {
            x = xValue;
            y = yValue;
        }

        public override void Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(color);
            graph.DrawLine(pen, x, y, x + 1, y + 1);
        }
    }
}
