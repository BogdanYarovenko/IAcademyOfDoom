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
        public Magasin()
        {
            InitializeComponent();
            BalanceInMagasin.Text = "Your balance is : " + Game.Money.ToString() + " €";
        }

        // <summary>
        // Method to update the balance in the magasin
        //
        // TO:DO => Add the verification if the player don't have reach the amount of each room
        // </summary>
        private bool _isBuyable()
        {
            if (Game.Money >= _COST)
            {
                return true;
            } else
            {
                return false;
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

        }
    }
}
