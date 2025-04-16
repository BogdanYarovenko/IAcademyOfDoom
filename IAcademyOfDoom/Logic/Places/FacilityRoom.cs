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
    public class FacilityRoom : Room
    {
        public FacilityRoom(int x, int y, int hP) : base(x, y, hP)
        {
            Type = RoomType.Facility;
        }

        public override object ActOnEntry(Botling botling)
        {
            return botling.GetLessonIn(SkillType.Analyse);
        }
    }
}
