using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;


namespace IAcademyOfDoom.Logic.Places
{
    public class RoomTutor : ProfRoom
    {
        public RoomTutor(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Tutor Room";
        }

        public override object ActOnEntry(Botling botling)
        {
            return base.ActOnEntry(botling);
        }
    }
}
