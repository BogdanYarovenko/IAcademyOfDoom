using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;


namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomTutor : Room
    {
        public RoomTutor(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Tutor Room";
            HP = Default.BaseProfHitPoints;
        }

        public override object ActOnEntry(Botling botling)
        {
            return null;
        }
    }
}
