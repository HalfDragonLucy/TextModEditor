namespace CommandListEditor;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnImport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnExport = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnClear = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.BtnID = new System.Windows.Forms.ToolStripMenuItem();
            this.guiltyGearStriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnKeys = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.discordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEnablerTimer = new System.Windows.Forms.Timer(this.components);
            this.ImportFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UI = new System.Windows.Forms.FlowLayoutPanel();
            this.ExportFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportNotif = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconLoadFileBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.IconExportBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.IconClearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.IconExitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.TopMenu.SuspendLayout();
            this.IconMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.AllowMerge = false;
            this.TopMenu.AutoSize = false;
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TopMenu.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TopMenu.GripMargin = new System.Windows.Forms.Padding(5);
            this.TopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.BtnEdit,
            this.UndoBtn,
            this.toolStripDropDownButton3});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.TopMenu.Size = new System.Drawing.Size(1254, 43);
            this.TopMenu.TabIndex = 0;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnImport,
            this.BtnExport,
            this.BtnClear});
            this.toolStripDropDownButton1.Image = global::TextModEditor.Properties.Resources.Document;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(60, 40);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // BtnImport
            // 
            this.BtnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnImport.ForeColor = System.Drawing.Color.White;
            this.BtnImport.Image = global::TextModEditor.Properties.Resources.OpenFile;
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(121, 26);
            this.BtnImport.Text = "Import";
            this.BtnImport.Click += new System.EventHandler(this.ImportFile);
            // 
            // BtnExport
            // 
            this.BtnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnExport.ForeColor = System.Drawing.Color.White;
            this.BtnExport.Image = global::TextModEditor.Properties.Resources.Save;
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(121, 26);
            this.BtnExport.Text = "Export";
            this.BtnExport.Click += new System.EventHandler(this.ExportFile);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Image = global::TextModEditor.Properties.Resources.Trash;
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(121, 26);
            this.BtnClear.Text = "Clear";
            this.BtnClear.Click += new System.EventHandler(this.ClearFile);
            // 
            // BtnEdit
            // 
            this.BtnEdit.AutoToolTip = false;
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnID,
            this.BtnKeys});
            this.BtnEdit.Image = global::TextModEditor.Properties.Resources.EditDocument;
            this.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(63, 40);
            this.BtnEdit.Text = "Edit";
            // 
            // BtnID
            // 
            this.BtnID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnID.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guiltyGearStriveToolStripMenuItem});
            this.BtnID.ForeColor = System.Drawing.Color.White;
            this.BtnID.Image = global::TextModEditor.Properties.Resources.PictureAndText;
            this.BtnID.Name = "BtnID";
            this.BtnID.Size = new System.Drawing.Size(108, 26);
            this.BtnID.Text = "ID";
            // 
            // guiltyGearStriveToolStripMenuItem
            // 
            this.guiltyGearStriveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.guiltyGearStriveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.guiltyGearStriveToolStripMenuItem.Name = "guiltyGearStriveToolStripMenuItem";
            this.guiltyGearStriveToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.guiltyGearStriveToolStripMenuItem.Text = "Guilty Gear -Strive-";
            this.guiltyGearStriveToolStripMenuItem.Click += new System.EventHandler(this.ChangeCharacterHeaderStrive);
            // 
            // BtnKeys
            // 
            this.BtnKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnKeys.ForeColor = System.Drawing.Color.White;
            this.BtnKeys.Image = global::TextModEditor.Properties.Resources.Keyboard;
            this.BtnKeys.Name = "BtnKeys";
            this.BtnKeys.Size = new System.Drawing.Size(108, 26);
            this.BtnKeys.Text = "Keys";
            this.BtnKeys.Click += new System.EventHandler(this.ShowKeys);
            // 
            // UndoBtn
            // 
            this.UndoBtn.Image = global::TextModEditor.Properties.Resources.Undo;
            this.UndoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoBtn.Name = "UndoBtn";
            this.UndoBtn.Size = new System.Drawing.Size(63, 40);
            this.UndoBtn.Text = "Undo";
            this.UndoBtn.Click += new System.EventHandler(this.Undo);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discordToolStripMenuItem,
            this.githubToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::TextModEditor.Properties.Resources.HelpTableOfContents;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(66, 40);
            this.toolStripDropDownButton3.Text = "Help";
            // 
            // discordToolStripMenuItem
            // 
            this.discordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.discordToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.discordToolStripMenuItem.Image = global::TextModEditor.Properties.Resources.Discord;
            this.discordToolStripMenuItem.Name = "discordToolStripMenuItem";
            this.discordToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.discordToolStripMenuItem.Text = "Discord";
            this.discordToolStripMenuItem.Click += new System.EventHandler(this.ShowDiscordForm);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.githubToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.githubToolStripMenuItem.Image = global::TextModEditor.Properties.Resources.Bookmark;
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.githubToolStripMenuItem.Text = "Documentation";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.Github);
            // 
            // MenuEnablerTimer
            // 
            this.MenuEnablerTimer.Enabled = true;
            this.MenuEnablerTimer.Tick += new System.EventHandler(this.CheckToEnableMenuItems);
            // 
            // ImportFileDialog
            // 
            this.ImportFileDialog.DefaultExt = "Json files (*.json)|*.json";
            this.ImportFileDialog.Filter = "Json files (*.json)|*.json";
            this.ImportFileDialog.RestoreDirectory = true;
            this.ImportFileDialog.Title = "Select a Command List";
            // 
            // UI
            // 
            this.UI.AutoScroll = true;
            this.UI.AutoSize = true;
            this.UI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI.Location = new System.Drawing.Point(0, 43);
            this.UI.Margin = new System.Windows.Forms.Padding(4);
            this.UI.Name = "UI";
            this.UI.Size = new System.Drawing.Size(1254, 667);
            this.UI.TabIndex = 1;
            this.UI.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollSmooth);
            this.UI.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropMainForm);
            this.UI.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterMainForm);
            // 
            // ExportFileDialog
            // 
            this.ExportFileDialog.DefaultExt = "Json files (*.json)|*.json";
            this.ExportFileDialog.FileName = "text.json";
            this.ExportFileDialog.Filter = "Json files (*.json)|*.json";
            this.ExportFileDialog.RestoreDirectory = true;
            this.ExportFileDialog.Title = "Select where to export your Command List";
            // 
            // ExportNotif
            // 
            this.ExportNotif.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ExportNotif.BalloonTipText = "Export is successful!";
            this.ExportNotif.BalloonTipTitle = "Text Mod Editor - Export";
            this.ExportNotif.ContextMenuStrip = this.IconMenu;
            this.ExportNotif.Icon = ((System.Drawing.Icon)(resources.GetObject("ExportNotif.Icon")));
            this.ExportNotif.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExportNotif_MouseClick);
            // 
            // IconMenu
            // 
            this.IconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconLoadFileBtn,
            this.IconExportBtn,
            this.IconClearBtn,
            this.toolStripSeparator1,
            this.IconExitBtn});
            this.IconMenu.Name = "contextMenuStrip1";
            this.IconMenu.Size = new System.Drawing.Size(132, 98);
            // 
            // IconLoadFileBtn
            // 
            this.IconLoadFileBtn.Name = "IconLoadFileBtn";
            this.IconLoadFileBtn.Size = new System.Drawing.Size(131, 22);
            this.IconLoadFileBtn.Text = "Import File";
            this.IconLoadFileBtn.Click += new System.EventHandler(this.ImportFile);
            // 
            // IconExportBtn
            // 
            this.IconExportBtn.Name = "IconExportBtn";
            this.IconExportBtn.Size = new System.Drawing.Size(131, 22);
            this.IconExportBtn.Text = "Export File";
            this.IconExportBtn.Click += new System.EventHandler(this.ExportFile);
            // 
            // IconClearBtn
            // 
            this.IconClearBtn.Name = "IconClearBtn";
            this.IconClearBtn.Size = new System.Drawing.Size(131, 22);
            this.IconClearBtn.Text = "Clear File";
            this.IconClearBtn.Click += new System.EventHandler(this.ClearFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // IconExitBtn
            // 
            this.IconExitBtn.Name = "IconExitBtn";
            this.IconExitBtn.Size = new System.Drawing.Size(131, 22);
            this.IconExitBtn.Text = "Exit";
            this.IconExitBtn.ToolTipText = "Exit";
            this.IconExitBtn.Click += new System.EventHandler(this.ExitApp);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1254, 710);
            this.Controls.Add(this.UI);
            this.Controls.Add(this.TopMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Text Mod Editor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropMainForm);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterMainForm);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListenForKeys);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.IconMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ToolStrip TopMenu;
    private ToolStripDropDownButton toolStripDropDownButton1;
    private ToolStripMenuItem BtnImport;
    private ToolStripMenuItem BtnExport;
    private ToolStripDropDownButton BtnEdit;
    private System.Windows.Forms.Timer MenuEnablerTimer;
    private OpenFileDialog ImportFileDialog;
    private ToolStripMenuItem BtnKeys;
    private SaveFileDialog ExportFileDialog;
    private ToolStripMenuItem BtnID;
    private ToolStripDropDownButton toolStripDropDownButton3;
    private ToolStripMenuItem discordToolStripMenuItem;
    private ToolStripMenuItem githubToolStripMenuItem;
    private ToolStripMenuItem guiltyGearStriveToolStripMenuItem;
    public FlowLayoutPanel UI;
    private NotifyIcon ExportNotif;
    private ContextMenuStrip IconMenu;
    private ToolStripMenuItem IconExitBtn;
    private ToolStripMenuItem IconLoadFileBtn;
    private ToolStripMenuItem IconExportBtn;
    private ToolStripMenuItem IconClearBtn;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem BtnClear;
    private ToolStripButton UndoBtn;
}
