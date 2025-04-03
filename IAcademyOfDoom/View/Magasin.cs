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
        /// Method to buy a room. It checks if the room is available and if the player has enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        /// <returns> True if the operation was successful. </returns>
        private bool isBuyable(string typeOfRoom)
        {
            if (_qtyRooms[typeOfRoom] > 0) 
            {
                if (Game.Money >= _COST)
                {
                    _qtyRooms[typeOfRoom]--;
                    purchaseSucced(typeOfRoom);
                    if (_qtyRooms[typeOfRoom] == 0)
                    {
                        disableRoomButton(typeOfRoom);
                    }
                    return true;
                } else
                {
                    purchaseFailed(typeOfRoom);
                }
                purchaseFailed(typeOfRoom);
            }
            return false;
        }

        /// <summary>
        /// Method to display that the purchase of the room failed due to not enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void purchaseFailed(String typeOfRoom)
        {
            switch (typeOfRoom)
            {
                case "restRoom":
                    messageRestQty.Text = "Not enough money";
                    messageRestQty.ForeColor = Color.Red;
                    break;
                case "loungeRoom":
                    messageLoungeQty.Text = "Not enough money";
                    messageLoungeQty.ForeColor = Color.Red;
                    break;
                case "orientationOffice":
                    messageOrientationQty.Text = "Not enough money";
                    messageOrientationQty.ForeColor = Color.Red;
                    break;
                case "tutoringRoom":
                    messageTutoringQty.Text = "Not enough money";
                    messageTutoringQty.ForeColor = Color.Red;
                    break;
            }
        }

        /// <summary>
        /// Method to display the successful purchase message and quantity of the room remaining
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void purchaseSucced(String typeOfRoom) {
            switch (typeOfRoom)
            {
                case "restRoom":
                    messageRestQty.Text = "Purchase successful";
                    messageRestQty.ForeColor = Color.Green;
                    restRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case "loungeRoom":
                    messageLoungeQty.Text = "Purchase successful";
                    messageLoungeQty.ForeColor = Color.Green;
                    loungeRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case "orientationOffice":
                    messageOrientationQty.Text = "Purchase successful";
                    messageOrientationQty.ForeColor = Color.Green;
                    orientOfficeQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case "tutoringRoom":
                    messageTutoringQty.Text = "Purchase successful";
                    messageTutoringQty.ForeColor = Color.Green;
                    // tutorRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString(); Need to implement different type of this room
                    break;
            }
        }

        /// <summary>
        /// Disable the button of the room type passed in parameter
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void disableRoomButton(string typeOfRoom)
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
            if (isBuyable(roomType))
            {
                Game.RemoveMoney(_COST);
                BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
            }
        }

        private void loungeRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de repos
            String roomType = "loungeRoom";
            if (isBuyable(roomType))
            {
                Game.RemoveMoney(_COST);
                BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
            }
        }

        private void orientationOfficeButton_Click(object sender, EventArgs e)
        {
            // Salle d'orientation
            String roomType = "orientationOffice";
            if (isBuyable(roomType))
            {
                Game.RemoveMoney(_COST);
                BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
            }
        }

        private void tutoringRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de tutorat
            String roomType = "tutoringRoom";
            if (isBuyable(roomType))
            {
                Game.RemoveMoney(_COST);
                BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
            }
        }
    }
}
