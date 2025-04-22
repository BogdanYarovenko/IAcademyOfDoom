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
            InitMagasin();
        }
        /// <summary>
        /// Initializes the magasin (shop) interface by displaying the current quantities of available rooms
        /// and resetting the UI components such as button states and purchase labels.
        /// </summary>

        private void InitMagasin()
        {
            restRoomQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.RestRoom].ToString();
            loungeRoomQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.LoungeRoom].ToString();
            orientOfficeQty.Text = "Qty : " + _qtyRooms[FrameTypeRoom.OrientationOffice].ToString();

            ResetStates();
            ResetPurchaseLabels();
        }

        /// <summary>
        /// Update the display in the purchased item
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void AddPurchaseToList(FrameTypeRoom typeOfRoom)
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
            sb.Append(new string('-', columnWidth * 2)).Append("\n");

            foreach (FrameTypeRoom item in _purchasedItem.Keys)
            {
                sb.Append(item.ToString().PadRight(columnWidth))
                  .Append(_purchasedItem[item].ToString())
                  .Append("\n");
            }

            purchasedLabel.Text = sb.ToString();
        }

        /// <summary>
        /// Resets the enabled/disabled state of all room purchase buttons based on the remaining quantity
        /// of each room type. If a room type has a quantity greater than zero, its corresponding button
        /// will be enabled; otherwise, it will be disabled.
        /// </summary>
        private void ResetStates()
        {
            foreach (FrameTypeRoom type in _qtyRooms.Keys)
            {
                SetRoomButton(type, _qtyRooms[type] != 0);
            }
        }

        /// <summary>
        /// Method to buy a room. It checks if the room is available and if the player has enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        /// <returns> True if the operation was successful. </returns>
        private bool IsBuyable(FrameTypeRoom typeOfRoom)
        {
            return _qtyRooms[typeOfRoom] > 0 && _localMoney >= _COST;
        }

        /// <summary>
        /// Method to display that the purchase of the room failed due to not enough money
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void PurchaseFailed(FrameTypeRoom typeOfRoom)
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
        private void PurchaseSucced(FrameTypeRoom typeOfRoom)
        {
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
        /// <summary>
        /// Resets the purchase quantity labels for all room types to be empty. This method clears the displayed quantities
        /// for the Rest Room, Lounge Room, Orientation Office, and Tutoring Room labels, effectively resetting the UI
        /// to its initial state before any purchases are made.
        /// </summary>
        private void ResetPurchaseLabels()
        {
            messageRestQty.Text = messageLoungeQty.Text = messageOrientationQty.Text = messageTutoringQty.Text = "";
        }

        /// <summary>
        /// Disable the button of the room type passed in parameter
        /// </summary>
        /// <param name="typeOfRoom">The name of the room</param>
        private void SetRoomButton(FrameTypeRoom typeOfRoom, bool state)
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
        private void LoadBuyable()
        {
            _localMoney -= _COST;
            BalanceInMagasin.Text = "Your balance is : " + _localMoney.ToString() + " €";
        }

        /// <summary>
        /// Handles the action when the "OK" button is clicked. It sets the dialog result to OK, updates the game balance by removing money spent, and closes the window.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "OK" button.</param>
        /// <param name="e">The event arguments.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Game.RemoveMoney(Game.Money - _localMoney);
            this.Close();
        }

        /// <summary>
        /// Handles the action when the "Cancel" button is clicked. It reinitializes the state and closes the window.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "Cancel" button.</param>
        /// <param name="e">The event arguments.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Reinitialise();
            this.Close();
        }

        /// <summary>
        /// Event handler for when the form is closing. If the dialog result is not "OK", it calls the reinitialization method to revert any changes made during the purchase process.
        /// </summary>
        /// <param name="sender">The sender of the event (the form).</param>
        /// <param name="e">The event arguments.</param>
        private void Magasin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK) Reinitialise();
        }

        /// <summary>
        /// Reinitializes the state by resetting the quantities of rooms and clearing the purchased items list.
        /// This is called when the user cancels the purchase or closes the form.
        /// </summary>
        private void Reinitialise()
        {
            this.DialogResult = DialogResult.Cancel;
            foreach (FrameTypeRoom typeOfRoom in _purchasedItem.Keys)
            {
                _qtyRooms[typeOfRoom] += _purchasedItem[typeOfRoom];
            }

            _purchasedItem.Clear();
        }

        /// <summary>
        /// Handles the purchase action for a specific room type. It checks if the room is buyable, updates the quantity of the room,
        /// and updates the purchase list. If the purchase fails, a failure message is displayed.
        /// </summary>
        /// <param name="typeOfRoom">The type of room being purchased.</param>
        private void Buy(FrameTypeRoom typeOfRoom)
        {
            if (IsBuyable(typeOfRoom))
            {
                _qtyRooms[typeOfRoom]--;
                SetRoomButton(typeOfRoom, _qtyRooms[typeOfRoom] != 0); 
                PurchaseSucced(typeOfRoom); 
                LoadBuyable();
                AddPurchaseToList(typeOfRoom);
            }
            else
            {
                PurchaseFailed(typeOfRoom);
            }
        }

        /// <summary>
        /// Event handler for when the "Rest Room" button is clicked. Initiates the purchase of a RestRoom.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "Rest Room" button.</param>
        /// <param name="e">The event arguments.</param>
        private void RestRoomButton_Click(object sender, EventArgs e) => Buy(FrameTypeRoom.RestRoom);

        /// <summary>
        /// Event handler for when the "Lounge Room" button is clicked. Initiates the purchase of a LoungeRoom.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "Lounge Room" button.</param>
        /// <param name="e">The event arguments.</param>
        private void LoungeRoomButton_Click(object sender, EventArgs e) => Buy(FrameTypeRoom.LoungeRoom);

        /// <summary>
        /// Event handler for when the "Orientation Office" button is clicked. Initiates the purchase of an OrientationOffice.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "Orientation Office" button.</param>
        /// <param name="e">The event arguments.</param>
        private void OrientationOfficeButton_Click(object sender, EventArgs e) => Buy(FrameTypeRoom.OrientationOffice);

        /// <summary>
        /// Event handler for when the "Tutoring Room" button is clicked. Initiates the purchase of a TutoringRoom.
        /// </summary>
        /// <param name="sender">The sender of the event, typically the "Tutoring Room" button.</param>
        /// <param name="e">The event arguments.</param>
        private void TutoringRoomButton_Click(object sender, EventArgs e) => Buy(FrameTypeRoom.TutoringRoom);

        /// <summary>
        /// Returns a list of all purchased placeables. Each purchased item is added as a Placeable object with the room type.
        /// After retrieving the purchased items, the list is cleared.
        /// </summary>
        /// <returns>A list of objects representing the purchased room items.</returns>
        public List<Placeable> GetPurchasedPlaceables()
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
