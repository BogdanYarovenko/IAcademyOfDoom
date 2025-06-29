﻿namespace IAcademyOfDoom.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.endPrepButton = new System.Windows.Forms.Button();
            this.nextInAssaultButton = new System.Windows.Forms.Button();
            this.botnumTextLabel = new System.Windows.Forms.Label();
            this.numberOfBotlingsContentLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.showResultsButton = new System.Windows.Forms.Button();
            this.numberOfCoins = new System.Windows.Forms.Label();
            this.magasinDesign = new System.Windows.Forms.Button();
            this.outputButton = new System.Windows.Forms.Button();
            this.actionMagasinButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputListBox.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.ItemHeight = 14;
            this.outputListBox.Location = new System.Drawing.Point(34, 492);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(765, 130);
            this.outputListBox.TabIndex = 0;
            this.outputListBox.Visible = false;
            // 
            // endPrepButton
            // 
            this.endPrepButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endPrepButton.Location = new System.Drawing.Point(833, 492);
            this.endPrepButton.Name = "endPrepButton";
            this.endPrepButton.Size = new System.Drawing.Size(162, 23);
            this.endPrepButton.TabIndex = 1;
            this.endPrepButton.Text = "End preparations";
            this.endPrepButton.UseVisualStyleBackColor = true;
            this.endPrepButton.Click += new System.EventHandler(this.EndPrepButton_Click);
            // 
            // nextInAssaultButton
            // 
            this.nextInAssaultButton.Enabled = false;
            this.nextInAssaultButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextInAssaultButton.Location = new System.Drawing.Point(833, 521);
            this.nextInAssaultButton.Name = "nextInAssaultButton";
            this.nextInAssaultButton.Size = new System.Drawing.Size(162, 23);
            this.nextInAssaultButton.TabIndex = 2;
            this.nextInAssaultButton.Text = "Assault: next";
            this.nextInAssaultButton.UseVisualStyleBackColor = true;
            this.nextInAssaultButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NextInAssaultButton_MouseDown);
            this.nextInAssaultButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NextInAssaultButton_MouseUp);
            // 
            // botnumTextLabel
            // 
            this.botnumTextLabel.AutoSize = true;
            this.botnumTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.botnumTextLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botnumTextLabel.Location = new System.Drawing.Point(12, 23);
            this.botnumTextLabel.Name = "botnumTextLabel";
            this.botnumTextLabel.Size = new System.Drawing.Size(133, 16);
            this.botnumTextLabel.TabIndex = 3;
            this.botnumTextLabel.Text = "Number of botlings:";
            // 
            // numberOfBotlingsContentLabel
            // 
            this.numberOfBotlingsContentLabel.AutoSize = true;
            this.numberOfBotlingsContentLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfBotlingsContentLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfBotlingsContentLabel.Location = new System.Drawing.Point(152, 23);
            this.numberOfBotlingsContentLabel.Name = "numberOfBotlingsContentLabel";
            this.numberOfBotlingsContentLabel.Size = new System.Drawing.Size(23, 16);
            this.numberOfBotlingsContentLabel.TabIndex = 4;
            this.numberOfBotlingsContentLabel.Text = "nb";
            // 
            // quitButton
            // 
            this.quitButton.Enabled = false;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(833, 630);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(162, 23);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Visible = false;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerNameLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(218, 23);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(55, 16);
            this.playerNameLabel.TabIndex = 6;
            this.playerNameLabel.Text = "plName";
            // 
            // showResultsButton
            // 
            this.showResultsButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResultsButton.Location = new System.Drawing.Point(833, 579);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(162, 23);
            this.showResultsButton.TabIndex = 7;
            this.showResultsButton.Text = "Results";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.showResultsButton_Click);
            // 
            // numberOfCoins
            // 
            this.numberOfCoins.AutoSize = true;
            this.numberOfCoins.BackColor = System.Drawing.Color.Transparent;
            this.numberOfCoins.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfCoins.Location = new System.Drawing.Point(1011, 23);
            this.numberOfCoins.Name = "numberOfCoins";
            this.numberOfCoins.Size = new System.Drawing.Size(49, 16);
            this.numberOfCoins.TabIndex = 8;
            this.numberOfCoins.Text = "money";
            // 
            // magasinDesign
            // 
            this.magasinDesign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.magasinDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.magasinDesign.Image = global::IAcademyOfDoom.Properties.Resources.Design_sans_titre;
            this.magasinDesign.Location = new System.Drawing.Point(1081, 53);
            this.magasinDesign.Name = "magasinDesign";
            this.magasinDesign.Size = new System.Drawing.Size(67, 63);
            this.magasinDesign.TabIndex = 9;
            this.magasinDesign.UseVisualStyleBackColor = false;
            this.magasinDesign.Click += new System.EventHandler(this.MagasinDesign_Click);
            // 
            // outputButton
            // 
            this.outputButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.outputButton.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputButton.Location = new System.Drawing.Point(254, 463);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 23);
            this.outputButton.TabIndex = 10;
            this.outputButton.Text = "↓ output ↓";
            this.outputButton.UseVisualStyleBackColor = true;
            this.outputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // actionMagasinButton
            // 
            this.actionMagasinButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionMagasinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actionMagasinButton.Location = new System.Drawing.Point(1124, 122);
            this.actionMagasinButton.Name = "actionMagasinButton";
            this.actionMagasinButton.Size = new System.Drawing.Size(24, 162);
            this.actionMagasinButton.TabIndex = 11;
            this.actionMagasinButton.Text = "<<<<<<<<";
            this.actionMagasinButton.UseVisualStyleBackColor = false;
            this.actionMagasinButton.Click += new System.EventHandler(this.ActionsMagasin_Click);
            // 
            // autoButton
            // 
            this.autoButton.Enabled = false;
            this.autoButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoButton.Location = new System.Drawing.Point(833, 550);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(162, 23);
            this.autoButton.TabIndex = 12;
            this.autoButton.Text = "AutoGame";
            this.autoButton.UseVisualStyleBackColor = true;
            this.autoButton.Click += new System.EventHandler(this.AutoButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.Back_ground_main_window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1160, 687);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.actionMagasinButton);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.magasinDesign);
            this.Controls.Add(this.numberOfCoins);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.numberOfBotlingsContentLabel);
            this.Controls.Add(this.botnumTextLabel);
            this.Controls.Add(this.nextInAssaultButton);
            this.Controls.Add(this.endPrepButton);
            this.Controls.Add(this.outputListBox);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button endPrepButton;
        private System.Windows.Forms.Button nextInAssaultButton;
        private System.Windows.Forms.Label botnumTextLabel;
        private System.Windows.Forms.Label numberOfBotlingsContentLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.Label numberOfCoins;
        private System.Windows.Forms.Button magasinDesign;
        private System.Windows.Forms.Button outputButton;
        private System.Windows.Forms.Button actionMagasinButton;
        private System.Windows.Forms.Button autoButton;
    }
}

