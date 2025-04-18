using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class RemoteClassAction : GameAction
    {
        private string skillName;

        public RemoteClassAction(string skill)
            : base($"Remote Class - {skill}", ActionType.RemoteClass, 5)
        {
            skillName = skill;
        }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override bool actionOnRoom(Room targetRoom) => false;
    }

}
