using TextModEditor.Scripts;

namespace CommandListEditor;
public partial class RemoveKeyForm : Form
{
    public RemoveKeyForm()
    {
        InitializeComponent();

        LiteralBox.Items.Clear();
        WordedBox.Items.Clear();

        LiteralBox.Items.AddRange(KeysManager.literal.ToArray());
        LiteralBox.SelectedIndex = 0;
        WordedBox.Items.AddRange(KeysManager.worded.ToArray());
        WordedBox.SelectedIndex = 0;
    }

    private void ConfirmKey(object sender, EventArgs e) => KeysManager.Remove(LiteralBox.SelectedItem.ToString(), WordedBox.SelectedItem.ToString());

    private void CheckIfBoxSelected(object sender, EventArgs e) => BtnConfirm.Enabled = LiteralBox.SelectedItem != null && WordedBox.SelectedItem != null;

    private void LiteralBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (LiteralBox.SelectedIndex != 0)
        {
            WordedBox.SelectedIndex = LiteralBox.SelectedIndex;
        }
    }
}
