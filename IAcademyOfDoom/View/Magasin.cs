using IAcademyOfDoom.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IAcademyOfDoom.View
{
    public partial class Magasin : Form
    {
        private const int _COST = 5;
        private Dictionary<String, int> _qtyRooms = new Dictionary<String, int>();
        public Magasin()
        {
            InitializeComponent();
            BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
            _qtyRooms.Add("restRoom", 4);
            _qtyRooms.Add("loungeRoom", 4);
            _qtyRooms.Add("orientationOffice", 3);
            //_qtyRooms.Add("tutoringRoom", 0); Rajouter le type de salle
        }

        /// <summary>
        /// Method to update the balance in the magasin
        ///
        /// TO:DO => Add the verification if the player don't have reach the amount of each room
        /// </summary>
        /// <returns> True if the room is buyable  </returns>
        private bool _isBuyable(String typeOfRoom)
        {
            return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void Magasin_Load(object sender, EventArgs e)
        {

        }

        private void restRoomButton_Click(object sender, EventArgs e)
        {
            // Sale de detente
            String roomType = "restRoom";
        }

        private void loungeRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de repos
            String roomType = "loungeRoom";
        }

        private void orientationOfficeButton_Click(object sender, EventArgs e)
        {
            // Salle d'orientation
            String roomType = "orientationOffice";
        }

        private void tutoringRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de tutorat
            String roomType = "tutoringRoom";
        }
    }
}
