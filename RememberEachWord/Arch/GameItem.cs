using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RememberEachWord
{
    public partial class GameItem : UserControl
    {
        private string itemText = "";
        private int thisWidth = 350;
        private int thisHeight = 43;
        private bool on = false;
        private Font font = null;
        private StringFormat sf = null;
        private bool change = false;
        private Timer timer = new Timer();
        private int counter = 0;
        private int inc = 1;

        public int ThisWidth
        {
            get
            {
                return thisWidth;
            }
            set
            {
                thisWidth = value;
                CalcHeight();
                Refresh();
            }
        }
        public int ThisHeight
        {
            get
            {
                return thisHeight;
            }
            set
            {
                thisHeight = value;
                CalcWidth();
                Refresh();
            }
        }
        public bool On
        {
            get
            {
                return on;
            }
            set
            {
                if (value != on)
                {
                    if (on)
                    {
                        inc = -1;
                        counter = 10;
                    }
                    else
                    {
                        inc = 1;
                        counter = 0;
                    }
                    change = true;
                    timer.Start();
                }
            }
        }
        public string ItemText
        {
            get
            {
                return itemText;
            }
            set
            {
                itemText = value;
            }
        }

        private GameItem()
        {
            InitializeComponent();

            timer.Interval = 50;
            timer.Enabled = false;
            timer.Tick += new EventHandler(timer_Tick);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);
            Bitmap allBmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            Graphics allBmpGr = Graphics.FromImage(allBmp);

            allBmpGr.Clear(this.BackColor);

            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            Graphics bmpGr = Graphics.FromImage(bmp);

            Rectangle rect2 = new Rectangle(
                        this.ClientRectangle.X,
                        this.ClientRectangle.Y,
                        this.ClientRectangle.Width,
                        this.ClientRectangle.Height * counter / 10);
            Rectangle rect3 = new Rectangle(
                        this.ClientRectangle.X,
                        this.ClientRectangle.Y + this.ClientRectangle.Height * counter / 10,
                        this.ClientRectangle.Width,
                        this.ClientRectangle.Height * (10 - counter) / 10);

            bmpGr.DrawString(itemText, font, new SolidBrush(Color.Black), this.ClientRectangle, sf);
            bmpGr.DrawString(itemText, font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
            allBmpGr.DrawImage(bmp, rect2);

            bmp.Dispose();
            bmp = null;

            gr.DrawImage(allBmp, this.ClientRectangle);

            allBmpGr.Dispose();
            allBmp = null;

            counter += inc;
            if ((counter == 10) || (counter == 0))
            {
                timer.Stop();
                change = false;
                on = !on;
                Refresh();
            }
        }

        //public GameItem(int index, string text, bool state) : this()
        //{
        //    on = state;
        //    itemText = text;
        //    sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;
        //    sf.LineAlignment = StringAlignment.Center;

        //    CalcWidth();
        //}

        private void CalcWidth()
        {

            if (font != null) font.Dispose();
            font = new Font("Times New Roman", thisHeight * 3 / 5, FontStyle.Bold);
            this.Size = new Size(thisWidth, thisHeight);
        }

        private void CalcHeight()
        {

            if (font != null) font.Dispose();
            font = new Font("Times New Roman", thisHeight * 3 / 5, FontStyle.Bold);
            this.Size = new Size(thisWidth, thisHeight);
        }

        private void GameItem_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (!change)
            {
                Rectangle rect = new Rectangle(
                        this.ClientRectangle.X + 1,
                        this.ClientRectangle.Y + 1,
                        this.ClientRectangle.Width,
                        this.ClientRectangle.Height);
                gr.DrawString(itemText, font, new SolidBrush(Color.Black), rect, sf);

                if (on)
                {
                    gr.DrawString(itemText, font, new SolidBrush(this.ForeColor), this.ClientRectangle, sf);
                }

            }
            //gr.DrawRectangle(new Pen(Color.Black), new Rectangle(this.ClientRectangle.X,
            //    this.ClientRectangle.Y,
            //    this.ClientRectangle.Width - 1,
            //    this.ClientRectangle.Height - 1));
        }
    }
}
