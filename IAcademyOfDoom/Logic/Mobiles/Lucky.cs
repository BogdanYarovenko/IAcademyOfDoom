using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAcademyOfDoom.Logic.Mobiles
{
    /// <summary>
    /// Une classe représentant un bot de type Lucky
    /// /// </summary>
    public class Lucky : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Lucky
        /// </summary>
        public Lucky() : base(BotType.Lucky)
        { }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour Lucky
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
    }
