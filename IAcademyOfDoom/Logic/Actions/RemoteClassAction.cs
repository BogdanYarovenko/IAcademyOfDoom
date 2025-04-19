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
    public class RemoteClassAction : GameAction
    {
      public SkillType skillName { get; }

        public RemoteClassAction(SkillType skill)
            : base($"Remote Class - {skill}", ActionType.RemoteClass, 5)
        {
            skillName = skill;
        }

        public override bool actionOnBotling(Botling targetBotling){
            targetBotling.HP -= 1;
            if (targetBotling.Skills.ContainsKey(skillName))
            {
                targetBotling.Skills[skillName] += 1;
            }
            return true;
        }

        public override bool actionOnRoom(Room targetRoom) => false;
    }

}
