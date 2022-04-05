using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_01_Snake_Csharp.Lines;

namespace Project_01_Snake_Csharp.Installers
{
    public class LineInstaller
    {
        private List<Shape> _shapes;

        public LineInstaller()
        {
            _shapes = new List<Shape>();

            HorisontalLine upHLine = new HorisontalLine(0, 0, 120, '-');
            HorisontalLine dnHLine = new HorisontalLine(0, 20, 120, '-');

            VerticalLine lfVLine = new VerticalLine(0, 1, 19, '|');
            VerticalLine rtVLine = new VerticalLine(119, 1, 19, '|');

            _shapes.AddRange(new List<Shape>() {upHLine, dnHLine, lfVLine, rtVLine});
        }

        public void DrawShape()
        {
            foreach (var shape in _shapes)
            {
                shape.DrawLine();
            }
        }

        public bool Collision(Shape shape)
        {
            foreach (var item in _shapes)
            {
                if (item.Collision(shape))
                    return true;
            }

            return false;
        }
    }
}
