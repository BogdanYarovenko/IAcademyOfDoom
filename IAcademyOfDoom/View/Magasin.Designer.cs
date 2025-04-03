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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(830, 178);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(172, 61);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(830, 305);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(172, 61);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(43, 173);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(181, 82);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Rest room\r\n\r\nCost : 5";
            this.restRoomButton.UseVisualStyleBackColor = true;
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(372, 173);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(181, 82);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Lounge room\r\n\r\nCost : 5";
            this.loungeRoomButton.UseVisualStyleBackColor = true;
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(42, 349);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(181, 82);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Orientation office\r\n\r\nCost : 5\r\n";
            this.orientationOfficeButton.UseVisualStyleBackColor = true;
            // 
            // tutoringRoomButton
            // 
            this.tutoringRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringRoomButton.Location = new System.Drawing.Point(372, 349);
            this.tutoringRoomButton.Name = "tutoringRoomButton";
            this.tutoringRoomButton.Size = new System.Drawing.Size(181, 82);
            this.tutoringRoomButton.TabIndex = 6;
            this.tutoringRoomButton.Text = "Tutoring rooms\r\n\r\nCost : 5\r\n";
            this.tutoringRoomButton.UseVisualStyleBackColor = true;
            // 
            // restRoomQty
            // 
            this.restRoomQty.AutoSize = true;
            this.restRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomQty.Location = new System.Drawing.Point(246, 206);
            this.restRoomQty.Name = "restRoomQty";
            this.restRoomQty.Size = new System.Drawing.Size(43, 16);
            this.restRoomQty.TabIndex = 7;
            this.restRoomQty.Text = "Qty : 4";
            // 
            // loungeRoomQty
            // 
            this.loungeRoomQty.AutoSize = true;
            this.loungeRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomQty.Location = new System.Drawing.Point(580, 206);
            this.loungeRoomQty.Name = "loungeRoomQty";
            this.loungeRoomQty.Size = new System.Drawing.Size(43, 16);
            this.loungeRoomQty.TabIndex = 8;
            this.loungeRoomQty.Text = "Qty : 4";
            // 
            // orientOfficeQty
            // 
            this.orientOfficeQty.AutoSize = true;
            this.orientOfficeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientOfficeQty.Location = new System.Drawing.Point(246, 382);
            this.orientOfficeQty.Name = "orientOfficeQty";
            this.orientOfficeQty.Size = new System.Drawing.Size(43, 16);
            this.orientOfficeQty.TabIndex = 9;
            this.orientOfficeQty.Text = "Qty : 3";
            // 
            // tutorRoomQty
            // 
            this.tutorRoomQty.AutoSize = true;
            this.tutorRoomQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorRoomQty.Location = new System.Drawing.Point(580, 382);
            this.tutorRoomQty.Name = "tutorRoomQty";
            this.tutorRoomQty.Size = new System.Drawing.Size(112, 16);
            this.tutorRoomQty.TabIndex = 10;
            this.tutorRoomQty.Text = "Qty : 1 / each type";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 554);
            this.splitter1.TabIndex = 12;
            this.splitter1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Purchased item :";
            // 
            // buyableLabel
            // 
            this.buyableLabel.AutoSize = true;
            this.buyableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyableLabel.Location = new System.Drawing.Point(405, 103);
            this.buyableLabel.Name = "buyableLabel";
            this.buyableLabel.Size = new System.Drawing.Size(125, 32);
            this.buyableLabel.TabIndex = 15;
            this.buyableLabel.Text = "Buyable";
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Magasin";
            this.Text = "Magasin";
            this.Load += new System.EventHandler(this.Magasin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
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
    }
}