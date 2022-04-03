using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_01_Snake_Csharp
{
    public class Shape
    {
        protected List<Point> _points;

        public Shape()
        {
            _points = new List<Point>();
        }

        public void DrawLine()
        {
            foreach (var point in _points)
            {
                point.DrawPoint();
            }
        }
    }
}
