using IAcademyOfDoom.Logic.Mobiles;
using System;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Speedster, qui se déplace rapidement vers sa cible et perd des points de vie en fonction de la distance.
    /// </summary>
    public class Speedster : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Speedster.
        /// </summary>
        public Speedster() : base(BotType.Speedster)
        {
        }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour que le Speedster se déplace directement vers un mur ou une salle dans la direction visée.
        /// </summary>
        public override void Move()
        {
          

            int deltaX = NextMove.x - X;
            int deltaY = NextMove.y - Y;

            int distance = Math.Abs(deltaX) + Math.Abs(deltaY);

            if (distance > 1)
            {
                HP--; 
            }

          base.Move();  }
    }
}
