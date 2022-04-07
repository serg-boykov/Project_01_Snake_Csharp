namespace Project_01_Snake_Csharp.Lines
{
    public class HorisontalLine : Shape
    {
        /// <summary>
        /// Create the horisontal line as the list of points.
        /// </summary>
        /// <param name="left">The coordinate -=left=- of the first point of the horizontal line.</param>
        /// <param name="top">The coordinate -=top=- of the first point of the horizontal line.</param>
        /// <param name="count">Number of points of the horizontal line.</param>
        /// <param name="symbol">The character of the horizontal line.</param>
        public HorisontalLine(int left, int top, int count, char symbol)
        {
            for (int i = left; i < left + count; i++)
            {
                Point point = new Point(i, top, symbol);
                _points.Add(point);
            }
        }
    }
}
