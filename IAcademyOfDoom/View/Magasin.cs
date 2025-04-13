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
    enum FrameTypeRoom
    {
        RestRoom,
        LoungeRoom,
        OrientationOffice,
        TutoringRoom
    }

    public partial class Magasin : Form
    {
        private const int _COST = 5;

        private int _localMoney;
        private Dictionary<FrameTypeRoom, int> _qtyRooms = new Dictionary<FrameTypeRoom, int>();
        private Dictionary<FrameTypeRoom, int> _purchasedItem = new Dictionary<FrameTypeRoom, int>();
        //private String purchasedList = "";

        public Magasin()
        {
            InitializeComponent();
            _qtyRooms.Add(FrameTypeRoom.RestRoom, 4);
            _qtyRooms.Add(FrameTypeRoom.LoungeRoom, 4);
            _qtyRooms.Add(FrameTypeRoom.OrientationOffice, 3);
            _qtyRooms.Add(FrameTypeRoom.TutoringRoom, 0); //Rajouter le type de salle
        }
        private void Magasin_Load(object sender, EventArgs e)
        {
            _localMoney = Game.Money;
            BalanceInMagasin.Text = "Your balance is : " + _localMoney.ToString() + " €";
            purchasedLabel.Text = "";
            initMagasin();
        }

        private void initMagasin()
        {
            restRoomQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.RestRoom].ToString();
            loungeRoomQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.LoungeRoom].ToString();
            orientOfficeQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.OrientationOffice].ToString();

            resetStates();
            resetPurchaseLabels();

            //tutorRoomQty.Text = "Qty : " + 

            //purchasedLabel.Text = purchasedList;
        }

        /// <summary>
        /// Update the display in the purchased item
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void addPurchaseToList(FrameTypeRoom typeOfRoom)
        {
            if (_purchasedItem.ContainsKey(typeOfRoom))
            {
                _purchasedItem[typeOfRoom]++;
            }
            else
            {
                _purchasedItem.Add(typeOfRoom, 1);
            }
            StringBuilder sb = new StringBuilder();
          int columnWidth = 20;
            sb.Append("Room Type".PadRight(columnWidth)).Append("Quantity").Append("\n");
            sb.Append(new string('-', columnWidth *2)).Append("\n");

            foreach (FrameTypeRoom item in _purchasedItem.Keys)
            {
                sb.Append(item.ToString().PadRight(columnWidth))
                  .Append(_purchasedItem[item].ToString())
                  .Append("\n");
            }

            purchasedLabel.Text = sb.ToString();
        }

        private void resetStates()
        {
            foreach (FrameTypeRoom type in _qtyRooms.Keys)
            {
                setRoomButton(type, _qtyRooms[type] != 0);
            }
        }

        /// <summary>
        /// Method to buy a room. It checks if the room is available and if the player has enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        /// <returns> True if the operation was successful. </returns>
        private bool isBuyable(FrameTypeRoom typeOfRoom)
        {
            return _qtyRooms[typeOfRoom] > 0 && _localMoney >= _COST;

            /*if (_qtyRooms[typeOfRoom] > 0) 
            {
                if (_localMoney >= _COST)
                {
                    purchaseSucced(typeOfRoom);
                    if (_qtyRooms[typeOfRoom] == 0)
                    {
                        disableRoomButton(typeOfRoom);
                    }
                    return true;
                }
                else
                {
                    purchaseFailed(typeOfRoom);
                }
            }
            return false;*/
        }

        /// <summary>
        /// Method to display that the purchase of the room failed due to not enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void purchaseFailed(FrameTypeRoom typeOfRoom)
        {
            switch (typeOfRoom)
            {
                case FrameTypeRoom.RestRoom:
                    messageRestQty.Text = "Not enough money";
                    messageRestQty.ForeColor = Color.Red;
                    break;
                case FrameTypeRoom.LoungeRoom:
                    messageLoungeQty.Text = "Not enough money";
                    messageLoungeQty.ForeColor = Color.Red;
                    break;
                case FrameTypeRoom.OrientationOffice:
                    messageOrientationQty.Text = "Not enough money";
                    messageOrientationQty.ForeColor = Color.Red;
                    break;
                case FrameTypeRoom.TutoringRoom:
                    messageTutoringQty.Text = "Not enough money";
                    messageTutoringQty.ForeColor = Color.Red;
                    break;
            }
        }

        /// <summary>
        /// Method to display the successful purchase message and quantity of the room remaining
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void purchaseSucced(FrameTypeRoom typeOfRoom) {
            switch (typeOfRoom)
            {
                case FrameTypeRoom.RestRoom:
                    messageRestQty.Text = "Purchase successful";
                    messageRestQty.ForeColor = Color.Green;
                    restRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case FrameTypeRoom.LoungeRoom:
                    messageLoungeQty.Text = "Purchase successful";
                    messageLoungeQty.ForeColor = Color.Green;
                    loungeRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case FrameTypeRoom.OrientationOffice:
                    messageOrientationQty.Text = "Purchase successful";
                    messageOrientationQty.ForeColor = Color.Green;

                    orientOfficeQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString();
                    break;
                case FrameTypeRoom.TutoringRoom:
                    messageTutoringQty.Text = "Purchase successful";
                    messageTutoringQty.ForeColor = Color.Green;
                    // tutorRoomQty.Text = "Qty : " + _qtyRooms[typeOfRoom].ToString(); Need to implement different type of this room
                    break;
            }
        }

        private void resetPurchaseLabels()
        {
            messageRestQty.Text = messageLoungeQty.Text = messageOrientationQty.Text = messageTutoringQty.Text = "";
        }

        /// <summary>
        /// Disable the button of the room type passed in parameter
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void setRoomButton(FrameTypeRoom typeOfRoom, bool state)
        {
            Button roomButton = null;

            switch (typeOfRoom)
            {
                case FrameTypeRoom.RestRoom:
                    roomButton = restRoomButton;
                    break;
                case FrameTypeRoom.LoungeRoom:
                    roomButton = loungeRoomButton;
                    break;
                case FrameTypeRoom.OrientationOffice:
                    roomButton = orientationOfficeButton;
                    break;
                case FrameTypeRoom.TutoringRoom:
                    roomButton = tutoringRoomButton;
                    break;
            }

            if (roomButton != null)
            {
                roomButton.Enabled = state;
            }
        }

        /// <summary>
        /// Update the display of the balance and remove money from balance
        /// </summary>
        private void loadBuyable()
        {
            _localMoney -= _COST;
            BalanceInMagasin.Text = "Your balance is : " + _localMoney.ToString() + " €";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Game.RemoveMoney(Game.Money - _localMoney);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            foreach (FrameTypeRoom typeOfRoom in _purchasedItem.Keys)
            {
                _qtyRooms[typeOfRoom] += _purchasedItem[typeOfRoom];
            }
            _purchasedItem.Clear();

            this.Close();
        }

        

        private void buy(FrameTypeRoom typeOfRoom)
        {
            if (isBuyable(typeOfRoom))
            {
                _qtyRooms[typeOfRoom]--;
                setRoomButton(typeOfRoom, _qtyRooms[typeOfRoom] != 0);
                purchaseSucced(typeOfRoom);
                loadBuyable();
                addPurchaseToList(typeOfRoom);
            }
            else
            {
                purchaseFailed(typeOfRoom);
            }
        }

        private void restRoomButton_Click(object sender, EventArgs e) { buy(FrameTypeRoom.RestRoom); }
        private void loungeRoomButton_Click(object sender, EventArgs e) { buy(FrameTypeRoom.LoungeRoom); }
        private void orientationOfficeButton_Click(object sender, EventArgs e) { buy(FrameTypeRoom.OrientationOffice); }
        private void tutoringRoomButton_Click(object sender, EventArgs e) { buy(FrameTypeRoom.TutoringRoom); }

        public List<Placeable> getPurchasedPlaceables()
        {
            List<Placeable> placeables = new List<Placeable>();

            foreach (FrameTypeRoom typeOfRoom in _purchasedItem.Keys)
            {
                for (int i = 0; i < _purchasedItem[typeOfRoom]; i++)
                {
                    placeables.Add(new Placeable(RoomType.Facility, null, typeOfRoom.ToString()));
                }
            }
            _purchasedItem.Clear();

            return placeables;
        }
    }
}
