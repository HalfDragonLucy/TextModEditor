namespace CommandListEditor;

partial class RemoveKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveKeyForm));
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LiteralBox = new System.Windows.Forms.ComboBox();
            this.WordedBox = new System.Windows.Forms.ComboBox();
            this.SelectionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirm.Location = new System.Drawing.Point(119, 138);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(186, 36);
            this.BtnConfirm.TabIndex = 11;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.ConfirmKey);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCancel.Location = new System.Drawing.Point(12, 138);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(101, 36);
            this.BtnCancel.TabIndex = 10;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Human-readable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raw";
            // 
            // LiteralBox
            // 
            this.LiteralBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.LiteralBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LiteralBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LiteralBox.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LiteralBox.ForeColor = System.Drawing.Color.White;
            this.LiteralBox.FormattingEnabled = true;
            this.LiteralBox.Location = new System.Drawing.Point(12, 31);
            this.LiteralBox.Name = "LiteralBox";
            this.LiteralBox.Size = new System.Drawing.Size(293, 30);
            this.LiteralBox.TabIndex = 12;
            this.LiteralBox.SelectedIndexChanged += new System.EventHandler(this.LiteralBox_SelectedIndexChanged);
            // 
            // WordedBox
            // 
            this.WordedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.WordedBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WordedBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WordedBox.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordedBox.ForeColor = System.Drawing.Color.White;
            this.WordedBox.FormattingEnabled = true;
            this.WordedBox.Location = new System.Drawing.Point(12, 87);
            this.WordedBox.Name = "WordedBox";
            this.WordedBox.Size = new System.Drawing.Size(293, 30);
            this.WordedBox.TabIndex = 13;
            // 
            // SelectionTimer
            // 
            this.SelectionTimer.Enabled = true;
            this.SelectionTimer.Tick += new System.EventHandler(this.CheckIfBoxSelected);
            // 
            // RemoveKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(317, 182);
            this.Controls.Add(this.WordedBox);
            this.Controls.Add(this.LiteralBox);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveKeyForm";
            this.Text = "Text Mod Editor: Remove Key";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Button BtnConfirm;
    private Button BtnCancel;
    private Label label2;
    private Label label1;
    private ComboBox LiteralBox;
    private ComboBox WordedBox;
    private System.Windows.Forms.Timer SelectionTimer;
}