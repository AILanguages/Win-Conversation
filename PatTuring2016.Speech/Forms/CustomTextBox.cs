using System.Drawing;
using System.Windows.Forms;

namespace PatTuring2016.Speech.Forms
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
        }

        //private void checkBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    base.OnPaint(e);

        //    if (!this.Enabled)
        //    {
        //        CheckBox checkbox = sender as CheckBox;

        //        int x = ClientRectangle.X + CheckBoxRenderer.GetGlyphSize(
        //            e.Graphics, CheckBoxState.UncheckedNormal).Width + 1;
        //        int y = ClientRectangle.Y + 1;

        //        TextRenderer.DrawText(e.Graphics, checkbox.Text,
        //            checkbox.Font, new Point(x, y), checkbox.ForeColor,
        //            TextFormatFlags.LeftAndRightPadding);
        //    }
        //}
    }
}
