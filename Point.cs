using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    [Serializable]
    public class Point
    {
        public float x;
        public float y;
        public Color color;

        public Point()
        { }

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
    }
}
