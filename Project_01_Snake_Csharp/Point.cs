using Project_01_Snake_Csharp.Enums;
using System;

namespace Project_01_Snake_Csharp
{
    public class Point
    {
        private int _left, _top;
        private char _symbol;

        public char Symbol
        {
            get { return  _symbol; }
            set { _symbol = value; }
        }

        public Point(Point snakeTail)
        {
            _left = snakeTail._left;
            _top = snakeTail._top;
            _symbol = snakeTail._symbol;
        }

        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            _symbol = symbol;
        }

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

        public void ClearPoint()
        {
            _symbol = ' ';
            DrawPoint();
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.Write(_symbol);
        }

        internal bool ComparePoints(Point food)
        {
            return food._left == _left && food._top == _top;
        }
    }
}
