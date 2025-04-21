
using IAcademyOfDoom.Logic.Places;
using System.Collections.Generic;
using IAcademyOfDoom.Logic.Mobiles;
using System.Collections.ObjectModel;
using IAcademyOfDoom.App;
using System.Xml.Linq;
using System;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Actions
{
    /// <summary>
    /// Represents a logical action that can be performed in the game.
    /// </summary>
    public class GameAction
    {
        Controller c = Controller.Instance;
        /// <summary>
        /// The name or label of the action.
        /// </summary>
        public string Name { get; private set; }


        public ActionType Type { get; private set; }

        /// <summary>
        /// Optional cost of performing the action (energy, points, etc.)
        /// </summary>
        public int Cost { get; private set; } = 5;

        /// <summary>
        /// Whether the action is currently available or not.
        /// </summary>
        public bool IsAvailable { get; set; }



        /// <summary>
        /// Constructor.
        /// </summary>
        public GameAction(string name, ActionType type, int cost)
        {
            Name = name;
            Type = type;
            Cost = cost;

            IsAvailable = true;
        }

        public virtual string GetActionEffectMessage()
        {
            return $"Effect: Unknown effect";
        }



        public void actionOnRooms()
        {
            foreach (Room room in c.getRooms())
            {
                actionOnRoom(room);
            }
        }

        public void actionOnBotlings()
        {
            foreach (Botling bot in c.getBotlings())
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

        public override string ToString() => $"{Name}";


    }


}
