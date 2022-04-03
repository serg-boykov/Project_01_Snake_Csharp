using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_01_Snake_Csharp.Enums;

namespace Project_01_Snake_Csharp
{
    public class Snake : Shape
    {
        public void CreateSnake(int length, Point snakeTail, DirectionEnum direction)
        {
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(snakeTail);
                point.SetDirection(i, direction);
                _points.Add(point);
            }
        }
    }
}
