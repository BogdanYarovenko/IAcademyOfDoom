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
            String nameOfTheSkill = " ";

            foreach (SkillType skill in botling.Skills.Keys)
            {
                if (compare > botling.Skills[skill])
                {
                    compare = botling.Skills[skill];
                    nameOfTheSkill = skill.ToString();
                }
            }

            // TO:DO -> Orienté le botling

            return null;
        }

    }
}