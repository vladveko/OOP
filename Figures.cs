using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labFigures
{
    public class Figure
    {
        public List<Shape> list;

        public Figure()
        {
            list = new List<Shape>();
        }

        public int Draw(Graphics g)
        {
            if (list.Count == 0)
                return 0;
            else
            {
                //Shape obj = list[0];
                for (int i = 0; i<list.Count; i++)
                    list[i].Draw(g);
                return 1;
            }
        }
    }
}
