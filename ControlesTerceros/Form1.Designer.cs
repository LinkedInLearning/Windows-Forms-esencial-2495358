namespace ControlesTerceros;

partial class Form1
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
            Syncfusion.Windows.Forms.MetroColorTable metroColorTable1 = new Syncfusion.Windows.Forms.MetroColorTable();
            this.coloruiControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.SuspendLayout();
            // 
            // coloruiControl1
            // 
            this.coloruiControl1.BeforeTouchSize = new System.Drawing.Size(164, 331);
            this.coloruiControl1.Location = new System.Drawing.Point(12, 12);
            this.coloruiControl1.Name = "coloruiControl1";
            this.coloruiControl1.ScrollMetroColorTable = metroColorTable1;
            this.coloruiControl1.Size = new System.Drawing.Size(164, 331);
            this.coloruiControl1.TabIndex = 0;
            this.coloruiControl1.Text = "coloruiControl1";
            this.coloruiControl1.ColorSelected += new System.EventHandler(this.coloruiControl1_ColorSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 355);
            this.Controls.Add(this.coloruiControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private Syncfusion.Windows.Forms.ColorUIControl coloruiControl1;
}
