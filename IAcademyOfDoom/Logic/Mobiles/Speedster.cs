using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
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

            base.Move();
        }

        protected override (int x, int y) Next()
        {
            if (c.IsRoomHere(X + 1, Y) != null)
            {
                return (X + 1, Y);
            }
            else if (c.IsRoomHere(X, Y + 1) != null)
            {
                return (X, Y + 1);
            }
            else if (!isNextToWall(X, Y))
            {
                if (Game.MaxX - X < Game.MaxY - Y)
                    return (X + 1, Y);
                return (X, Y + 1);
            }
            else
            {
                bool isRightRoom = isNextToWall(X + 1, Y);
                bool isBottomRoom = isNextToWall(X, Y + 1);
                if (isRightRoom && isBottomRoom)
                {
                    if ((Game.Random.Next() % 2 == 0 || Y == Game.MaxY) && X != Game.MaxX)
                        return (X + 1, Y);
                    return(X, Y + 1);
                }
                else if (isRightRoom)
                {
                    return (X + 1, Y);
                }
                else if (isBottomRoom)
                {
                    return (X, Y + 1);
                }
            }
            return (X, Y);
        }

        private bool isNextToWall(int x, int y)
        {
            return (x == Game.MaxX || y == Game.MaxY || x == 0 || y == 0);
        }
    }
}
