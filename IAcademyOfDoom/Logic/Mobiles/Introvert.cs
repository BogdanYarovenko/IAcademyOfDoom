using IAcademyOfDoom.Logic.GameSequence;
using IAcademyOfDoom.Logic.Mobiles;
using IAcademyOfDoom.Logic.Places;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Introvert
    /// /// </summary>
    public class Introvert : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Introvert
        /// </summary>
        public Introvert() : base(BotType.Introvert)
        {}

        /// <summary>
        /// Redéfinit la méthode de mouvement pour Introvert
        /// </summary>
        public override void Move()
        {
            base.Move();
        }

        /// <summary>
        /// Détermine la prochaine position à atteindre à partir de la position actuelle.
        /// La méthode choisit entre se déplacer à droite ou vers le bas en fonction des pièces présentes, de la proximité d'un mur,
        /// et si la pièce n'est pas occupée par un autre bot.
        /// Si aucune pièce n'est trouvée, elle sélectionne la direction avec le plus d'espace libre, ou choisit la direction qui est la moins proche d'un mur.
        /// </summary>
        /// <returns>Un tuple (x, y) représentant les nouvelles coordonnées de la position suivante.</returns>
        protected override (int x, int y) Next()
        {
            bool isRight = c.IsRoomHere(X + 1, Y) != null && !c.IsRoomOccupiedByBot(X + 1, Y);
            bool isBottom = c.IsRoomHere(X, Y + 1) != null && !c.IsRoomOccupiedByBot(X, Y + 1);
            if (isRight && isBottom)
            {
                if (Game.Random.Next() % 2 == 0)
                    return (X + 1, Y); 
                return (X, Y + 1); 
            }
            else if (isRight)
            {
                return (X + 1, Y);
            }
            else if (isBottom)
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
                bool isRightWall = isNextToWall(X + 1, Y);
                bool isBottomWall = isNextToWall(X, Y + 1);
                if (isRightWall && isBottomWall)
                {
                    if (Game.Random.Next() % 2 == 0)
                        return (X + 1, Y); 
                    return (X, Y + 1); 
                }
                else if (isRightWall)
                {
                    return (X + 1, Y); 
                }
                else if (isBottomWall)
                {
                    return (X, Y + 1);
                }
            }
            return (X, Y);
        }

        /// <summary>
        /// Vérifie si la position spécifiée est à côté d'un mur.
        /// Les murs sont définis par les bords du jeu (en fonction de Game.MaxX et Game.MaxY).
        /// </summary>
        /// <param name="x">La coordonnée x de la position à vérifier.</param>
        /// <param name="y">La coordonnée y de la position à vérifier.</param>
        /// <returns>Retourne vrai si la position est à côté d'un mur, sinon faux.</returns>
        private bool isNextToWall(int x, int y)
        {
            return ((x <= Game.MaxX && y == 0) || (y <= Game.MaxY && x == 0) || (x == Game.MaxX && y <= Game.MaxY) || (y == Game.MaxY && x <= Game.MaxX));
        }

    }
}