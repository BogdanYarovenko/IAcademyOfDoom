using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomOrientation : Room
    {
        public RoomOrientation(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Orientation Office";
        }

        public override object ActOnEntry(Botling botling)
        {
            //Page 33
            int compare = -1;
            SkillType? weakestSkill = null;

            foreach (KeyValuePair<SkillType, int> skillEntry in botling.Skills)
            {
                if (skillEntry.Key.IsBaseSkill())
                {
                    if (skillEntry.Value < compare)
                    {
                        compare = skillEntry.Value;
                        weakestSkill = skillEntry.Key;
                    }
                }
            }

            // TO:DO -> Orienté le botling 

            if (weakestSkill.HasValue) { 
            
            
            }

            return null;
        }

    }
}