using System;
using System.Drawing;
using System.Windows.Forms;

public class RoundPictureBox : PictureBox
{
    public int BorderRadius { get; set; } = 10; // Adjust the value to control the roundness

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);
        DrawRoundedBorder(pe.Graphics);
    }

    private void DrawRoundedBorder(Graphics graphics)
    {
        int borderRadius = BorderRadius;
        int borderThickness = 2; // Adjust this value to control the border thickness
        Color borderColor = Color.Black; // Change this color to your desired border color

        Rectangle borderRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        using (Pen borderPen = new Pen(borderColor, borderThickness))
        {
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            graphics.DrawArc(borderPen, new Rectangle(borderRect.Location, new Size(2 * borderRadius, 2 * borderRadius)), 180, 90);
            graphics.DrawLine(borderPen, borderRect.Left + borderRadius, borderRect.Top, borderRect.Right - borderRadius, borderRect.Top);
            graphics.DrawArc(borderPen, new Rectangle(new Point(borderRect.Width - 2 * borderRadius, 0), new Size(2 * borderRadius, 2 * borderRadius)), 270, 90);
            graphics.DrawLine(borderPen, borderRect.Right, borderRect.Top + borderRadius, borderRect.Right, borderRect.Bottom - borderRadius);
            graphics.DrawArc(borderPen, new Rectangle(new Point(borderRect.Width - 2 * borderRadius, borderRect.Height - 2 * borderRadius), new Size(2 * borderRadius, 2 * borderRadius)), 0, 90);
            graphics.DrawLine(borderPen, borderRect.Left + borderRadius, borderRect.Bottom, borderRect.Right - borderRadius, borderRect.Bottom);
            graphics.DrawArc(borderPen, new Rectangle(new Point(0, borderRect.Height - 2 * borderRadius), new Size(2 * borderRadius, 2 * borderRadius)), 90, 90);
            graphics.DrawLine(borderPen, borderRect.Left, borderRect.Top + borderRadius, borderRect.Left, borderRect.Bottom - borderRadius);
        }
    }
}
