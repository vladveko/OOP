﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ShapeClass;

namespace labFigures
{
    [Serializable]
    public class Ellipse : Shape
    {
        public float a, b;
        public PointF center;
        public Color color;
        // Переменная, определяющая фигура залита или нет
        public bool fill;

        public Ellipse()
        { }

        public Ellipse(float x1Val, float y1Val, float x2Val, float y2Val, Color col, bool f)
        {
            a = Math.Abs(x1Val - x2Val);
            b = Math.Abs(y1Val - y2Val);
            center = new PointF(x1Val, y1Val);
            color = col;
            fill = f;
        }

        public static void Preview(PointF p1Val, PointF p2Val, Graphics g, Color color, bool fill)
        {
            
            float a = Math.Abs(p1Val.X - p2Val.X);
            float b = Math.Abs(p1Val.Y - p2Val.Y);
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                g.FillEllipse(brush, p1Val.X - a, p1Val.Y - b, 2 * a, 2 * b);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                g.DrawEllipse(pen, p1Val.X - a, p1Val.Y - b, 2 * a, 2 * b);
            }
            
        }

        public override void Draw(Graphics graph)
        {
            if (fill)
            {
                SolidBrush brush = new SolidBrush(color);
                graph.FillEllipse(brush, center.X - a, center.Y - b, 2*a, 2*b);
            }
            else
            {
                Pen pen = new Pen(color, 2);
                graph.DrawEllipse(pen, center.X - a, center.Y - b, 2*a, 2*b);
            }
        }
    }
}
