using IAcademyOfDoom.Logic;
using IAcademyOfDoom.Logic.Places;
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
        public int _theoricalBalance;
        private Dictionary<String, int> _qtyRoomsInSession = new Dictionary<String, int>();
        private Dictionary<String, int> _sessionPurchases = new Dictionary<String, int>(); 
        private const int _COST = 5;
        private Dictionary<String, int> _qtyRooms = new Dictionary<String, int>();
        private static Dictionary<String, int> _purchasedItem = new Dictionary<String, int>();
        private static int _restQty = 4;
        private static int _lgQty = 4;
        private static int _orientQty = 3;

        public Magasin()
        {
            InitializeComponent();
            _theoricalBalance = Game.Money;
            BalanceInMagasin.Text = "Your balance is : " + _theoricalBalance.ToString() + " €";
            _qtyRoomsInSession.Add("restRoom", _restQty);
            _qtyRoomsInSession.Add("loungeRoom", _lgQty);
            _qtyRoomsInSession.Add("orientationOffice", _orientQty);
            _qtyRoomsInSession.Add("tutoringRoom", 0); // Mettre la quantité statique si elle existe
            initMagasin();
        }

        private void initMagasin()
        {
            restRoomQty.Text = "Qty : " + _qtyRoomsInSession["restRoom"].ToString();
            loungeRoomQty.Text = "Qty : " + _qtyRoomsInSession["loungeRoom"].ToString();
            orientOfficeQty.Text = "Qty : " + _qtyRoomsInSession["orientationOffice"].ToString();
            // tutorRoomQty.Text = ...
            StringBuilder sb = new StringBuilder();
            foreach (string item in _purchasedItem.Keys)
            {
                sb.Append(item).Append(": ").Append(_purchasedItem[item]).Append(", ");
            }
            if (_purchasedItem.Count > 0) 
            {
                sb.Length -= 2; 
            }
            purchasedLabel.Text = sb.ToString();
        }

        /// <summary>
        /// Update the display in the purchased item
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void addPurchaseToList(String typeOfRoom)
        {
            if (_sessionPurchases.ContainsKey(typeOfRoom))
            {
                _sessionPurchases[typeOfRoom]++;
            }
            else
            {
                _sessionPurchases.Add(typeOfRoom, 1);
            }
            StringBuilder sb = new StringBuilder();
            Dictionary<string, int> combinedPurchases = new Dictionary<string, int>(_purchasedItem);

            foreach (var sP in _sessionPurchases)
            {
                if (combinedPurchases.ContainsKey(sP.Key))
                    combinedPurchases[sP.Key] += sP.Value;
                else
                    combinedPurchases.Add(sP.Key, sP.Value);
            }

            foreach (string item in combinedPurchases.Keys)
            {
                sb.Append(item).Append(": ").Append(combinedPurchases[item]).Append(", ");
            }
            if (combinedPurchases.Count > 0)
            {
                sb.Length -= 2;
            }
            purchasedLabel.Text = sb.ToString(); ;
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
                    _restQty--;
                    restRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case "loungeRoom":
                    messageLoungeQty.Text = "Purchase successful";
                    messageLoungeQty.ForeColor = Color.Green;
                    _lgQty--;
                    loungeRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case "orientationOffice":
                    messageOrientationQty.Text = "Purchase successful";
                    messageOrientationQty.ForeColor = Color.Green;
                    _orientQty--;
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

        /// <summary>
        /// Update the display of the balance and remove money from balance
        /// </summary>
        private void loadBuyable()
        {
            _theoricalBalance -= _COST;
            BalanceInMagasin.Text = "Your balance is : " + _theoricalBalance.ToString() + " €";
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
                loadBuyable();
                addPurchaseToList(roomType);
            }
        }

        private void loungeRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de repos
            String roomType = "loungeRoom";
            if (isBuyable(roomType))
            {
                loadBuyable();
                addPurchaseToList(roomType);
            }
        }

        private void orientationOfficeButton_Click(object sender, EventArgs e)
        {
            // Salle d'orientation
            String roomType = "orientationOffice";
            if (isBuyable(roomType))
            {
                loadBuyable();
                addPurchaseToList(roomType);
            }
        }

        private void tutoringRoomButton_Click(object sender, EventArgs e)
        {
            // Salle de tutorat
            String roomType = "tutoringRoom";
            if (isBuyable(roomType))
            {
                loadBuyable();
                addPurchaseToList(roomType);
            }
        }
    }
}
