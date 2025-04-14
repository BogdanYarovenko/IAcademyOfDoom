namespace IAcademyOfDoom.Logic.Actions
{
    /// <summary>
    /// Represents a logical action that can be performed in the game.
    /// </summary>
    public class GameAction
    {
        /// <summary>
        /// The name or label of the action.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Optional description of what the action does.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Optional cost of performing the action (energy, points, etc.)
        /// </summary>
        public int Cost { get; private set; }

        /// <summary>
        /// Whether the action is currently available or not.
        /// </summary>
        public bool IsAvailable { get; set; }

     

        /// <summary>
        /// Constructor.
        /// </summary>
        public GameAction(string name, string description, int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
           
            IsAvailable = true;
        }

      

        public override string ToString()
        {
            return $"{Name} ({Cost})";
        }
    }

   
}
