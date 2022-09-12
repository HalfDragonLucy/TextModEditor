namespace TextModEditor.Controls;

partial class AddEntry
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.BtnAddEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddEntry
            // 
            this.BtnAddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnAddEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddEntry.Font = new System.Drawing.Font("Dosis", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAddEntry.ForeColor = System.Drawing.Color.White;
            this.BtnAddEntry.Image = global::TextModEditor.Properties.Resources.Plus;
            this.BtnAddEntry.Location = new System.Drawing.Point(0, 0);
            this.BtnAddEntry.Name = "BtnAddEntry";
            this.BtnAddEntry.Size = new System.Drawing.Size(355, 212);
            this.BtnAddEntry.TabIndex = 3;
            this.BtnAddEntry.Text = "Add Entry";
            this.BtnAddEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnAddEntry.UseVisualStyleBackColor = false;
            this.BtnAddEntry.Click += new System.EventHandler(this.AddEntry_);
            // 
            // AddEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.BtnAddEntry);
            this.Name = "AddEntry";
            this.Size = new System.Drawing.Size(355, 212);
            this.ResumeLayout(false);

    }

    #endregion

    private Button BtnAddEntry;
}
