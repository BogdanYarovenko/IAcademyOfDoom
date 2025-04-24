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
            this.restRoomQty = new System.Windows.Forms.Label();
            this.loungeRoomQty = new System.Windows.Forms.Label();
            this.orientOfficeQty = new System.Windows.Forms.Label();
            this.tutorRoomQty = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label4 = new System.Windows.Forms.Label();
            this.messageRestQty = new System.Windows.Forms.Label();
            this.messageLoungeQty = new System.Windows.Forms.Label();
            this.messageTutoringQty = new System.Windows.Forms.Label();
            this.messageOrientationQty = new System.Windows.Forms.Label();
            this.purchasedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnalyseBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.CommunicateBtn = new System.Windows.Forms.Button();
            this.RecogniseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.Control;
            this.okButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.okButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.Location = new System.Drawing.Point(587, 442);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(197, 81);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(825, 442);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(205, 81);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BalanceInMagasin
            // 
            this.BalanceInMagasin.AutoSize = true;
            this.BalanceInMagasin.BackColor = System.Drawing.Color.Transparent;
            this.BalanceInMagasin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceInMagasin.Location = new System.Drawing.Point(569, 41);
            this.BalanceInMagasin.Name = "BalanceInMagasin";
            this.BalanceInMagasin.Size = new System.Drawing.Size(146, 26);
            this.BalanceInMagasin.TabIndex = 2;
            this.BalanceInMagasin.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.BackColor = System.Drawing.Color.Transparent;
            this.restRoomButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.restRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.restRoomButton.FlatAppearance.BorderSize = 2;
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(377, 183);
            this.restRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(151, 68);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Buy RR";
            this.restRoomButton.UseVisualStyleBackColor = false;
            this.restRoomButton.Click += new System.EventHandler(this.RestRoomButton_Click);
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.BackColor = System.Drawing.Color.Transparent;
            this.loungeRoomButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.loungeRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loungeRoomButton.FlatAppearance.BorderSize = 2;
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(92, 183);
            this.loungeRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(151, 68);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Buy LR";
            this.loungeRoomButton.UseVisualStyleBackColor = false;
            this.loungeRoomButton.Click += new System.EventHandler(this.LoungeRoomButton_Click);
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.BackColor = System.Drawing.Color.Black;
            this.orientationOfficeButton.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.orientationOfficeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orientationOfficeButton.FlatAppearance.BorderSize = 2;
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(91, 449);
            this.orientationOfficeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(151, 68);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Buy OO";
            this.orientationOfficeButton.UseVisualStyleBackColor = false;
            this.orientationOfficeButton.Click += new System.EventHandler(this.OrientationOfficeButton_Click);
            // 
            // restRoomQty
            // 
            this.restRoomQty.AutoSize = true;
            this.restRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.restRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomQty.Location = new System.Drawing.Point(373, 164);
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
            this.loungeRoomQty.Location = new System.Drawing.Point(93, 164);
            this.loungeRoomQty.Name = "loungeRoomQty";
            this.loungeRoomQty.Size = new System.Drawing.Size(16, 16);
            this.loungeRoomQty.TabIndex = 8;
            this.loungeRoomQty.Text = "q";
            // 
            // orientOfficeQty
            // 
            this.orientOfficeQty.AutoSize = true;
            this.orientOfficeQty.BackColor = System.Drawing.Color.Transparent;
            this.orientOfficeQty.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientOfficeQty.Location = new System.Drawing.Point(93, 431);
            this.orientOfficeQty.Name = "orientOfficeQty";
            this.orientOfficeQty.Size = new System.Drawing.Size(17, 18);
            this.orientOfficeQty.TabIndex = 9;
            this.orientOfficeQty.Text = "q";
            // 
            // tutorRoomQty
            // 
            this.tutorRoomQty.AutoSize = true;
            this.tutorRoomQty.BackColor = System.Drawing.Color.Transparent;
            this.tutorRoomQty.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorRoomQty.Location = new System.Drawing.Point(380, 337);
            this.tutorRoomQty.Name = "tutorRoomQty";
            this.tutorRoomQty.Size = new System.Drawing.Size(131, 18);
            this.tutorRoomQty.TabIndex = 10;
            this.tutorRoomQty.Text = "Qty : 1 / each type";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 554);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchased items :";
            // 
            // messageRestQty
            // 
            this.messageRestQty.AutoSize = true;
            this.messageRestQty.BackColor = System.Drawing.Color.Transparent;
            this.messageRestQty.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageRestQty.Location = new System.Drawing.Point(375, 254);
            this.messageRestQty.Name = "messageRestQty";
            this.messageRestQty.Size = new System.Drawing.Size(29, 19);
            this.messageRestQty.TabIndex = 16;
            this.messageRestQty.Text = "RR";
            // 
            // messageLoungeQty
            // 
            this.messageLoungeQty.AutoSize = true;
            this.messageLoungeQty.BackColor = System.Drawing.Color.Transparent;
            this.messageLoungeQty.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLoungeQty.Location = new System.Drawing.Point(93, 254);
            this.messageLoungeQty.Name = "messageLoungeQty";
            this.messageLoungeQty.Size = new System.Drawing.Size(27, 19);
            this.messageLoungeQty.TabIndex = 17;
            this.messageLoungeQty.Text = "LR";
            // 
            // messageTutoringQty
            // 
            this.messageTutoringQty.AutoSize = true;
            this.messageTutoringQty.Location = new System.Drawing.Point(396, 501);
            this.messageTutoringQty.Name = "messageTutoringQty";
            this.messageTutoringQty.Size = new System.Drawing.Size(0, 16);
            this.messageTutoringQty.TabIndex = 18;
            // 
            // messageOrientationQty
            // 
            this.messageOrientationQty.AutoSize = true;
            this.messageOrientationQty.BackColor = System.Drawing.Color.Transparent;
            this.messageOrientationQty.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageOrientationQty.Location = new System.Drawing.Point(93, 519);
            this.messageOrientationQty.Name = "messageOrientationQty";
            this.messageOrientationQty.Size = new System.Drawing.Size(31, 19);
            this.messageOrientationQty.TabIndex = 19;
            this.messageOrientationQty.Text = "OO";
            // 
            // purchasedLabel
            // 
            this.purchasedLabel.AutoSize = true;
            this.purchasedLabel.BackColor = System.Drawing.Color.Transparent;
            this.purchasedLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedLabel.Location = new System.Drawing.Point(583, 119);
            this.purchasedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purchasedLabel.Name = "purchasedLabel";
            this.purchasedLabel.Size = new System.Drawing.Size(27, 18);
            this.purchasedLabel.TabIndex = 20;
            this.purchasedLabel.Text = "list";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rest Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 22;
            this.label2.Text = "TutoringRoom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 23;
            this.label3.Text = "Orientation Office";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "Lounge Room";
            // 
            // AnalyseBtn
            // 
            this.AnalyseBtn.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.AnalyseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnalyseBtn.FlatAppearance.BorderSize = 2;
            this.AnalyseBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyseBtn.Location = new System.Drawing.Point(377, 357);
            this.AnalyseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnalyseBtn.Name = "AnalyseBtn";
            this.AnalyseBtn.Size = new System.Drawing.Size(149, 37);
            this.AnalyseBtn.TabIndex = 25;
            this.AnalyseBtn.Text = "Analyse";
            this.AnalyseBtn.UseVisualStyleBackColor = true;
            this.AnalyseBtn.Click += new System.EventHandler(this.AnalyseBtn_Click);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.GenerateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GenerateBtn.FlatAppearance.BorderSize = 2;
            this.GenerateBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBtn.Location = new System.Drawing.Point(377, 439);
            this.GenerateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(149, 37);
            this.GenerateBtn.TabIndex = 27;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // CommunicateBtn
            // 
            this.CommunicateBtn.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.CommunicateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CommunicateBtn.FlatAppearance.BorderSize = 2;
            this.CommunicateBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunicateBtn.Location = new System.Drawing.Point(377, 480);
            this.CommunicateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CommunicateBtn.Name = "CommunicateBtn";
            this.CommunicateBtn.Size = new System.Drawing.Size(149, 37);
            this.CommunicateBtn.TabIndex = 28;
            this.CommunicateBtn.Text = "Communicate";
            this.CommunicateBtn.UseVisualStyleBackColor = true;
            this.CommunicateBtn.Click += new System.EventHandler(this.CommunicateBtn_Click);
            // 
            // RecogniseBtn
            // 
            this.RecogniseBtn.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.button;
            this.RecogniseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecogniseBtn.FlatAppearance.BorderSize = 2;
            this.RecogniseBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecogniseBtn.Location = new System.Drawing.Point(377, 398);
            this.RecogniseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RecogniseBtn.Name = "RecogniseBtn";
            this.RecogniseBtn.Size = new System.Drawing.Size(149, 37);
            this.RecogniseBtn.TabIndex = 29;
            this.RecogniseBtn.Text = "Recognise";
            this.RecogniseBtn.UseVisualStyleBackColor = true;
            this.RecogniseBtn.Click += new System.EventHandler(this.RecogniseBtn_Click);
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IAcademyOfDoom.Properties.Resources.DesignMagasin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RecogniseBtn);
            this.Controls.Add(this.CommunicateBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.AnalyseBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchasedLabel);
            this.Controls.Add(this.messageOrientationQty);
            this.Controls.Add(this.messageTutoringQty);
            this.Controls.Add(this.messageLoungeQty);
            this.Controls.Add(this.messageRestQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tutorRoomQty);
            this.Controls.Add(this.orientOfficeQty);
            this.Controls.Add(this.loungeRoomQty);
            this.Controls.Add(this.restRoomQty);
            this.Controls.Add(this.orientationOfficeButton);
            this.Controls.Add(this.loungeRoomButton);
            this.Controls.Add(this.restRoomButton);
            this.Controls.Add(this.BalanceInMagasin);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Magasin";
            this.Text = "Magasin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Magasin_FormClosing);
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
        private System.Windows.Forms.Label restRoomQty;
        private System.Windows.Forms.Label loungeRoomQty;
        private System.Windows.Forms.Label orientOfficeQty;
        private System.Windows.Forms.Label tutorRoomQty;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label messageRestQty;
        private System.Windows.Forms.Label messageLoungeQty;
        private System.Windows.Forms.Label messageTutoringQty;
        private System.Windows.Forms.Label messageOrientationQty;
        private System.Windows.Forms.Label purchasedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AnalyseBtn;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button CommunicateBtn;
        private System.Windows.Forms.Button RecogniseBtn;
    }
}