using TextModEditor.Scripts;

namespace CommandListEditor;
public partial class AddKeyForm : Form
{

    public AddKeyForm()
    {
        InitializeComponent();
    }

    private void ConfirmKey(object sender, EventArgs e) => KeysManager.Add(LiteralBox.Text, WordedBox.Text);

    private void CheckIfTextFiled(object sender, EventArgs e) => BtnConfirm.Enabled = LiteralBox.Text.Length > 0 && WordedBox.Text.Length > 0;
}
