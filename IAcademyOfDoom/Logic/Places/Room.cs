using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Properties;
using System.Drawing;
using IAcademyOfDoom.App;
using IAcademyOfDoom.Logic.GameSequence;
using IAcademyOfDoom.Logic.GameSettings;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using IAcademyOfDoom.Logic.Skills;
using IAcademyOfDoom.View;
using System.Collections.Generic;


namespace IAcademyOfDoom.Logic.Places
{
    /// <summary>
    /// A class modelling a room placed in a cell of the grid.
    /// </summary>
    public class Room
    {
        protected bool m_isLesson = true;
        protected Controller c = Controller.Instance;
        /// <summary>
        /// The column.
        /// </summary>
        public int X {  get; private set; }
        /// <summary>
        /// The row.
        /// </summary>
        public int Y { get; private set; }
        
        /// <summary>
        /// Health point of this room
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// The type of the room.
        /// </summary>
        public RoomType Type { get; internal set; }

        /// <summary>
        /// Name of this room
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// List of botlings in this room
        /// </summary>
        public List<Botling> botlingsInTheRoom = new List<Botling>();

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="x">the column</param>
        /// <param name="y">the row</param>
        public Room(int x, int y, int hP)
        {
            X = x;
            Y = y;
            HP = Default.BaseProfHitPoints;
        }
        /// <summary>
        /// Factory method for the spawn area (top-left corner).
        /// </summary>
        /// <returns>a new spawn area room</returns>
        public static Room SpawnArea()
        {
            Room r = new Room(0, 0, Default.BaseProfHitPoints)
            {
                Name = "Spawn area",
                Type = RoomType.Cycle
            };
            return r;
        }
        /// <summary>
        /// Factory method for the exam room (bottom-right corner).
        /// </summary>
        /// <returns>a new exam room</returns>
        public static Room ExamRoom()
        {
            Room r = new Room(Game.MaxX, Game.MaxY , Default.BaseProfHitPoints)
            {
               Name = "Examination",
                Type = RoomType.Cycle
            };
            return r;
        }
        /// <summary>
        /// What happens when a botling enters this room.
        /// Virtual: can be overriden by subclasses; this code
        /// is only suitable for the exam room...
        /// </summary>
        /// <param name="botling">the botling entering the room</param>
        /// <returns>the result of the exam - actual type: ExamResult</returns>
        public virtual object ActOnEntry(Botling botling)
        {
            return botling.Exam();
        }

        /// <summary>
        /// Sets a bool value if there will be a lesson in this room or not
        /// </summary>
        /// <param name="isLesson">value if there will be a lesson</param>
        public void SetIsLessons(bool isLesson)
        {
            m_isLesson = isLesson;
        }
        
        /// <summary>
        /// Move to a specific position, if position is out of the map it doesn't change
        /// </summary>
        /// <param name="x">x position</param>
        /// <param name="y">y position</param>
        public void moveTo(int x, int y)
        {
            if (x >= 0 && x <= Game.MaxX && y >= 0 && y <= Game.MaxY)
            {   
                X = x;
                Y = y;
            }
        }

        /// <summary>
        /// Updates a list of botlings in this room
        /// </summary>
        public void updateBotlingsForRoom()
        {
            botlingsInTheRoom.Clear();
            foreach (Botling botling in c.getBotlings())
            {
                if (this.X == botling.X && this.Y == botling.Y)
                {
                    botlingsInTheRoom.Add(botling);
                }
            }
        }

        /// <summary>
        /// Number of botlings that are in this room
        /// </summary>
        /// <returns>Number of botlings in the room</returns>
        public int getNumberBotlings()
        {
            return botlingsInTheRoom.Count;
        }
    }
}
