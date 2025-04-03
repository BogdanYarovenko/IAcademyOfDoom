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
        /// Disable the button of the room type passed in parameter
        /// </summary>
        /// <param name="typeOfRoom"> the name of the room</param>
        private void DisableRoomButton(string typeOfRoom)
        {
            Button roomButton = null;

            switch (typeOfRoom)
            {
                case "restRoom":
                    roomButton = restRoomButton;
                    break;
                case "loungeRoom":
                    roomButton = loungeRoomButton;
                    break;
                case "orientationOffice":
                    roomButton = orientationOfficeButton;
                    break;
                case "tutoringRoom":
                    roomButton = tutoringRoomButton;
                    break;
            }

            if (roomButton != null)
            {
                roomButton.Enabled = false;
            }
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
