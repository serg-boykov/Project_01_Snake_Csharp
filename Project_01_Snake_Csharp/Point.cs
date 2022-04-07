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
        // Point symbol.
        private char _symbol;

        /// <summary>
        /// Property of a point symbol.
        /// </summary>
        public char Symbol
        {
            get { return  _symbol; }
            set { _symbol = value; }
        }

        // Initialization by the point.
        public Point(Point snakeTail)
        {
            _left = snakeTail._left;
            _top = snakeTail._top;
            _symbol = snakeTail._symbol;
        }

        // Initialization by coordinates.
        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            _symbol = symbol;
        }

        /// <summary>
        /// Installation of the direction of snake's movement.
        /// </summary>
        /// <param name="i">Displacement of the coordinate.</param>
        /// <param name="direction">The direction of snake's movement.</param>
        public void SetDirection(int i, DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.Right:
                    _left += i; break;
                case DirectionEnum.Left:
                    _left -= i; break;
                case DirectionEnum.Down:
                    _top += i; break;
                case DirectionEnum.Up:
                    _top -= i; break;
            }
        }

        /// <summary>
        /// Cleaning the screen point.
        /// </summary>
        public void ClearPoint()
        {
            _symbol = ' ';
            DrawPoint();
        }

        /// <summary>
        /// Drawing the screen point by coordinates.
        /// </summary>
        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.Write(_symbol);
        }

        /// <summary>
        /// Comparison of the coordinates of two points.
        /// If coordinates are equal then return TRUE.
        /// Else return FALSE.
        /// </summary>
        /// <param name="point">Point for comparison.</param>
        /// <returns></returns>
        internal bool ComparePoints(Point point)
        {
            return point._left == _left && point._top == _top;
        }
    }
}
