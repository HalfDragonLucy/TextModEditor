using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TextModEditor.Controls;
using TextModEditor.Forms;
using TextModEditor.Scripts;

namespace CommandListEditor;

public partial class MainForm : Form
{
    public string loadedFile = string.Empty;
    public bool canExport = false;
    public static Entry trash;

    public MainForm()
    {
        InitializeComponent();
        KeysManager.GetKeys();

        UI.Controls.Add(new AddEntry(this));
    }

    private void ImportFile(object sender, EventArgs e)
    {
        if (UI.Controls.Count > 1)
        {
            if (MessageBox.Show("Are you sure you want to import a new file and overwrite your current progress?", "Importing File", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ImportFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadedFile = ImportFileDialog.SafeFileName;
                    LoadFile(ImportFileDialog.FileName);
                }
            }
        }
        else
        {
            if (ImportFileDialog.ShowDialog() == DialogResult.OK)
            {
                loadedFile = ImportFileDialog.SafeFileName;
                LoadFile(ImportFileDialog.FileName);
            }
        }

    }

    private void ExportFile(object sender, EventArgs e)
    {
        if (ExportFileDialog.ShowDialog() == DialogResult.OK)
        {
            var json = new JObject();
            var entries = new JArray();

            foreach (var control in UI.Controls)
            {
                try
                {
                    var ec = (Entry)control;

                    var header = ec.HeaderBox.Text;
                    var body = ec.BodyBox.Text;

                    for (var i = 0; i < KeysManager.literal.Count; i++)
                    {
                        body = body.Replace($@"{KeysManager.worded[i]}", $"{KeysManager.literal[i]}");

                        if (body.Contains('\n'))
                        {
                            body = body.Replace($"\n", $"^n;");
                        }
                    }

                    var entry = new JObject
                    {
                        { "header", header },
                        { "text", body }
                    };
                    entries.Add(entry);
                }
                catch
                {

                }
            }

            json.Add("Entries", entries);
            File.WriteAllText(ExportFileDialog.FileName, json.ToString(), System.Text.Encoding.Unicode);
            ExportNotif.ShowBalloonTip(3000);
        }
    }

    public void ShowKeys(object sender, EventArgs e)
    {
        var k = new KeysForm();
        k.Show();
    }

    private void CheckToEnableMenuItems(object sender, EventArgs e)
    {
        BtnExport.Enabled = canExport;
        BtnExport.Enabled = UI.Controls.Count > 1;
        BtnID.Enabled = canExport;
        BtnID.Enabled = UI.Controls.Count > 1;
        BtnClear.Enabled = UI.Controls.Count > 1;
        IconExportBtn.Enabled = canExport;
        IconExportBtn.Enabled = UI.Controls.Count > 1;
        IconClearBtn.Enabled = UI.Controls.Count > 1;

        UndoBtn.Enabled = trash != null;
    }

    private void LoadFile(string fileName)
    {
        using var file = File.OpenText(fileName);
        using var reader = new JsonTextReader(file);

        var json = (JObject)JToken.ReadFrom(reader);
        var entries = json["Entries"];

        if (entries != null)
        {
            UI.SuspendLayout();
            UI.Controls.Clear();

            var controls = new List<Entry>();

            foreach (var entry in entries)
            {
                var header = entry["header"].ToString();
                var body = entry["text"].ToString();

                controls.Add(new Entry(controls.Count, header, body));
            }

            UI.Controls.AddRange(controls.ToArray());
            UI.Controls.Add(new AddEntry(this));
            UI.ResumeLayout();

            canExport = true;
        }
    }

    private void ScrollSmooth(object sender, ScrollEventArgs e)
    {
        if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
        {
            UI.VerticalScroll.Value = e.NewValue;
        }
    }

    private void ChangeCharacterHeaderStrive(object sender, EventArgs e)
    {
        var f = new StriveIDForm();
        if (f.ShowDialog() == DialogResult.OK)
        {
            var characterID = f.ID;

            foreach (var control in UI.Controls)
            {
                try
                {
                    var ec = (Entry)control;

                    var header = ec.HeaderBox.Text;
                    var oldID = header.Substring(3, 3);
                    Console.WriteLine(oldID);
                    header = header.Replace(oldID, characterID);

                    ec.HeaderBox.Text = header;
                }
                catch
                {

                }
            }
        }
    }

    private void Github(object sender, EventArgs e) => Process.Start(new ProcessStartInfo("https://github.com/HalfDragonLucy/TextModEditor/wiki") { UseShellExecute = true });

    private void DragEnterMainForm(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.Copy;
        }
    }

    private void DragDropMainForm(object sender, DragEventArgs e)
    {
        if (UI.Controls.Count > 1)
        {
            if (MessageBox.Show("Are you sure you want to import a new file and overwrite your current progress?", "Importing File", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var file = (string[])e.Data.GetData(DataFormats.FileDrop);
                LoadFile(file[0]);
            }
        }
    }

    private void ExitApp(object sender, EventArgs e) => Application.Exit();

    private void ClearFile(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to delete all your entries?", "Clearing Entries", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {

            UI.SuspendLayout();
            UI.Controls.Clear();
            UI.Controls.Add(new AddEntry(this));
            UI.ResumeLayout();

            canExport = false;
            loadedFile = string.Empty;
        }
    }

    private void MainForm_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {
            Hide();
            ExportNotif.Visible = true;
        }
    }

    private void ExportNotif_MouseClick(object sender, MouseEventArgs e)
    {
        Show();
        WindowState = FormWindowState.Normal;
        ExportNotif.Visible = false;
    }

    private void ShowDiscordForm(object sender, EventArgs e)
    {
        var d = new DiscordForm();
        d.ShowDialog();
    }

    private void Undo(object sender, EventArgs e)
    {
        UI.SuspendLayout();
        UI.Controls.Add(trash);
        UI.Controls.SetChildIndex(trash, UI.Controls.Count - 2);
        trash = null;
        UI.ResumeLayout();
    }

    private void ListenForKeys(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.Z && trash != null)
        {
            Undo(sender, new EventArgs());
        }
    }
}
