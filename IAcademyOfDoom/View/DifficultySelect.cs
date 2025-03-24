using IAcademyOfDoom.Logic.GameSettings;
using System;
using System.Windows.Forms;

namespace IAcademyOfDoom.View
{
    public partial class DifficultySelect : Form
    {
        public Difficulty? Difficulty { get { return difficultyListBox.Items[difficultyListBox.SelectedIndex == -1 ? 0 : difficultyListBox.SelectedIndex ] as Difficulty?; } }
        public string InputName { get { return nameTextBox.Text; } }
        public DifficultySelect()
        {
            InitializeComponent();
            foreach (Difficulty difficulty in Enum.GetValues(typeof(Difficulty)))
            {
                difficultyListBox.Items.Add(difficulty);
            }
        }

        private void DifficultySelect_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
