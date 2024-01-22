using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Notify
{
    public partial class NotifyPopup : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int duration;
        private int timeout;
        public NotifyPopup(Color bodyColor, Color textColor, int duration, int timerInterval, double opacity, string title, string messageBody, string author = "", string notifyImage = null, int imgSize = 50)
        {
            InitializeComponent();
            SetFormSize();
            CenterFormOnScreen();

            this.duration = duration;
            this.timeout = timerInterval;

            if (!bodyColor.IsEmpty)
            {
                this.BackColor = bodyColor;
                this.lblMessageBody.ForeColor = textColor;
                this.lblTitle.ForeColor = textColor;
            }

            arrangeContent(opacity, title, messageBody, author, notifyImage);

            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = timerInterval;
            animationTimer.Tick += aniamtionTimer_Tick;

            animationTimer.Start();
        }


        private void arrangeContent(double opacity, string title, string messageBody, string author = "", string notifyImage = null, int imgSize = 50)
        {
            this.Opacity = opacity;


            if (!string.IsNullOrEmpty(title) && title.Length > 30)
            {
                lblTitle.Text = title.Substring(0, 30);
            }
            else
            {
                lblTitle.Text = title;
            }
            if (!string.IsNullOrEmpty(messageBody) && messageBody.Length > 150)
            {
                lblMessageBody.Text = messageBody.Substring(0, 150);
            }
            else
            {
                lblMessageBody.Text = messageBody;
            }
            if (!string.IsNullOrEmpty(notifyImage))
            {
                Image image = Image.FromFile(notifyImage);

                int newWidth = imgSize;
                int newHeight = imgSize;

                Bitmap resizedImage = new Bitmap(newWidth, newHeight);

                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.DrawImage(image, 0, 0, newWidth, newHeight);
                }

                notifyImageBox.Image = resizedImage;
            }
            int title_width = (int)(this.Width - lblTitle.Width) / 2;
            lblTitle.Location = new Point(title_width, lblTitle.Location.Y);
            lblMessageBody.AutoSize = true;
            lblMessageBody.TextAlign = ContentAlignment.MiddleLeft;
            lblMessageBody.AutoEllipsis = false;

            int labelWidth = (2 * this.Width) / 3;
            lblMessageBody.Width = labelWidth;
            lblMessageBody.MaximumSize = new Size(labelWidth, int.MaxValue);
            lblMessageBody.Location = new Point((this.Width - lblMessageBody.Width + 50) / 2, lblTitle.Bottom + 15);



        }
        private void SetFormSize()
        {
            Screen screen = Screen.PrimaryScreen;
            int width = (int)(screen.WorkingArea.Width * 1.5 / 5.0);
            int height = (int)(screen.WorkingArea.Height * 0.5 / 5.0);

            this.Size = new System.Drawing.Size(width, height);
        }
        private void CenterFormOnScreen()
        {
            Screen screen = Screen.PrimaryScreen;
            int x = (screen.WorkingArea.Width - this.Width) / 2;
            int y = -200;

            this.Location = new System.Drawing.Point(x, y);
        }
        private void aniamtionTimer_Tick(object sender, EventArgs e)
        {
            if (this.Location.Y < 0)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 2);
            }
            else
            {
                animationTimer.Stop();
                Thread.Sleep(duration);
                rollUp();
                animationTimer.Enabled = false;
            }
        }
        private void rollUp()
        {
            for (int i = 0; i < 100; i++)
            {
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 2);
                Thread.Sleep(timeout);
            }
            this.Close();
        }
    }
}
