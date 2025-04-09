using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Aimless
    /// </summary>
    public class Aimless : Botling
    {
        /// <summary>
        /// Constructor for the Aimless class
        /// </summary>
        public Aimless() : base(BotType.Aimless)
        { }

        /// <summary>
        /// Overrides the move method for the Aimless bot
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
    }

}
