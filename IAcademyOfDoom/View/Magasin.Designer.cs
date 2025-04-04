namespace IAcademyOfDoom.View
{
    partial class Magasin
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
            this.restRoomButton = new System.Windows.Forms.Button();
            this.loungeRoomButton = new System.Windows.Forms.Button();
            this.orientationOfficeButton = new System.Windows.Forms.Button();
            this.tutoringRoomButton = new System.Windows.Forms.Button();
            this.restRoomQty = new System.Windows.Forms.Label();
            this.loungeRoomQty = new System.Windows.Forms.Label();
            this.orientOfficeQty = new System.Windows.Forms.Label();
            this.tutorRoomQty = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.buyableLabel = new System.Windows.Forms.Label();
            this.messageRestQty = new System.Windows.Forms.Label();
            this.messageLoungeQty = new System.Windows.Forms.Label();
            this.messageTutoringQty = new System.Windows.Forms.Label();
            this.messageOrientationQty = new System.Windows.Forms.Label();
            this.purchasedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(622, 145);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(129, 50);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(622, 248);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BalanceInMagasin
            // 
            this.BalanceInMagasin.AutoSize = true;
            this.BalanceInMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInMagasin.Location = new System.Drawing.Point(29, 19);
            this.BalanceInMagasin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceInMagasin.Name = "BalanceInMagasin";
            this.BalanceInMagasin.Size = new System.Drawing.Size(125, 20);
            this.BalanceInMagasin.TabIndex = 2;
            this.BalanceInMagasin.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(32, 141);
            this.restRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(136, 67);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Rest room\r\n\r\nCost : 5";
            this.restRoomButton.UseVisualStyleBackColor = true;
            this.restRoomButton.Click += new System.EventHandler(this.restRoomButton_Click);
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(279, 141);
            this.loungeRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(136, 67);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Lounge room\r\n\r\nCost : 5";
            this.loungeRoomButton.UseVisualStyleBackColor = true;
            this.loungeRoomButton.Click += new System.EventHandler(this.loungeRoomButton_Click);
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(32, 284);
            this.orientationOfficeButton.Margin = new System.Windows.Forms.Padding(2);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(136, 67);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Orientation office\r\n\r\nCost : 5\r\n";
            this.orientationOfficeButton.UseVisualStyleBackColor = true;
            this.orientationOfficeButton.Click += new System.EventHandler(this.orientationOfficeButton_Click);
            // 
            // tutoringRoomButton
            // 
            this.tutoringRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringRoomButton.Location = new System.Drawing.Point(279, 284);
            this.tutoringRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tutoringRoomButton.Name = "tutoringRoomButton";
            this.tutoringRoomButton.Size = new System.Drawing.Size(136, 67);
            this.tutoringRoomButton.TabIndex = 6;
            this.tutoringRoomButton.Text = "Tutoring rooms\r\n\r\nCost : 5\r\n";
            this.tutoringRoomButton.UseVisualStyleBackColor = true;
            this.tutoringRoomButton.Click += new System.EventHandler(this.tutoringRoomButton_Click);
            // 
            // restRoomQty
            // 
            this.restRoomQty.AutoSize = true;
            this.restRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomQty.Location = new System.Drawing.Point(184, 167);
            this.restRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restRoomQty.Name = "restRoomQty";
            this.restRoomQty.Size = new System.Drawing.Size(38, 13);
            this.restRoomQty.TabIndex = 7;
            this.restRoomQty.Text = "Qty : 4";
            // 
            // loungeRoomQty
            // 
            this.loungeRoomQty.AutoSize = true;
            this.loungeRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomQty.Location = new System.Drawing.Point(435, 167);
            this.loungeRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loungeRoomQty.Name = "loungeRoomQty";
            this.loungeRoomQty.Size = new System.Drawing.Size(38, 13);
            this.loungeRoomQty.TabIndex = 8;
            this.loungeRoomQty.Text = "Qty : 4";
            // 
            // orientOfficeQty
            // 
            this.orientOfficeQty.AutoSize = true;
            this.orientOfficeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientOfficeQty.Location = new System.Drawing.Point(184, 310);
            this.orientOfficeQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orientOfficeQty.Name = "orientOfficeQty";
            this.orientOfficeQty.Size = new System.Drawing.Size(38, 13);
            this.orientOfficeQty.TabIndex = 9;
            this.orientOfficeQty.Text = "Qty : 3";
            // 
            // tutorRoomQty
            // 
            this.tutorRoomQty.AutoSize = true;
            this.tutorRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorRoomQty.Location = new System.Drawing.Point(435, 310);
            this.tutorRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tutorRoomQty.Name = "tutorRoomQty";
            this.tutorRoomQty.Size = new System.Drawing.Size(96, 13);
            this.tutorRoomQty.TabIndex = 10;
            this.tutorRoomQty.Text = "Qty : 1 / each type";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 450);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 415);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchased item :";
            // 
            // buyableLabel
            // 
            this.buyableLabel.AutoSize = true;
            this.buyableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyableLabel.Location = new System.Drawing.Point(304, 84);
            this.buyableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyableLabel.Name = "buyableLabel";
            this.buyableLabel.Size = new System.Drawing.Size(98, 26);
            this.buyableLabel.TabIndex = 15;
            this.buyableLabel.Text = "Buyable";
            // 
            // messageRestQty
            // 
            this.messageRestQty.AutoSize = true;
            this.messageRestQty.Location = new System.Drawing.Point(49, 223);
            this.messageRestQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageRestQty.Name = "messageRestQty";
            this.messageRestQty.Size = new System.Drawing.Size(0, 13);
            this.messageRestQty.TabIndex = 16;
            // 
            // messageLoungeQty
            // 
            this.messageLoungeQty.AutoSize = true;
            this.messageLoungeQty.Location = new System.Drawing.Point(297, 223);
            this.messageLoungeQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLoungeQty.Name = "messageLoungeQty";
            this.messageLoungeQty.Size = new System.Drawing.Size(0, 13);
            this.messageLoungeQty.TabIndex = 17;
            // 
            // messageTutoringQty
            // 
            this.messageTutoringQty.AutoSize = true;
            this.messageTutoringQty.Location = new System.Drawing.Point(297, 369);
            this.messageTutoringQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageTutoringQty.Name = "messageTutoringQty";
            this.messageTutoringQty.Size = new System.Drawing.Size(0, 13);
            this.messageTutoringQty.TabIndex = 18;
            // 
            // messageOrientationQty
            // 
            this.messageOrientationQty.AutoSize = true;
            this.messageOrientationQty.Location = new System.Drawing.Point(49, 369);
            this.messageOrientationQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageOrientationQty.Name = "messageOrientationQty";
            this.messageOrientationQty.Size = new System.Drawing.Size(0, 13);
            this.messageOrientationQty.TabIndex = 19;
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLabel.Location = new System.Drawing.Point(184, 420);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(0, 13);
            this.purchasedLabel.TabIndex = 20;
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.purchasedLabel);
            this.Controls.Add(this.messageOrientationQty);
            this.Controls.Add(this.messageTutoringQty);
            this.Controls.Add(this.messageLoungeQty);
            this.Controls.Add(this.messageRestQty);
            this.Controls.Add(this.buyableLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tutorRoomQty);
            this.Controls.Add(this.orientOfficeQty);
            this.Controls.Add(this.loungeRoomQty);
            this.Controls.Add(this.restRoomQty);
            this.Controls.Add(this.tutoringRoomButton);
            this.Controls.Add(this.orientationOfficeButton);
            this.Controls.Add(this.loungeRoomButton);
            this.Controls.Add(this.restRoomButton);
            this.Controls.Add(this.BalanceInMagasin);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "Magasin";
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.Magasin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label BalanceInMagasin;
        private System.Windows.Forms.Button restRoomButton;
        private System.Windows.Forms.Button loungeRoomButton;
        private System.Windows.Forms.Button orientationOfficeButton;
        private System.Windows.Forms.Button tutoringRoomButton;
        private System.Windows.Forms.Label restRoomQty;
        private System.Windows.Forms.Label loungeRoomQty;
        private System.Windows.Forms.Label orientOfficeQty;
        private System.Windows.Forms.Label tutorRoomQty;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buyableLabel;
        private System.Windows.Forms.Label messageRestQty;
        private System.Windows.Forms.Label messageLoungeQty;
        private System.Windows.Forms.Label messageTutoringQty;
        private System.Windows.Forms.Label messageOrientationQty;
        private System.Windows.Forms.Label purchasedLabel;
    }
}