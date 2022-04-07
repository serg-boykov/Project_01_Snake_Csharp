using Project_01_Snake_Csharp.Lines;
using System.Collections.Generic;

namespace Project_01_Snake_Csharp.Installers
{
    public class LineInstaller
    {
        private List<Shape> _shapes;

        /// <summary>
        /// Initialization of the game area using horizontal and vertical lines.
        /// </summary>
        public LineInstaller()
        {
            _shapes = new List<Shape>();

            HorisontalLine upHLine = new HorisontalLine(0, 0, 120, '-');
            HorisontalLine dnHLine = new HorisontalLine(0, 20, 120, '-');

            VerticalLine lfVLine = new VerticalLine(0, 1, 19, '|');
            VerticalLine rtVLine = new VerticalLine(119, 1, 19, '|');

            _shapes.AddRange(new List<Shape>() { upHLine, dnHLine, lfVLine, rtVLine });
        }

        /// <summary>
        /// Drawing the game area on the screen.
        /// </summary>
        public void DrawShape()
        {
            foreach (var shape in _shapes)
            {
                shape.DrawLine();
            }
        }

        /// <summary>
        /// The fact of intersection of Shape objects.
        /// </summary>
        /// <param name="shape">The Shape object.</param>
        /// <returns>The fact of intersection</returns>
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
