using IAcademyOfDoom.Logic.Places;
using System.Collections.Generic;

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


        public ActionType Type { get; private set; } 

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
        public GameAction(string name, ActionType type,  int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;
           
            IsAvailable = true;
        }




        public override string ToString() => $"{Name}:{Type} ~~ ({Cost})";


    }

   
}
