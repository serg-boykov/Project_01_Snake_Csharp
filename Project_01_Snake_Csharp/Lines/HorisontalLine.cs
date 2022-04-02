using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.Lines
{
    public class HorisontalLine : Shape
    {
        public HorisontalLine(int left, int top, int count, char symbol)
        {
            _points = new List<Point>();

            for (int i = left; i < left + count; i++)
            {
                Point point = new Point(i, top, symbol);
                _points.Add(point);
            }
        }
    }
}
