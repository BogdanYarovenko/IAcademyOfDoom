using IAcademyOfDoom.Logic.Skills;

namespace IAcademyOfDoom.Logic.Places
{
    /// <summary>
    /// Class stub for a possible buyable item that could be placed.
    /// </summary>
    public class Buyable
    {
        public RoomType RoomType { get; }
        public int Price { get; }
        public string Name { get; }
        public SkillType? Skill { get; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="roomType"></param>
        /// <param name="price"></param>
        /// <param name="name"></param>
        /// <param name="skill"></param>
        public Buyable(RoomType roomType, int price, string name = null, SkillType? skill = null)
        {
            RoomType = roomType;
            Price = price;
            Name = name;
            Skill = skill;
        }

        /// <summary>
        /// Turns this into a placeable item.
        /// </summary>
        /// <returns>null</returns>
        public Placeable MakePlaceable()
        {
            return new Placeable(RoomType, Skill, Name);
        }

        /// <summary>
        /// Returns a string representation of the Buyable object.
        /// </summary>
        /// <returns>String describing the buyable item.</returns>
        public override string ToString()
        {
            return $"Buyable: {Name ?? "Unnamed"}, Type: {RoomType}, Price: {Price}, Skill: {Skill?.ToString() ?? "None"}";
        }
    }
}
