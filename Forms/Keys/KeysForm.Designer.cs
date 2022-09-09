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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeysForm));
            this.LiteralList = new System.Windows.Forms.ListBox();
            this.WordedList = new System.Windows.Forms.ListBox();
            this.BtnAddKey = new System.Windows.Forms.Button();
            this.BtnRemoveKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LiteralList
            // 
            this.LiteralList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.LiteralList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LiteralList.Font = new System.Drawing.Font("Dosis", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LiteralList.ForeColor = System.Drawing.Color.White;
            this.LiteralList.FormattingEnabled = true;
            this.LiteralList.ItemHeight = 21;
            this.LiteralList.Location = new System.Drawing.Point(0, 47);
            this.LiteralList.Margin = new System.Windows.Forms.Padding(4);
            this.LiteralList.Name = "LiteralList";
            this.LiteralList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LiteralList.Size = new System.Drawing.Size(165, 590);
            this.LiteralList.TabIndex = 1;
            // 
            // WordedList
            // 
            this.WordedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.WordedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WordedList.Font = new System.Drawing.Font("Dosis", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordedList.ForeColor = System.Drawing.Color.White;
            this.WordedList.FormattingEnabled = true;
            this.WordedList.ItemHeight = 21;
            this.WordedList.Location = new System.Drawing.Point(301, 47);
            this.WordedList.Margin = new System.Windows.Forms.Padding(4);
            this.WordedList.Name = "WordedList";
            this.WordedList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.WordedList.Size = new System.Drawing.Size(175, 590);
            this.WordedList.TabIndex = 2;
            // 
            // BtnAddKey
            // 
            this.BtnAddKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnAddKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAddKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddKey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddKey.Location = new System.Drawing.Point(172, 517);
            this.BtnAddKey.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAddKey.Name = "BtnAddKey";
            this.BtnAddKey.Size = new System.Drawing.Size(124, 52);
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
            this.BtnRemoveKey.Location = new System.Drawing.Point(172, 577);
            this.BtnRemoveKey.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRemoveKey.Name = "BtnRemoveKey";
            this.BtnRemoveKey.Size = new System.Drawing.Size(124, 52);
            this.BtnRemoveKey.TabIndex = 4;
            this.BtnRemoveKey.Text = "Remove Key";
            this.BtnRemoveKey.UseVisualStyleBackColor = false;
            this.BtnRemoveKey.Click += new System.EventHandler(this.RemoveKey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Literal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(355, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Worded";
            // 
            // KeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(477, 645);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRemoveKey);
            this.Controls.Add(this.BtnAddKey);
            this.Controls.Add(this.WordedList);
            this.Controls.Add(this.LiteralList);
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

    private ListBox LiteralList;
    private ListBox WordedList;
    private Button BtnAddKey;
    private Button BtnRemoveKey;
    private Label label1;
    private Label label2;
}