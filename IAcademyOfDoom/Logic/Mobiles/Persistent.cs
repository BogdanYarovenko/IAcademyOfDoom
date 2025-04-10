using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Persistent
    /// </summary>
    public class Persistent : Botling
    {
        /// <summary>
        /// Constructor for the Persistent class
        /// </summary>
        public Persistent() : base(BotType.Persistent)
        { }

        /// <summary>
        /// Overrides the move method for Persistent
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
    }
}
