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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your balance :";
            // 
            // restRoomButton
            // 
            this.restRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restRoomButton.Location = new System.Drawing.Point(80, 157);
            this.restRoomButton.Name = "restRoomButton";
            this.restRoomButton.Size = new System.Drawing.Size(181, 82);
            this.restRoomButton.TabIndex = 3;
            this.restRoomButton.Text = "Rest room\r\n\r\nCost : 5";
            this.restRoomButton.UseVisualStyleBackColor = true;
            // 
            // loungeRoomButton
            // 
            this.loungeRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loungeRoomButton.Location = new System.Drawing.Point(313, 157);
            this.loungeRoomButton.Name = "loungeRoomButton";
            this.loungeRoomButton.Size = new System.Drawing.Size(181, 82);
            this.loungeRoomButton.TabIndex = 4;
            this.loungeRoomButton.Text = "Lounge room\r\n\r\nCost : 5";
            this.loungeRoomButton.UseVisualStyleBackColor = true;
            // 
            // orientationOfficeButton
            // 
            this.orientationOfficeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orientationOfficeButton.Location = new System.Drawing.Point(80, 284);
            this.orientationOfficeButton.Name = "orientationOfficeButton";
            this.orientationOfficeButton.Size = new System.Drawing.Size(181, 82);
            this.orientationOfficeButton.TabIndex = 5;
            this.orientationOfficeButton.Text = "Orientation office\r\n\r\nCost : 5\r\n";
            this.orientationOfficeButton.UseVisualStyleBackColor = true;
            // 
            // tutoringRoomButton
            // 
            this.tutoringRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutoringRoomButton.Location = new System.Drawing.Point(313, 284);
            this.tutoringRoomButton.Name = "tutoringRoomButton";
            this.tutoringRoomButton.Size = new System.Drawing.Size(181, 82);
            this.tutoringRoomButton.TabIndex = 6;
            this.tutoringRoomButton.Text = "Tutoring rooms\r\n\r\nCost : 5\r\n";
            this.tutoringRoomButton.UseVisualStyleBackColor = true;
            // 
            // Magasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}