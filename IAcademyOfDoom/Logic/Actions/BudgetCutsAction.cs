using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class BudgetCutsAction : GameAction
    {
        public BudgetCutsAction()
            : base("Budget Cuts", ActionType.BudgetCuts, 5) { }

        public override bool actionOnBotling(Botling targetBotling) => false;

        public override bool actionOnRoom(Room targetRoom) => false;
    }

}
