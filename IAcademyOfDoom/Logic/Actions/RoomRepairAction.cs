using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class RoomRepairAction : GameAction
    {
        public RoomRepairAction()
            : base("Room Repair", ActionType.RoomRepair, 5) { }

        public override bool actionOnRoom(Room targetRoom)
        { 
            targetRoom.HP = GameSettings.Default.BaseProfHitPoints;
            return true;
        }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override string GetActionEffectMessage()
        {
            return "Effect: Fully heals a targeted classroom";
        }
    }

}

