using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAcademyOfDoom.Logic.Mobiles
{ /// <summary>
  /// Une classe représentant un bot de type Persistent
  /// /// </summary>
    public class Persistent : Botling
    {
        /// <summary>
        /// Constructeur pour la classe Persistent
        /// </summary>
        public Persistent() : base(BotType.Persistent)
        { }

        /// <summary>
        /// Redéfinit la méthode de mouvement pour Persistent
        /// </summary>
        public override void Move()
        {
            base.Move();
        }
    }
