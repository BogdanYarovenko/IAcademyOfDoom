using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.Logic.Skills;
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

        public override bool actionOnRoom(Room targetRoom) => false;

        public override bool actionOnBotling(Botling targetBotling)
        {
            foreach (SkillType skillType in targetBotling.Skills.Keys) {
                targetBotling.Skills[skillType] += 1;
            }
            return true;
        }
        public override string GetActionEffectMessage()
        {
            return "All AIs on a tile gain +1 in all skills";
        }
    }

}
