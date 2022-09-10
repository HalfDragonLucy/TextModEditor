namespace CommandListEditor;

partial class KeysForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeysForm));
            this.RawList = new System.Windows.Forms.ListBox();
            this.BtnAddKey = new System.Windows.Forms.Button();
            this.BtnRemoveKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SyncTimer = new System.Windows.Forms.Timer(this.components);
            this.WordedList = new TextModEditor.Controls.NoScrollBarListBox();
            this.SuspendLayout();
            // 
            // RawList
            // 
            this.RawList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.RawList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RawList.ColumnWidth = 1;
            this.RawList.Font = new System.Drawing.Font("Dosis", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RawList.ForeColor = System.Drawing.Color.White;
            this.RawList.FormattingEnabled = true;
            this.RawList.ItemHeight = 21;
            this.RawList.Location = new System.Drawing.Point(18, 33);
            this.RawList.Margin = new System.Windows.Forms.Padding(4);
            this.RawList.Name = "RawList";
            this.RawList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.RawList.Size = new System.Drawing.Size(165, 590);
            this.RawList.TabIndex = 1;
            // 
            // BtnAddKey
            // 
            this.BtnAddKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnAddKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddKey.Location = new System.Drawing.Point(18, 631);
            this.BtnAddKey.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddKey.Name = "BtnAddKey";
            this.BtnAddKey.Size = new System.Drawing.Size(348, 52);
            this.BtnAddKey.TabIndex = 3;
            this.BtnAddKey.Text = "Add Key";
            this.BtnAddKey.UseVisualStyleBackColor = false;
            this.BtnAddKey.Click += new System.EventHandler(this.AddKey);
            // 
            // BtnRemoveKey
            // 
            this.BtnRemoveKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnRemoveKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRemoveKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRemoveKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnRemoveKey.Location = new System.Drawing.Point(18, 691);
            this.BtnRemoveKey.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveKey.Name = "BtnRemoveKey";
            this.BtnRemoveKey.Size = new System.Drawing.Size(348, 52);
            this.BtnRemoveKey.TabIndex = 4;
            this.BtnRemoveKey.Text = "Remove Key";
            this.BtnRemoveKey.UseVisualStyleBackColor = false;
            this.BtnRemoveKey.Click += new System.EventHandler(this.RemoveKey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Human-readable";
            // 
            // SyncTimer
            // 
            this.SyncTimer.Enabled = true;
            this.SyncTimer.Tick += new System.EventHandler(this.SyncTimer_Tick);
            // 
            // WordedList
            // 
            this.WordedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.WordedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordedList.ForeColor = System.Drawing.Color.White;
            this.WordedList.FormattingEnabled = true;
            this.WordedList.ItemHeight = 22;
            this.WordedList.Location = new System.Drawing.Point(190, 33);
            this.WordedList.Name = "WordedList";
            this.WordedList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.WordedList.ShowScrollbar = false;
            this.WordedList.Size = new System.Drawing.Size(176, 596);
            this.WordedList.TabIndex = 7;
            // 
            // KeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(382, 755);
            this.Controls.Add(this.WordedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemoveKey);
            this.Controls.Add(this.BtnAddKey);
            this.Controls.Add(this.RawList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KeysForm";
            this.Text = "Text Mod Editor: Keys";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private ListBox RawList;
    private Button BtnAddKey;
    private Button BtnRemoveKey;
    private Label label1;
    private Label label2;
    private System.Windows.Forms.Timer SyncTimer;
    private TextModEditor.Controls.NoScrollBarListBox WordedList;
}