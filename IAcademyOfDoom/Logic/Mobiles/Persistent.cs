using IAcademyOfDoom.Logic.Places;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// A class representing a bot of type Persistent
    /// </summary>
    public class Persistent : Botling
    {
        /// <summary>
        /// Constructor for the Persistent class
        /// </summary>
        public Persistent() : base(BotType.Persistent)
        { }

        /// <summary>
        /// Overrides the move method for Persistent
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
        protected override (int x, int y) Next()
        {
            
            if (NextMove.x == Room.ExamRoom().X && NextMove.y == Room.ExamRoom().Y)
            {
                ExamResult finalExam = this.Exam();
                if (finalExam == ExamResult.Failure)
                {
                  
                    return (0, 0);
                }
            }
       
            return base.Next();
        }
    }
}
