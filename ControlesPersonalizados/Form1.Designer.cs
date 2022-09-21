namespace ControlesPersonalizados;

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
            this.numerosaPalabras1 = new ControlesPersonalizados.NumerosAPalabras();
            this.numerosaPalabras2 = new ControlesPersonalizados.NumerosAPalabras();
            this.numerosaPalabras3 = new ControlesPersonalizados.NumerosAPalabras();
            this.SuspendLayout();
            // 
            // numerosaPalabras1
            // 
            this.numerosaPalabras1.Location = new System.Drawing.Point(29, 40);
            this.numerosaPalabras1.Name = "numerosaPalabras1";
            this.numerosaPalabras1.Size = new System.Drawing.Size(388, 29);
            this.numerosaPalabras1.TabIndex = 0;
            // 
            // numerosaPalabras2
            // 
            this.numerosaPalabras2.Location = new System.Drawing.Point(29, 95);
            this.numerosaPalabras2.Name = "numerosaPalabras2";
            this.numerosaPalabras2.Size = new System.Drawing.Size(388, 29);
            this.numerosaPalabras2.TabIndex = 1;
            // 
            // numerosaPalabras3
            // 
            this.numerosaPalabras3.Location = new System.Drawing.Point(29, 145);
            this.numerosaPalabras3.Name = "numerosaPalabras3";
            this.numerosaPalabras3.Size = new System.Drawing.Size(388, 29);
            this.numerosaPalabras3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 354);
            this.Controls.Add(this.numerosaPalabras3);
            this.Controls.Add(this.numerosaPalabras2);
            this.Controls.Add(this.numerosaPalabras1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

    }

    #endregion

    private NumerosAPalabras numerosaPalabras1;
    private NumerosAPalabras numerosaPalabras2;
    private NumerosAPalabras numerosaPalabras3;
}
