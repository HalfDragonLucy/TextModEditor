namespace CommandListEditor;

partial class AddKeyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddKeyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.LiteralBox = new System.Windows.Forms.TextBox();
            this.WordedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.TextTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Literal";
            // 
            // LiteralBox
            // 
            this.LiteralBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.LiteralBox.ForeColor = System.Drawing.Color.White;
            this.LiteralBox.Location = new System.Drawing.Point(11, 35);
            this.LiteralBox.Name = "LiteralBox";
            this.LiteralBox.Size = new System.Drawing.Size(243, 28);
            this.LiteralBox.TabIndex = 1;
            // 
            // WordedBox
            // 
            this.WordedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.WordedBox.ForeColor = System.Drawing.Color.White;
            this.WordedBox.Location = new System.Drawing.Point(11, 96);
            this.WordedBox.Name = "WordedBox";
            this.WordedBox.Size = new System.Drawing.Size(243, 28);
            this.WordedBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Worded";
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(11, 150);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 38);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BtnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Enabled = false;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(106, 150);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(148, 38);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.ConfirmKey);
            // 
            // TextTimer
            // 
            this.TextTimer.Enabled = true;
            this.TextTimer.Tick += new System.EventHandler(this.CheckIfTextFiled);
            // 
            // AddKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(264, 199);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.WordedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LiteralBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Dosis", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddKeyForm";
            this.Text = "Text Mod Editor: Add Key";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox LiteralBox;
    private TextBox WordedBox;
    private Label label2;
    private Button BtnCancel;
    private Button BtnConfirm;
    private System.Windows.Forms.Timer TextTimer;
}