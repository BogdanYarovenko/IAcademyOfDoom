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

        public override bool actionOnBotling(Botling targetBotling)
        {
            targetBotling.HP += 2;
            return true;

        }

        public override bool actionOnRoom(Room targetRoom)
        {
            targetRoom.HP += 2;
            return true;
        }

        public override string GetActionEffectMessage()
        {
            return "All teachers and AIs gain 2 HP";
        }
    }

}
