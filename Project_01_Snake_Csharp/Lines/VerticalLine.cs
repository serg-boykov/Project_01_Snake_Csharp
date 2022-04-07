namespace Project_01_Snake_Csharp.Lines
{
    public class VerticalLine : Shape
    {
        /// <summary>
        /// Create the vertical line as the list of points.
        /// </summary>
        /// <param name="left">The coordinate -=left=- of the first point of the vertical line.</param>
        /// <param name="top">The coordinate -=top=- of the first point of the vertical line.</param>
        /// <param name="count">Number of points of the vertical line.</param>
        /// <param name="symbol">The character of the vertical line.</param>
        public VerticalLine(int left, int top, int count, char symbol)
        {
            for (int i = top; i < top + count; i++)
            {
                Point point = new Point(left, i, symbol);
                _points.Add(point);
            }
        }
    }
}
