namespace CommandListEditor;

partial class Entry
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
            this.components = new System.ComponentModel.Container();
            this.EntryBox = new System.Windows.Forms.GroupBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BodyBox = new System.Windows.Forms.RichTextBox();
            this.ContextReadable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HeaderBox = new System.Windows.Forms.TextBox();
            this.EntryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntryBox
            // 
            this.EntryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.EntryBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EntryBox.Controls.Add(this.BtnDelete);
            this.EntryBox.Controls.Add(this.BodyBox);
            this.EntryBox.Controls.Add(this.HeaderBox);
            this.EntryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryBox.ForeColor = System.Drawing.Color.White;
            this.EntryBox.Location = new System.Drawing.Point(0, 0);
            this.EntryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntryBox.Name = "EntryBox";
            this.EntryBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EntryBox.Size = new System.Drawing.Size(355, 212);
            this.EntryBox.TabIndex = 0;
            this.EntryBox.TabStop = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnDelete.CausesValidation = false;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(318, 14);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(30, 29);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.TabStop = false;
            this.BtnDelete.Text = "X";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.DeleteEntry);
            // 
            // BodyBox
            // 
            this.BodyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BodyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BodyBox.CausesValidation = false;
            this.BodyBox.ContextMenuStrip = this.ContextReadable;
            this.BodyBox.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BodyBox.ForeColor = System.Drawing.Color.White;
            this.BodyBox.Location = new System.Drawing.Point(6, 50);
            this.BodyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.BodyBox.Size = new System.Drawing.Size(343, 156);
            this.BodyBox.TabIndex = 1;
            this.BodyBox.TabStop = false;
            this.BodyBox.Text = "";
            this.BodyBox.Enter += new System.EventHandler(this.ClearBodyPlaceHolder);
            this.BodyBox.Leave += new System.EventHandler(this.AddBodyPlaceHolder);
            // 
            // ContextReadable
            // 
            this.ContextReadable.Name = "ContextReadable";
            this.ContextReadable.Size = new System.Drawing.Size(61, 4);
            // 
            // HeaderBox
            // 
            this.HeaderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.HeaderBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeaderBox.CausesValidation = false;
            this.HeaderBox.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderBox.ForeColor = System.Drawing.Color.White;
            this.HeaderBox.Location = new System.Drawing.Point(6, 15);
            this.HeaderBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.HeaderBox.MaxLength = 50;
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(159, 21);
            this.HeaderBox.TabIndex = 0;
            this.HeaderBox.TabStop = false;
            this.HeaderBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeaderBox.Enter += new System.EventHandler(this.ClearHeaderPlaceHolder);
            this.HeaderBox.Leave += new System.EventHandler(this.AddHeaderPlaceHolder);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.EntryBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Entry";
            this.Size = new System.Drawing.Size(355, 212);
            this.EntryBox.ResumeLayout(false);
            this.EntryBox.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private GroupBox EntryBox;
    private Button BtnDelete;
    public RichTextBox BodyBox;
    public TextBox HeaderBox;
    private ContextMenuStrip ContextReadable;
}
