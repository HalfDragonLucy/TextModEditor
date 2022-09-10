namespace TextModEditor.Controls;
public partial class NoScrollBarListBox : ListBox
{
    private bool mShowScroll;
    protected override System.Windows.Forms.CreateParams CreateParams
    {
        get
        {
            var cp = base.CreateParams;
            if (!mShowScroll)
            {
                cp.Style &= ~0x200000;
            }

            return cp;
        }
    }
    public bool ShowScrollbar
    {
        get => mShowScroll;
        set
        {
            if (value != mShowScroll)
            {
                mShowScroll = value;
                if (IsHandleCreated)
                {
                    RecreateHandle();
                }
            }
        }
    }
}
