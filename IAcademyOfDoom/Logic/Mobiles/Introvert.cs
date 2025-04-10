using IAcademyOfDoom.Logic.GameSequence;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Introvert
    /// </summary>
    public class Introvert : Botling
    {
        /// <summary>
        /// Constructor for the Introvert class
        /// </summary>
        public Introvert() : base(BotType.Introvert) { }

        /// <summary>
        /// Determines the next position to reach from the current position.
        /// The method chooses between moving right or down depending on the available rooms, proximity to walls,
        /// and whether the room is not occupied by another bot.
        /// If no rooms are found, it selects the direction with the most free space or chooses the direction that is least close to a wall.
        /// </summary>
        /// <returns>A tuple (x, y) representing the new coordinates of the next position.</returns>
        protected override (int x, int y) Next()
        {
            bool isRight = (!c.IsRoomOccupiedByBot(X + 1, Y) || c.IsRoomHere(X + 1, Y)?.Type == RoomType.Cycle) && isInMap(X + 1, Y);
            bool isBottom = (!c.IsRoomOccupiedByBot(X, Y + 1) || c.IsRoomHere(X, Y + 1)?.Type == RoomType.Cycle) && isInMap(X, Y + 1);
           
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
            return (X, Y);
        }
    }
}
