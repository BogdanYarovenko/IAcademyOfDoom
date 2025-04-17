using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class RemedialCourseAction : GameAction
    {
        public RemedialCourseAction()
            : base("Remedial Course", ActionType.RemedialCourse, 5) { }

        public override bool actionOnRoom(Room targetRoom) => true;

        public override bool actionOnBotling(Botling targetBotling) => false;
    }

}
