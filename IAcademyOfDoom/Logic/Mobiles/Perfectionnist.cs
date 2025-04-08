using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Speedster, qui se déplace rapidement vers sa cible et perd des points de vie en fonction de la distance.
    /// </summary>
    public class Perfectionnist : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Speedster.
        /// </summary>
        public Perfectionnist() : base(BotType.Perfectionnist)
        {
        }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour que le Speedster se déplace directement vers un mur ou une salle dans la direction visée.
        /// </summary>
        public override void Move()
        {
            base.Move();
        }

        protected override (int x, int y) Next()
        {
            if (c.IsRoomHere(X, Y, false) != null)
            {
                ExamResult res = Exam();
                if (res != ExamResult.Success)
                    return (X, Y);
            }
            
            return base.Next();
        }
    }
}
