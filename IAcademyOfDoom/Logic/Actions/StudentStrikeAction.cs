using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class StudentStrikeAction : GameAction
    {
        public StudentStrikeAction()
            : base("Student Strike", ActionType.StudentStrike, 5) { }

        public override bool actionOnRoom(Room targetRoom) {
            targetRoom.HP -= targetRoom.getNumberBotlings();

            return true;
        }

        public override bool actionOnBotling(Botling targetBotling) {
            targetBotling.HP += 3;
        return true;
        
        }
    }

}
