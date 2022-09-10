using TextModEditor.Scripts;

namespace CommandListEditor;
public partial class KeysForm : Form
{
    public KeysForm()
    {
        InitializeComponent();

        KeysManager.GetKeys();

        RawList.Items.AddRange(KeysManager.literal.ToArray());
        WordedList.Items.AddRange(KeysManager.worded.ToArray());
    }

    private void AddKey(object sender, EventArgs e)
    {
        var addKeyForm = new AddKeyForm();
        if (addKeyForm.ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show("A restart is required to update the keys.\nTo not loose your progress please export your file before leaving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void RemoveKey(object sender, EventArgs e)
    {
        var removeKeyForm = new RemoveKeyForm();
        if (removeKeyForm.ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show("A restart is required to update the keys.\nTo not loose your progress please export your file before leaving.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void SyncTimer_Tick(object sender, EventArgs e)
    {
        if (WordedList.TopIndex != RawList.TopIndex)
        {
            WordedList.TopIndex = RawList.TopIndex;
        }

        if (WordedList.SelectedIndex != RawList.SelectedIndex)
        {
            WordedList.SelectedIndex = RawList.SelectedIndex;
        }
    }
}
