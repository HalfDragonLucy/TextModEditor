namespace CommandListEditor;

partial class StriveIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StriveIDForm));
            this.IDBox = new System.Windows.Forms.ComboBox();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.IDBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IDBox.ForeColor = System.Drawing.Color.White;
            this.IDBox.FormattingEnabled = true;
            this.IDBox.Items.AddRange(new object[] {
            "SOL",
            "KYK",
            "MAY",
            "AXL",
            "CHP",
            "POT",
            "FAU",
            "MLL",
            "ZAT",
            "RAM",
            "LEO",
            "NAG",
            "GIO",
            "ANJ",
            "INO",
            "GLD",
            "JKO",
            "COS",
            "BKN",
            "TST",
            "SLY",
            "SIN",
            "BGT"});
            this.IDBox.Location = new System.Drawing.Point(13, 52);
            this.IDBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(335, 30);
            this.IDBox.TabIndex = 18;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.Location = new System.Drawing.Point(135, 104);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(212, 52);
            this.BtnConfirm.TabIndex = 17;
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
            this.BtnCancel.Location = new System.Drawing.Point(12, 104);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(116, 52);
            this.BtnCancel.TabIndex = 16;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Character ID";
            // 
            // SelectionTimer
            // 
            this.SelectionTimer.Enabled = true;
            this.SelectionTimer.Tick += new System.EventHandler(this.CheckIfBoxSelected);
            // 
            // StriveIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(364, 172);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StriveIDForm";
            this.Text = "Text Mod Editor: Change ID";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private ComboBox IDBox;
    private Button BtnConfirm;
    private Button BtnCancel;
    private Label label1;
    private System.Windows.Forms.Timer SelectionTimer;
}