using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;


namespace IAcademyOfDoom.Logic.Places
{
    public class RoomRest : Room
    {
        public RoomRest(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Facility;
            Name = View.FrameTypeRoom.RestRoom.ToString();
        }

        public override object ActOnEntry(Botling botling)
        {
            this.HP--;
            if (this.HP <=0)
            {
                Controller.Instance.DestroyRoom(this);
            }
            int hpInit = Default.BaseHitPoints(Game.Difficulty);
            int hpLost = hpInit - botling.HP;

            if (hpLost > 0) {
                botling.HP += hpLost / 2;
            }
            return null;
        }
    }
}
