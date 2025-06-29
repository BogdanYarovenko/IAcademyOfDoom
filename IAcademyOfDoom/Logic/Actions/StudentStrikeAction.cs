﻿using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Actions
{
    public class StudentStrikeAction : GameAction
    {
        public StudentStrikeAction() : base("Student Strike", ActionType.StudentStrike, 5) { }

        public override bool actionOnRoom(Room targetRoom) {
           
            targetRoom.updateBotlingsForRoom();
            targetRoom.HP -= targetRoom.getNumberBotlings();
            return true;
        }

        public override bool actionOnBotling(Botling targetBotling) {
            targetBotling.HP += 3;
            return true;
        }

        public override string GetActionEffectMessage()
        {
            return "All AIs gain 3 HP, teachers lose 1 HP per AI in their room";
        }
    }
}
