using System.Collections.Generic;
using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.Logic.Places
{
    public class RoomTutoring  : Room
    {
        public RoomTutoring(int x, int y, int HP) : base(x, y,HP)
        {
            Type = RoomType.Facility; 
            Name = "Lounge Room";
            HP = Default.BaseProfHitPoints;
        }
        
        public override object ActOnEntry(Botling botling)
        {

            return null;
        }
    }
}