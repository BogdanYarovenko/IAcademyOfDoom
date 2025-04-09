using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Aimless
    /// /// </summary>
    public class Aimless : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Aimless
        /// </summary>
        public Aimless() : base(BotType.Aimless)
        { }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour Aimless
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
    }
