using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.Mobiles;

namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomLounge : Room
    {
        public RoomLounge(int x, int y) : base(x, y)
        {
            Type = RoomType.Facility; 
            Name = "Lounge Room";
        }

        public override object ActOnEntry(Botling botling)
        {

            // TO:DO
            return null;
        }
    }
}
