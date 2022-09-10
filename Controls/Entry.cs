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

        for (var i = 0; i < KeysManager.worded.Count; i++)
        {
            var button = new ToolStripButton(KeysManager.worded[i]);
            button.Click += new EventHandler((sender, e) => AppendContextText(button.Text));
            ContextReadable.Items.Add(button);
        }

        HeaderBox.ResumeLayout();
        BodyBox.ResumeLayout();

        Select();
    }

    private void AppendContextText(string txt) => BodyBox.SelectedText = txt;

    private void DeleteEntry(object sender, EventArgs e)
    {
        if (MessageBox.Show("Do you really want to remove this entry?", "Deleting Entry", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            header = HeaderBox.Text;
            body = BodyBox.Text;
            MainForm.bin = new Entry(entryNumber, header, body);
            Dispose();
        }
    }

    private void ClearHeaderPlaceHolder(object sender, EventArgs e)
    {
        if (HeaderBox.Text == "Header")
        {
            HeaderBox.Text = string.Empty;
        }
    }

    private void ClearBodyPlaceHolder(object sender, EventArgs e)
    {
        if (BodyBox.Text == "Body")
        {
            BodyBox.Text = string.Empty;
        }
    }

    private void AddHeaderPlaceHolder(object sender, EventArgs e)
    {
        if (HeaderBox.Text == string.Empty)
        {
            HeaderBox.Text = "Header";
        }
    }

    private void AddBodyPlaceHolder(object sender, EventArgs e)
    {
        if (BodyBox.Text == string.Empty)
        {
            BodyBox.Text = "Body";
        }
    }

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
