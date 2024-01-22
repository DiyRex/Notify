namespace Notify
{
    partial class NotifyPopup
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
            this.notifyImageBox = new System.Windows.Forms.PictureBox();
            this.lblMessageBody = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.notifyImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyImageBox
            // 
            this.notifyImageBox.BackColor = System.Drawing.Color.Transparent;
            this.notifyImageBox.Location = new System.Drawing.Point(12, 12);
            this.notifyImageBox.Name = "notifyImageBox";
            this.notifyImageBox.Size = new System.Drawing.Size(80, 80);
            this.notifyImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.notifyImageBox.TabIndex = 5;
            this.notifyImageBox.TabStop = false;
            // 
            // lblMessageBody
            // 
            this.lblMessageBody.AutoSize = true;
            this.lblMessageBody.BackColor = System.Drawing.Color.Transparent;
            this.lblMessageBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageBody.Location = new System.Drawing.Point(191, 47);
            this.lblMessageBody.Name = "lblMessageBody";
            this.lblMessageBody.Size = new System.Drawing.Size(11, 16);
            this.lblMessageBody.TabIndex = 4;
            this.lblMessageBody.Text = "-";
            this.lblMessageBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(190, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(16, 21);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "-";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NotifyPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 104);
            this.ControlBox = false;
            this.Controls.Add(this.notifyImageBox);
            this.Controls.Add(this.lblMessageBody);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotifyPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.notifyImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox notifyImageBox;
        private System.Windows.Forms.Label lblMessageBody;
        private System.Windows.Forms.Label lblTitle;
    }
}