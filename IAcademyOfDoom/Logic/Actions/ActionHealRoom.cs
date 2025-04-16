using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    class ActionHealRoom : GameAction
    {
        public ActionHealRoom(string name, ActionType type, int cost): base(name, type, cost) { }

        public override bool actionOnRoom(Room targetRoom)
        {
            targetRoom.HP = GameSettings.Default.BaseProfHitPoints;

            return true;
        }

        public override bool actionOnBotling(Botling targetBotling)
        {
            return false;
        }
    }
}
