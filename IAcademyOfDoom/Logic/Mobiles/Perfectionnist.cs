using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Perfectionist
    /// </summary>
    public class Perfectionnist : Botling
    {
        /// <summary>
        /// Constructor for the Perfectionist class
        /// </summary>
        public Perfectionnist() : base(BotType.Perfectionnist)
        {
        }

        /// <summary>
        /// If the bot is in a room and the exam fails, it stays in its current position.
        /// Otherwise, it proceeds with the default movement logic.
        /// </summary>
        /// <returns>
        /// A tuple representing the coordinates (x, y) of the next move for the bot.
        /// </returns>
        protected override (int x, int y) Next()
        {
            if (c.IsRoomHere(X, Y, false) != null)
            {
                ExamResult res = Exam();
                if (res != ExamResult.Success)
                    return (X, Y);
            }
            return base.Next();
        }
    }
}
