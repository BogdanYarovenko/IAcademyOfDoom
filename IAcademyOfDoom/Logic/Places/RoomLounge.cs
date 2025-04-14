using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.Logic.Places
{
    // AKA Party room
    internal class RoomLounge : Room
    {
        public RoomLounge(int x, int y) : base(x, y)
        {
            Type = RoomType.Facility; 
            Name = "Lounge Room";
        }

        public override object ActOnEntry(Botling botling)
        {


          /*  foreach (SkillType skill in botling.Skills) { 
            
            }*/

            // TO:DO
            return null;
        }
    }
}
