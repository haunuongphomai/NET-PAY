using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Project
{
    internal class SplitButton : Button
    {
        public ContextMenuStrip cms = new ContextMenuStrip();
        Bitmap bmpSplit;

        private string[] cole = { "Update", "Sign out" };
        public String[] coleCao
        {
            get { return cole; }
            set { cole = value; }   
        }

        protected override void InitLayout()
        {
            base.InitLayout();
            Split();
            for (int i=0;i<cole.LongLength;i++)
            {
                cms.Items.Add(cole[i]);
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (poise()) { cms.Show(this, 0, this.Height); }
        }

        private bool poise()
        {
            bool pos = false;

            int X = PointToClient(MousePosition).X;
            int Y = PointToClient(MousePosition).Y;

            if (X > this.Width - bmpSplit.Width && X < this.Width && Y > 0 && Y < this.Height)
            {
                pos = true;
            }

            return pos;
        }

        private void Split()
        {
            bmpSplit = new Bitmap(30, this.Height);

            Graphics gra = Graphics.FromImage(bmpSplit);

            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            Point[] pt =
            {
                new Point(20, bmpSplit.Height),
                new Point(10, bmpSplit.Height),
                new Point(15, bmpSplit.Height)
            };

            gra.FillPolygon(new SolidBrush(Color.Black), pt);
            gra.DrawLine(new Pen(Color.Black), new Point(0, bmpSplit.Height / 4), new Point(0, bmpSplit.Height));

            this.ImageAlign  = ContentAlignment.MiddleRight;
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Image = bmpSplit;
        }
    }
}
