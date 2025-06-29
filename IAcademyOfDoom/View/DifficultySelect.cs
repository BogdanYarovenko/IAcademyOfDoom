﻿using IAcademyOfDoom.Logic.GameSettings;
using System;
using System.Windows.Forms;

namespace IAcademyOfDoom.View
{
    public partial class DifficultySelect : Form
    {
        public Difficulty? Difficulty { get { return difficulySelectList.Items[difficulySelectList.SelectedIndex == -1 ? 0 : difficulySelectList.SelectedIndex] as Difficulty?; } }
        public string InputName { get { return nameTextBox.Text; } }
        public DifficultySelect()
        {
            InitializeComponent();
            foreach (Difficulty difficulty in Enum.GetValues(typeof(Difficulty)))
            {
                difficulySelectList.Items.Add(difficulty);
            }
        }
    }
}
