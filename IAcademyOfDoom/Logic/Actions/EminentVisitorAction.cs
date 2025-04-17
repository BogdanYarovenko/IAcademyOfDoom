using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class EminentVisitorAction : GameAction
    {
        public EminentVisitorAction()
            : base("Eminent Visitor", ActionType.EminentVisitor, 5) { }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override bool actionOnRoom(Room targetRoom) => true;
    }

}
