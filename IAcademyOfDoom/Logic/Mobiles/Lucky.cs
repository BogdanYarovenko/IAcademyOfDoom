using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Lucky
    /// </summary>
    public class Lucky : Botling
    {
        /// <summary>
        /// Constructor for the Lucky class
        /// </summary>
        public Lucky() : base(BotType.Lucky)
        {
           HP -= 2;
        }

        /// <summary>
        /// Overrides the move method for Lucky
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
       
    }
}

