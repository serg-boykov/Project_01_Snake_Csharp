using System.Collections.Generic;

namespace Project_01_Snake_Csharp
{
    /// <summary>
    /// Base class of point's list.
    /// </summary>
    public class Shape
    {
        protected List<Point> _points;

        public Shape()
        {
            _points = new List<Point>();
        }

        /// <summary>
        /// Drawing the point's line.
        /// </summary>
        public void DrawLine()
        {
            foreach (var point in _points)
            {
                point.DrawPoint();
            }
        }

        /// <summary>
        /// The fact of contact any line of the game area
        /// with the head of the snake.
        /// </summary>
        /// <param name="shape">The list of points.</param>
        /// <returns>The fact of the contact of two points.</returns>
        public bool Collision(Shape shape)
        {
            foreach (var item in _points)
            {
                if (shape.ComparePoints(item))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point">The screen point.</param>
        /// <returns>The fact of the contact of two points.</returns>
        private bool ComparePoints(Point point)
        {
            foreach (var item in _points)
            {
                if (point.ComparePoints(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
