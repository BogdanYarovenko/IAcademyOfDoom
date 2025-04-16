
using IAcademyOfDoom.Logic.Places;
using System.Collections.Generic;
using IAcademyOfDoom.Logic.Mobiles;
using System.Collections.ObjectModel;

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

        public void actionOnRooms(Collection<Room> rooms)
        {
            foreach (Room room in rooms)
            {
                actionOnRoom(room);
            }
        }

        public void actionOnBotlings(Collection<Botling> botlings)
        {
            foreach (Botling bot in botlings)
            {
                actionOnBotling(bot);
            }
        }

        public virtual bool actionOnRoom(Room targetRoom)
        {
            return false; 
        }

        public virtual bool actionOnBotling(Botling targetBotling)
        {
            return false;
        }

        public override string ToString() => $"{Name}:{Type} ~~ ({Cost})";


    }

   
}
