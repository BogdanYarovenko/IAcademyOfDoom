using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class SuddenReformAction : GameAction
    {
        public SuddenReformAction()
            : base("Sudden Reform", ActionType.SuddenReform, 5) { }

        public override bool actionOnRoom(Room targetRoom)
        {
            //TODO
            return true;
        }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override string GetActionEffectMessage()
        {
            return "All rooms are randomly reassigned (except spawn and exam rooms)";
        }
    }

}
