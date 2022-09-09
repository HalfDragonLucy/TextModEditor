using TextModEditor.Scripts;

namespace CommandListEditor;
public partial class Entry : UserControl
{
    public int entryNumber;
    public string header, body;

    public Entry(int _entryNumber, string _header, string _body)
    {
        InitializeComponent();

        entryNumber = _entryNumber;
        header = _header;
        body = ParseText(_body);

        HeaderBox.SuspendLayout();
        BodyBox.SuspendLayout();

        EntryBox.Text = $"Entry {entryNumber}";
        HeaderBox.Text = header;
        BodyBox.Text = body;

        HeaderBox.SelectionStart = 0;
        BodyBox.SelectionStart = 0;

        HeaderBox.ResumeLayout();
        BodyBox.ResumeLayout();

        Select();
    }

    private void DeleteEntry(object sender, EventArgs e) => Dispose();

    private static string ParseText(string body)
    {
        if (body == null)
        {
            return null;
        }

        var text = body;

        for (var i = 0; i < KeysManager.literal.Count; i++)
        {
            text = text.Replace($@"{KeysManager.literal[i]}", $@"{KeysManager.worded[i]}");

            if (text.Contains(@"\n"))
            {
                text = text.Replace($@"\n", $"\n");
            }
        }

        return text;
    }
}
