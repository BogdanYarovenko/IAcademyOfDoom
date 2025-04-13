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
            this.okButton.BackColor = System.Drawing.SystemColors.Control;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(765, 414);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(229, 92);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(765, 527);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(229, 92);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BalanceInMagasin
            // 
            this.BalanceInMagasin.AutoSize = true;
            this.BalanceInMagasin.BackColor = System.Drawing.Color.Transparent;
            this.BalanceInMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInMagasin.Location = new System.Drawing.Point(689, 9);
            this.BalanceInMagasin.Name = "BalanceInMagasin";
            this.BalanceInMagasin.Size = new System.Drawing.Size(152, 25);
            this.BalanceInMagasin.TabIndex = 2;
            this.BalanceInMagasin.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(456, 245);
            this.restRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(151, 68);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Buy RR";
            this.restRoomButton.UseVisualStyleBackColor = true;
            this.restRoomButton.Click += new System.EventHandler(this.restRoomButton_Click);
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(130, 245);
            this.loungeRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(151, 68);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Buy LR";
            this.loungeRoomButton.UseVisualStyleBackColor = true;
            this.loungeRoomButton.Click += new System.EventHandler(this.loungeRoomButton_Click);
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(130, 541);
            this.orientationOfficeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(151, 68);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Buy OO";
            this.orientationOfficeButton.UseVisualStyleBackColor = true;
            this.orientationOfficeButton.Click += new System.EventHandler(this.orientationOfficeButton_Click);
            // 
            // tutoringRoomButton
            // 
            this.tutoringRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringRoomButton.Location = new System.Drawing.Point(456, 541);
            this.tutoringRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tutoringRoomButton.Name = "tutoringRoomButton";
            this.tutoringRoomButton.Size = new System.Drawing.Size(151, 68);
            this.tutoringRoomButton.TabIndex = 6;
            this.tutoringRoomButton.Text = "Buy TR";
            this.tutoringRoomButton.UseVisualStyleBackColor = true;
            this.tutoringRoomButton.Click += new System.EventHandler(this.tutoringRoomButton_Click);
            // 
            // restRoomQty
            // 
            this.restRoomQty.AutoSize = true;
            this.restRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.restRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomQty.Location = new System.Drawing.Point(453, 214);
            this.restRoomQty.Name = "restRoomQty";
            this.restRoomQty.Size = new System.Drawing.Size(16, 16);
            this.restRoomQty.TabIndex = 7;
            this.restRoomQty.Text = "q";
            // 
            // loungeRoomQty
            // 
            this.loungeRoomQty.AutoSize = true;
            this.loungeRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.loungeRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomQty.Location = new System.Drawing.Point(132, 214);
            this.loungeRoomQty.Name = "loungeRoomQty";
            this.loungeRoomQty.Size = new System.Drawing.Size(16, 16);
            this.loungeRoomQty.TabIndex = 8;
            this.loungeRoomQty.Text = "q";
            // 
            // orientOfficeQty
            // 
            this.orientOfficeQty.AutoSize = true;
            this.orientOfficeQty.BackColor = System.Drawing.Color.Transparent;
            this.orientOfficeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientOfficeQty.Location = new System.Drawing.Point(127, 527);
            this.orientOfficeQty.Name = "orientOfficeQty";
            this.orientOfficeQty.Size = new System.Drawing.Size(16, 16);
            this.orientOfficeQty.TabIndex = 9;
            this.orientOfficeQty.Text = "q";
            // 
            // tutorRoomQty
            // 
            this.tutorRoomQty.AutoSize = true;
            this.tutorRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.tutorRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorRoomQty.Location = new System.Drawing.Point(466, 527);
            this.tutorRoomQty.Name = "tutorRoomQty";
            this.tutorRoomQty.Size = new System.Drawing.Size(131, 16);
            this.tutorRoomQty.TabIndex = 10;
            this.tutorRoomQty.Text = "Qty : 1 / each type";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 688);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(795, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchased items :";
            // 
            // buyableLabel
            // 
            this.buyableLabel.AutoSize = true;
            this.buyableLabel.BackColor = System.Drawing.Color.Transparent;
            this.buyableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyableLabel.Location = new System.Drawing.Point(304, 0);
            this.buyableLabel.Name = "buyableLabel";
            this.buyableLabel.Size = new System.Drawing.Size(125, 32);
            this.buyableLabel.TabIndex = 15;
            this.buyableLabel.Text = "Buyable";
            // 
            // messageRestQty
            // 
            this.messageRestQty.AutoSize = true;
            this.messageRestQty.BackColor = System.Drawing.Color.Transparent;
            this.messageRestQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRestQty.Location = new System.Drawing.Point(453, 315);
            this.messageRestQty.Name = "messageRestQty";
            this.messageRestQty.Size = new System.Drawing.Size(40, 25);
            this.messageRestQty.TabIndex = 16;
            this.messageRestQty.Text = "RR";
            // 
            // messageLoungeQty
            // 
            this.messageLoungeQty.AutoSize = true;
            this.messageLoungeQty.BackColor = System.Drawing.Color.Transparent;
            this.messageLoungeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoungeQty.Location = new System.Drawing.Point(132, 315);
            this.messageLoungeQty.Name = "messageLoungeQty";
            this.messageLoungeQty.Size = new System.Drawing.Size(29, 18);
            this.messageLoungeQty.TabIndex = 17;
            this.messageLoungeQty.Text = "LR";
            // 
            // messageTutoringQty
            // 
            this.messageTutoringQty.AutoSize = true;
            this.messageTutoringQty.Location = new System.Drawing.Point(396, 507);
            this.messageTutoringQty.Name = "messageTutoringQty";
            this.messageTutoringQty.Size = new System.Drawing.Size(0, 16);
            this.messageTutoringQty.TabIndex = 18;
            // 
            // messageOrientationQty
            // 
            this.messageOrientationQty.AutoSize = true;
            this.messageOrientationQty.BackColor = System.Drawing.Color.Transparent;
            this.messageOrientationQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageOrientationQty.Location = new System.Drawing.Point(127, 621);
            this.messageOrientationQty.Name = "messageOrientationQty";
            this.messageOrientationQty.Size = new System.Drawing.Size(32, 18);
            this.messageOrientationQty.TabIndex = 19;
            this.messageOrientationQty.Text = "OO";
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.BackColor = System.Drawing.Color.Transparent;
            this.purchasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLabel.Location = new System.Drawing.Point(797, 138);
            this.purchasedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(29, 17);
            this.purchasedLabel.TabIndex = 20;
            this.purchasedLabel.Text = "list";
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.backGroundShop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1213, 688);
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
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
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