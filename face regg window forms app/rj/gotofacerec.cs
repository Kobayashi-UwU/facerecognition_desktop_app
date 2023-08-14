using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using AForge;

namespace face_regg_window_forms_app
{
    [DefaultEvent("Click")]
    public partial class gotofacerec : UserControl
    {
        int wh = 20;
        float ang = 45;
        Color cl0 = Color.Blue, cl1 = Color.Orange;
        Timer t = new Timer();
        string txt = "START";

        public gotofacerec()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();
            t.Tick += (s, e) => { Angle = Angle % 360 + 1; };
            ForeColor = Color.White;
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        public int BoarderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return cl0; }
            set { cl0 = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return cl1; }
            set { cl1 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width - wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width - wh, Height - wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height - wh, wh, wh), 90, 90);

            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle, cl0, cl1, ang), gp);
            e.Graphics.DrawString(txt, Font, new SolidBrush(ForeColor), ClientRectangle, new StringFormat() { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Center });
            base.OnPaint(e);
        }

    }

}
