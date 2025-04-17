using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;


namespace IAcademyOfDoom.Logic.Places
{
    internal class RoomRest : Room
    {
        public RoomRest(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = "Rest Room";
            HP = Default.BaseProfHitPoints;
        }

        public override object ActOnEntry(Botling botling)
        {
            int hpInit = Default.BaseHitPoints(Game.Difficulty);
            int hpLost = hpInit - botling.HP;

            if (hpLost > 0) {

                
                botling.HP += hpLost / 2;


            }
            return null;
        }
    }
}
