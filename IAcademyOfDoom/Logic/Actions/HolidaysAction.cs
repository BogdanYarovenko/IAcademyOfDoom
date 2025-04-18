using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class HolidaysAction : GameAction
    {
        public HolidaysAction()
            : base("Holidays", ActionType.Holidays, 5) { }

        public override bool actionOnBotling(Botling targetBotling) => true;

        public override bool actionOnRoom(Room targetRoom) => false;
    }

}
