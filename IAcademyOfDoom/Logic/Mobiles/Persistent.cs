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

            if (IsAtExamRoom(NextMove))
            {
              //  ExamResult finalExam = Exam();
               //MessageBox.Show("ExamResult of Next " + finalExam);
                if (finalExam == ExamResult.Failure)
                {
                    X = 0;
                    Y = 0;

                }
            }
            return base.Next();
        }

        private bool IsAtExamRoom((int x, int y) move)
        {
            var examRoom = Room.ExamRoom();
            return move.x == examRoom.X && move.y == examRoom.Y;
        }
    }
   
}
