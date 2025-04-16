using IAcademyOfDoom.Logic.Places;
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
    public partial class ActionsWindow : Form
    {
        public ActionsWindow()
        {
            InitializeComponent();
        }


        private void ActionsWindow_Paint(object sender, PaintEventArgs e)
        {
          

            e.Graphics.DrawRectangle(Pens.Black, Settings.ActionsMagasin);
            e.Graphics.DrawString("Availables actions", Settings.TitleFont, Brushes.Black,
               new PointF(Settings.ActionsMagasin.X + 50, Settings.ActionsMagasin.Y - 20));
           
        }
    }
}
