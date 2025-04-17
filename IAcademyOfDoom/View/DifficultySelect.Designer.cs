namespace IAcademyOfDoom.View
{
    partial class DifficultySelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.difficulySelectList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(76, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(93, 21);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Your name";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(65, 128);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(151, 21);
            this.difficultyLabel.TabIndex = 1;
            this.difficultyLabel.Text = "Selected Difficulty";
            // 
            // nameTextBox
            // 
            this.nameTextBox.AccessibleDescription = "Votre";
            this.nameTextBox.AccessibleName = "Votre";
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nameTextBox.Location = new System.Drawing.Point(12, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(223, 24);
            this.nameTextBox.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatAppearance.BorderSize = 0;
            this.okButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.Window;
            this.okButton.Location = new System.Drawing.Point(367, 106);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(132, 43);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Start";
            this.okButton.UseVisualStyleBackColor = false;
            // 
            // difficulySelectList
            // 
            this.difficulySelectList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficulySelectList.FormattingEnabled = true;
            this.difficulySelectList.Location = new System.Drawing.Point(80, 154);
            this.difficulySelectList.Name = "difficulySelectList";
            this.difficulySelectList.Size = new System.Drawing.Size(121, 22);
            this.difficulySelectList.TabIndex = 5;
            // 
            // DifficultySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(539, 238);
            this.Controls.Add(this.difficulySelectList);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.nameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DifficultySelect";
            this.Text = "DifficultySelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox difficulySelectList;
    }
}