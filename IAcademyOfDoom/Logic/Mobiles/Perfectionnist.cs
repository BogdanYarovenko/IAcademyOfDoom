using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Perfectionnist
    /// /// </summary>
    public class Perfectionnist : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Perfectionnist
        /// </summary>
        public Perfectionnist() : base(BotType.Perfectionnist)
        {
        }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour le Perfectionnist
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
        /// <summary>
        /// Si le botling se trouve dans une salle et que l'examen échoue, il reste dans sa position actuelle. 
        /// Sinon, il poursuit avec la logique de mouvement par défaut.
        /// </summary>
        /// <returns>
        /// Un tuple représentant les coordonnées (x, y) du prochain mouvement du botling.
        /// </returns>
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
