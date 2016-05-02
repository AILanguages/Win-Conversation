using System.Drawing;
using System.Windows.Forms;

public class TransparentControl : Control
{
    public TransparentControl()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.Opaque, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
        this.BackColor = Color.Transparent;
        this.TabStop = false;
        //this.FlatStyle = FlatStyle.Flat;
        // this.FlatAppearance.BorderSize = 0;
    }

    protected override bool ShowFocusCues
    {
        get
        {
            //return base.ShowFocusCues;
            return false;
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;
        g.DrawRectangle(Pens.Black, this.ClientRectangle);
    }


    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // don't call the base class
        //base.OnPaintBackground(pevent);
    }


    protected override CreateParams CreateParams
    {
        get
        {
            const int WS_EX_TRANSPARENT = 0x20;
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= WS_EX_TRANSPARENT;
            return cp;
        }
    }
}
