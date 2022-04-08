using Project_01_Snake_Csharp.Enums;
using System;
using System.Linq;

namespace Project_01_Snake_Csharp
{
    /// <summary>
    /// Snake derived class.
    /// </summary>
    public class Snake : Shape
    {
        // The direction of the snake movement.
        private DirectionType _direction;

        /// <summary>
        /// Creating the snake.
        /// </summary>
        /// <param name="length">The snake length.</param>
        /// <param name="snakeTail">The snake tail point.</param>
        /// <param name="direction">The direction of the snake movement.</param>
        public void CreateSnake(int length, Point snakeTail, DirectionType direction)
        {
            _direction = direction;

            for (int i = 0; i < length; i++)
            {
                Point point = new Point(snakeTail);
                point.SetDirection(i, direction);
                _points.Add(point);
            }
        }

        /// <summary>
        /// The snake movement.
        /// </summary>
        public void Move()
        {
            Point tail = _points.First();
            _points.Remove(tail);

            Point head = new Point(_points.Last());
            head.SetDirection(1, _direction);
            _points.Add(head);

            tail.ClearPoint();
            head.DrawPoint();
        }

        /// <summary>
        /// Seting direction of movement by pressing the key.
        /// </summary>
        /// <param name="key">The pressed arrow key.</param>
        public void PressKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                _direction = DirectionType.Left;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                _direction = DirectionType.Right;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                _direction = DirectionType.Down;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                _direction = DirectionType.Up;
            }
        }

        /// <summary>
        /// The fact of intersection of the head and tail of the snake.
        /// </summary>
        /// <returns>The fact of intersection</returns>
        public bool CollisionWithOwnTail()
        {
            Point head = _points.Last();

            for (int i = 0; i < _points.Count - 1; i++)
            {
                if (head.ComparePoints(_points[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// The fact of intersection of the head of snake and food.
        /// </summary>
        /// <param name="food">The food of snake.</param>
        /// <returns>The fact of intersection.</returns>
        public bool Eat(Point food)
        {
            Point head = new Point(_points.Last());
            head.SetDirection(1, _direction);

            if (head.ComparePoints(food))
            {
                food.Symbol = head.Symbol;
                _points.Add(food);
                return true;
            }

            return false;
        }
    }
}
