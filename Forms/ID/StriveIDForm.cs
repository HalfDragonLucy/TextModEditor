namespace CommandListEditor;
public partial class StriveIDForm : Form
{
    public string ID
    {
        get; set;
    }
    public StriveIDForm()
    {
        InitializeComponent();
    }

    private void ConfirmKey(object sender, EventArgs e) => ID = IDBox.SelectedItem.ToString();

    private void CheckIfBoxSelected(object sender, EventArgs e) => BtnConfirm.Enabled = IDBox.SelectedItem != null;
}
