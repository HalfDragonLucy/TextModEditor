using CommandListEditor;

namespace TextModEditor.Controls;
public partial class AddEntry : UserControl
{
    private readonly MainForm form;
    public AddEntry(MainForm _form)
    {
        InitializeComponent();
        form = _form;

    }

    private void AddEntry_(object sender, EventArgs e)
    {
        form.UI.Controls.Add(new Entry(form.UI.Controls.Count, "Header", "Body"));
        form.UI.Controls.SetChildIndex(this, form.UI.Controls.IndexOf(this) + 1);
    }
}