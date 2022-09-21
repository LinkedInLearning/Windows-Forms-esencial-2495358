namespace BaseDeDatos;

partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visorToolStripMenuItem
            // 
            this.visorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarBaseDeDatosToolStripMenuItem,
            this.abrirArchivoJSONToolStripMenuItem});
            this.visorToolStripMenuItem.Name = "visorToolStripMenuItem";
            this.visorToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.visorToolStripMenuItem.Text = "Visor";
            // 
            // abrirArchivoJSONToolStripMenuItem
            // 
            this.abrirArchivoJSONToolStripMenuItem.Name = "abrirArchivoJSONToolStripMenuItem";
            this.abrirArchivoJSONToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.abrirArchivoJSONToolStripMenuItem.Text = "Abrir archivo JSON...";
            this.abrirArchivoJSONToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoJSONToolStripMenuItem_Click);
            // 
            // consultarBaseDeDatosToolStripMenuItem
            // 
            this.consultarBaseDeDatosToolStripMenuItem.Name = "consultarBaseDeDatosToolStripMenuItem";
            this.consultarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.consultarBaseDeDatosToolStripMenuItem.Text = "Consultar base de datos";
            this.consultarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.consultarBaseDeDatosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem visorToolStripMenuItem;
    private ToolStripMenuItem abrirArchivoJSONToolStripMenuItem;
    private ToolStripMenuItem consultarBaseDeDatosToolStripMenuItem;
}