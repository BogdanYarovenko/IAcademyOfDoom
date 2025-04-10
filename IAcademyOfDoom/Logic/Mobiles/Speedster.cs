using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Speedster.
    /// </summary>
    public class Speedster : Botling
    {
        /// <summary>
        /// Constructor for the Speedster class.
        /// </summary>
        public Speedster() : base(BotType.Speedster)
        {
        }

        /// <summary>
        /// Overrides the move method for the Speedster.
        /// </summary>
        public override void Move()
        {
            int deltaX = NextMove.x - X;
            int deltaY = NextMove.y - Y;

            int distance = Math.Abs(deltaX) + Math.Abs(deltaY);

            if (distance > 1)
            {
                HP--;
            }

            base.Move();
        }

        /// <summary>
        /// Determines the next position to reach from the current position.
        /// The method chooses between moving right or down depending on the available rooms and proximity to a wall.
        /// If no rooms are found, it selects the direction with the most free space, or chooses the direction that is least close to a wall.
        /// </summary>
        /// <returns>A tuple (x, y) representing the new coordinates of the next position.</returns>
        protected override (int x, int y) Next()
        {
            bool isRight = c.IsRoomHere(X + 1, Y) != null;
            bool isBottom = c.IsRoomHere(X, Y + 1) != null;

            if (isRight && isBottom)
            {
                if (Game.Random.Next() % 2 == 0)
                    return (X + 1, Y);
                return (X, Y + 1);
            }
            else if (isRight)
            {
                return (X + 1, Y);
            }
            else if (isBottom)
            {
                return (X, Y + 1);
            }
            else if (!isNextToWall(X, Y))
            {
                if (Game.MaxX - X < Game.MaxY - Y)
                    return (X + 1, Y);
                return (X, Y + 1);
            }
            else
            {
                isRight = isNextToWall(X + 1, Y);
                isBottom = isNextToWall(X, Y + 1);
                if (isRight && isBottom)
                {
                    if (Game.Random.Next() % 2 == 0)
                        return (X + 1, Y);
                    return (X, Y + 1);
                }
                else if (isRight)
                {
                    return (X + 1, Y);
                }
                else if (isBottom)
                {
                    return (X, Y + 1);
                }
            }
            return (X, Y);
        }

        /// <summary>
        /// Checks if the specified position is next to a wall.
        /// The walls are defined by the edges of the game (based on Game.MaxX and Game.MaxY).
        /// </summary>
        /// <param name="x">The x-coordinate of the position to check.</param>
        /// <param name="y">The y-coordinate of the position to check.</param>
        /// <returns>Returns true if the position is next to a wall, otherwise false.</returns>
        private bool isNextToWall(int x, int y)
        {
            return ((x <= Game.MaxX && y == 0) || (y <= Game.MaxY && x == 0) || (x == Game.MaxX && y <= Game.MaxY) || (y == Game.MaxY && x <= Game.MaxX));
        }
    }
}