using System;

namespace Project_01_Snake_Csharp
{
    public class Point
    {
        private readonly int _left;
        private readonly int _top;
        private readonly char _symbol;

        public Point(int left, int top, char symbol)
        {
            _left = left;
            _top = top;
            _symbol = symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(_left, _top);
            Console.Write(_symbol);
        }
    }
}
