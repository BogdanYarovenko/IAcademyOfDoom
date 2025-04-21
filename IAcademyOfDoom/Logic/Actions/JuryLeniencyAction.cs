using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Actions
{
    public class JuryLeniencyAction : GameAction
    {
        public JuryLeniencyAction()
            : base("Jury Leniency", ActionType.JuryLeniency, 5) { }

        public override bool actionOnBotling(Botling targetBotling) {
           // TODO
            return true;
        
        } 

        public override bool actionOnRoom(Room targetRoom) => false;

        public override string GetActionEffectMessage()
        {
            return "All exams next turn are automatically passed";
        }
    }

}
