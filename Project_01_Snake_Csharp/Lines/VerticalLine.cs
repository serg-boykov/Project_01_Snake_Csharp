using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp.Lines
{
    public class VerticalLine : Shape

    {
        public VerticalLine(int left, int top, int count, char symbol)
    {
        _points = new List<Point>();

        for (int i = top; i < top + count; i++)
        {
            Point point = new Point(left, i, symbol);
            _points.Add(point);
        }
    }
    }
}
