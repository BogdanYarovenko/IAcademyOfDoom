namespace IAcademyOfDoom.View
{
    partial class ActionsWindow
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.BalanceInMagasin = new System.Windows.Forms.Label();
            this.purchasedActionLabel = new System.Windows.Forms.Label();
            this.resultOfPurchase = new System.Windows.Forms.Label();
            this.purchasedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(488, 369);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(148, 66);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(673, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 66);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BalanceInMagasin
            // 
            this.BalanceInMagasin.AutoSize = true;
            this.BalanceInMagasin.BackColor = System.Drawing.Color.Transparent;
            this.BalanceInMagasin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInMagasin.Location = new System.Drawing.Point(12, 9);
            this.BalanceInMagasin.Name = "BalanceInMagasin";
            this.BalanceInMagasin.Size = new System.Drawing.Size(49, 16);
            this.BalanceInMagasin.TabIndex = 2;
            this.BalanceInMagasin.Text = "money";
            // 
            // purchasedActionLabel
            // 
            this.purchasedActionLabel.AutoSize = true;
            this.purchasedActionLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedActionLabel.Location = new System.Drawing.Point(35, 313);
            this.purchasedActionLabel.Name = "purchasedActionLabel";
            this.purchasedActionLabel.Size = new System.Drawing.Size(26, 16);
            this.purchasedActionLabel.TabIndex = 3;
            this.purchasedActionLabel.Text = "list";
            // 
            // resultOfPurchase
            // 
            this.resultOfPurchase.AutoSize = true;
            this.resultOfPurchase.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultOfPurchase.Location = new System.Drawing.Point(587, 313);
            this.resultOfPurchase.Name = "resultOfPurchase";
            this.resultOfPurchase.Size = new System.Drawing.Size(112, 16);
            this.resultOfPurchase.TabIndex = 4;
            this.resultOfPurchase.Text = "resultOfPurchase";
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLabel.Location = new System.Drawing.Point(114, 272);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(124, 16);
            this.purchasedLabel.TabIndex = 5;
            this.purchasedLabel.Text = "Purchased Actions:";
            // 
            // ActionsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.purchasedLabel);
            this.Controls.Add(this.resultOfPurchase);
            this.Controls.Add(this.purchasedActionLabel);
            this.Controls.Add(this.BalanceInMagasin);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ActionsWindow";
            this.Text = "ActionsWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ActionsWindow_FormClosing);
            this.Load += new System.EventHandler(this.ActionsWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label BalanceInMagasin;
        private System.Windows.Forms.Label purchasedActionLabel;
        private System.Windows.Forms.Label resultOfPurchase;
        private System.Windows.Forms.Label purchasedLabel;
    }
}