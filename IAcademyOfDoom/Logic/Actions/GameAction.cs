
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

        public string GetActionEffectMessage(ActionType actionType)
        {
            string effect = "";

            switch (actionType)
            {
                case ActionType.RoomRepair:
                    effect = "Fully heals a targeted classroom";
                    break;

                case ActionType.EminentVisitor:
                    effect = "All teachers regain 5 HP";
                    break;

                case ActionType.TeacherStrike:
                    effect = "No classes next turn, all teachers regain 10 HP";
                    break;

                case ActionType.StudentStrike:
                    effect = "All AIs gain 3 HP, teachers lose 1 HP per AI in their room";
                    break;

                case ActionType.Holidays:
                    effect = "All teachers and AIs gain 2 HP";
                    break;

                case ActionType.RemedialCourse:
                    effect = "All AIs on a tile gain +1 in all skills";
                    break;

                case ActionType.RemoteClass:
                    effect = "All AIs lose 1 HP and get a class in the targeted skill";
                    break;

                case ActionType.BudgetCuts:
                    effect = "Teachers lose 50% current HP (rounded up), total HP lost is converted to money";
                    break;

                case ActionType.MassiveCorruption:
                    effect = "All AIs lose 3 HP; removed AIs generate money";
                    break;

                case ActionType.JuryLeniency:
                    effect = "All exams next turn are automatically passed";
                    break;

                case ActionType.SuddenReform:
                    effect = "All rooms are randomly reassigned (except spawn and exam rooms)";
                    break;

                default:
                    effect = "Unknown effect";
                    break;
            }

            return $"Effect: {effect} ";
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
