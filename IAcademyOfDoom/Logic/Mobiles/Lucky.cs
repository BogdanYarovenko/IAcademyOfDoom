using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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

        protected override (int x, int y) Next()
        { 
            int initDiceValue = Game.Dice();
            if (initDiceValue == 1)
            {
                initDiceValue += Game.Dice();
            }
            HP += initDiceValue;
            return base.Next();
        }

    }
}

