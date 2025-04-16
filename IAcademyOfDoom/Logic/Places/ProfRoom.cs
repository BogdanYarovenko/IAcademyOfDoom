using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.Logic.Places
{
    /// <summary>
    /// A room for professors or tutors in a given skill.
    /// </summary>
    public class ProfRoom : Room
    {
        /// <summary>
        /// The skill taught in this room.
        /// </summary>
        public SkillType SkillType {  get; set; }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="x">the column</param>
        /// <param name="y">the row</param>
        public ProfRoom(int x, int y, int HP) : base(x, y, HP)
        {
            Type = RoomType.Prof;
            HP = Default.BaseProfHitPoints;
        }
        /// <summary>
        /// Override method: a botling entering this room is lectured.
        /// The room may also be destroyed
        /// </summary>
        /// <param name="botling">the botling entering this room</param>
        /// <returns>the result of the lesson - actual type: bool</returns>
        public override object ActOnEntry(Botling botling)
        {
            this.HP--;
            if (this.HP <=0)
            {
                Controller.Instance.DestroyRoom(this);
            }
            return botling.GetLessonIn(SkillType);
        }
    }
}
