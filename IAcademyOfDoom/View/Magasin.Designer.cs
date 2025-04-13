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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.Control;
            this.okButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(440, 359);
            this.okButton.Margin = new System.Windows.Forms.Padding(2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(148, 66);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(619, 359);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(154, 66);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BalanceInMagasin
            // 
            this.BalanceInMagasin.AutoSize = true;
            this.BalanceInMagasin.BackColor = System.Drawing.Color.Transparent;
            this.BalanceInMagasin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInMagasin.Location = new System.Drawing.Point(436, 71);
            this.BalanceInMagasin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BalanceInMagasin.Name = "BalanceInMagasin";
            this.BalanceInMagasin.Size = new System.Drawing.Size(125, 20);
            this.BalanceInMagasin.TabIndex = 2;
            this.BalanceInMagasin.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.BackColor = System.Drawing.Color.Transparent;
            this.restRoomButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.restRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restRoomButton.FlatAppearance.BorderSize = 2;
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(283, 174);
            this.restRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(113, 55);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Buy RR";
            this.restRoomButton.UseVisualStyleBackColor = false;
            this.restRoomButton.Click += new System.EventHandler(this.restRoomButton_Click);
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.BackColor = System.Drawing.Color.Transparent;
            this.loungeRoomButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.loungeRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loungeRoomButton.FlatAppearance.BorderSize = 2;
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(73, 174);
            this.loungeRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(113, 55);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Buy LR";
            this.loungeRoomButton.UseVisualStyleBackColor = false;
            this.loungeRoomButton.Click += new System.EventHandler(this.loungeRoomButton_Click);
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.BackColor = System.Drawing.Color.Black;
            this.orientationOfficeButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.orientationOfficeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orientationOfficeButton.FlatAppearance.BorderSize = 2;
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(70, 386);
            this.orientationOfficeButton.Margin = new System.Windows.Forms.Padding(2);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(113, 55);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Buy OO";
            this.orientationOfficeButton.UseVisualStyleBackColor = false;
            this.orientationOfficeButton.Click += new System.EventHandler(this.orientationOfficeButton_Click);
            // 
            // tutoringRoomButton
            // 
            this.tutoringRoomButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.tutoringRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tutoringRoomButton.FlatAppearance.BorderSize = 2;
            this.tutoringRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringRoomButton.Location = new System.Drawing.Point(283, 386);
            this.tutoringRoomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tutoringRoomButton.Name = "tutoringRoomButton";
            this.tutoringRoomButton.Size = new System.Drawing.Size(113, 55);
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
            this.restRoomQty.Location = new System.Drawing.Point(280, 149);
            this.restRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.restRoomQty.Name = "restRoomQty";
            this.restRoomQty.Size = new System.Drawing.Size(14, 13);
            this.restRoomQty.TabIndex = 7;
            this.restRoomQty.Text = "q";
            // 
            // loungeRoomQty
            // 
            this.loungeRoomQty.AutoSize = true;
            this.loungeRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.loungeRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomQty.Location = new System.Drawing.Point(70, 149);
            this.loungeRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loungeRoomQty.Name = "loungeRoomQty";
            this.loungeRoomQty.Size = new System.Drawing.Size(14, 13);
            this.loungeRoomQty.TabIndex = 8;
            this.loungeRoomQty.Text = "q";
            // 
            // orientOfficeQty
            // 
            this.orientOfficeQty.AutoSize = true;
            this.orientOfficeQty.BackColor = System.Drawing.Color.Transparent;
            this.orientOfficeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientOfficeQty.Location = new System.Drawing.Point(66, 371);
            this.orientOfficeQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orientOfficeQty.Name = "orientOfficeQty";
            this.orientOfficeQty.Size = new System.Drawing.Size(14, 13);
            this.orientOfficeQty.TabIndex = 9;
            this.orientOfficeQty.Text = "q";
            // 
            // tutorRoomQty
            // 
            this.tutorRoomQty.AutoSize = true;
            this.tutorRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.tutorRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorRoomQty.Location = new System.Drawing.Point(281, 371);
            this.tutorRoomQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tutorRoomQty.Name = "tutorRoomQty";
            this.tutorRoomQty.Size = new System.Drawing.Size(115, 13);
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
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchased items :";
            // 
            // buyableLabel
            // 
            this.buyableLabel.AutoSize = true;
            this.buyableLabel.BackColor = System.Drawing.Color.Transparent;
            this.buyableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyableLabel.Location = new System.Drawing.Point(435, 33);
            this.buyableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.buyableLabel.Name = "buyableLabel";
            this.buyableLabel.Size = new System.Drawing.Size(98, 26);
            this.buyableLabel.TabIndex = 15;
            this.buyableLabel.Text = "Buyable";
            // 
            // messageRestQty
            // 
            this.messageRestQty.AutoSize = true;
            this.messageRestQty.BackColor = System.Drawing.Color.Transparent;
            this.messageRestQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.messageRestQty.Location = new System.Drawing.Point(279, 66);
            this.messageRestQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageRestQty.Name = "messageRestQty";
            this.messageRestQty.Size = new System.Drawing.Size(27, 15);
            this.messageRestQty.TabIndex = 16;
            this.messageRestQty.Text = "RR";
            // 
            // messageLoungeQty
            // 
            this.messageLoungeQty.AutoSize = true;
            this.messageLoungeQty.BackColor = System.Drawing.Color.Transparent;
            this.messageLoungeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoungeQty.Location = new System.Drawing.Point(70, 66);
            this.messageLoungeQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageLoungeQty.Name = "messageLoungeQty";
            this.messageLoungeQty.Size = new System.Drawing.Size(25, 15);
            this.messageLoungeQty.TabIndex = 17;
            this.messageLoungeQty.Text = "LR";
            // 
            // messageTutoringQty
            // 
            this.messageTutoringQty.AutoSize = true;
            this.messageTutoringQty.Location = new System.Drawing.Point(297, 407);
            this.messageTutoringQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageTutoringQty.Name = "messageTutoringQty";
            this.messageTutoringQty.Size = new System.Drawing.Size(0, 13);
            this.messageTutoringQty.TabIndex = 18;
            // 
            // messageOrientationQty
            // 
            this.messageOrientationQty.AutoSize = true;
            this.messageOrientationQty.BackColor = System.Drawing.Color.Transparent;
            this.messageOrientationQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageOrientationQty.Location = new System.Drawing.Point(70, 282);
            this.messageOrientationQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.messageOrientationQty.Name = "messageOrientationQty";
            this.messageOrientationQty.Size = new System.Drawing.Size(27, 15);
            this.messageOrientationQty.TabIndex = 19;
            this.messageOrientationQty.Text = "OO";
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.BackColor = System.Drawing.Color.Transparent;
            this.purchasedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLabel.Location = new System.Drawing.Point(448, 149);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(23, 13);
            this.purchasedLabel.TabIndex = 20;
            this.purchasedLabel.Text = "list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "RestRoom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "TutoringRoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Orientation Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "LoungeRoom";
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.DesignMagasin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}