using System;
using System.Drawing;
using System.Windows.Forms;

public class TransparentControl : Control
{
    private bool _mouseDown = false;
    private bool _mouseHover = false;
    private bool _invalidateRequired = true;

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
            return false;
        }
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

    // web example
    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        _mouseDown = true;
        _invalidateRequired = true;
        this.Invalidate();
    }
    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        _mouseDown = false;
        _invalidateRequired = true;
        this.Invalidate();
    }
    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);
        _mouseHover = true;
        if (_invalidateRequired)
        {
            this.Invalidate();
            _invalidateRequired = false;
        }
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _mouseHover = false;

        this.Invalidate();
        _invalidateRequired = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Rectangle r = new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
        Color bg = Color.Transparent;
        Color fr = Color.Gray;
        Color br = Color.FromArgb(173, 178, 173);
        if (_mouseDown)
        {
            fr = Color.White;
        }
        if (_mouseHover)
            br = Color.FromArgb(24, 162, 231);
        e.Graphics.FillRectangle(new SolidBrush(bg), r);
        e.Graphics.DrawRectangle(new Pen(br, 3), r);
        StringFormat sf = new StringFormat();
        sf.LineAlignment = StringAlignment.Center;
        sf.Alignment = StringAlignment.Center;
        e.Graphics.DrawString(Text, this.Font, new SolidBrush(fr), r, sf);
    }
}
