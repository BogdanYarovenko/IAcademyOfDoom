using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class TeacherStrikeAction : GameAction
    {
        public TeacherStrikeAction()
            : base("Teacher Strike", ActionType.TeacherStrike, 5) { }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override bool actionOnRoom(Room targetRoom) {
            targetRoom.HP += 10;

           // Add actOnEntry // TODO
            return true;
        }
    }

}
