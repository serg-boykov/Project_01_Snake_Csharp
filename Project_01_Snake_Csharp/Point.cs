using Project_01_Snake_Csharp.Enums;
using System;

namespace Project_01_Snake_Csharp
{
    /// <summary>
    /// Class of screen points.
    /// </summary>
    public class Point
    {
        // Point position.
        private int _left, _top;

        /// <summary>
        /// Property of a point symbol.
        /// </summary>
        public char Symbol { get; set; }

        // Initialization by the point.
        public Point(Point snakeTail)
        {
            _left = snakeTail._left;
            _top = snakeTail._top;
            Symbol = snakeTail.Symbol;
        }

        // Initialization by coordinates.
        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            Symbol = symbol;
        }

        /// <summary>
        /// Installation of the direction of snake's movement.
        /// </summary>
        /// <param name="shift">Displacement of the coordinate.</param>
        /// <param name="direction">The direction of snake movement.</param>
        public void SetDirection(int shift, DirectionType direction)
        {
            switch (direction)
            {
                case DirectionType.Right:
                    _left += shift;
                    break;

                case DirectionType.Left:
                    _left -= shift;
                    break;

                case DirectionType.Down:
                    _top += shift;
                    break;

                case DirectionType.Up:
                    _top -= shift;
                    break;
            }
        }

        /// <summary>
        /// Cleaning the screen point.
        /// </summary>
        public void ClearPoint()
        {
            Symbol = ' ';
            DrawPoint();
        }

        /// <summary>
        /// Drawing the screen point by coordinates.
        /// </summary>
        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.Write(Symbol);
        }

        /// <summary>
        /// Comparison of the coordinates of two points.
        /// If coordinates are equal then return TRUE.
        /// Else return FALSE.
        /// </summary>
        /// <param name="point">Point for comparison.</param>
        /// <returns></returns>
        public bool ComparePoints(Point point)
            => point._left == _left && point._top == _top;
    }
}
