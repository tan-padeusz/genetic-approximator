using System.Runtime.CompilerServices;

namespace GeneticApproximator;

partial class ProgramForm
{
    public Label ParametersLabel { get; } = new Label();
    public Label MaxPolynomialDegreeLabel { get; } = new Label();
    public NumericUpDown MaxPolynomialDegreeNUD { get; } = new NumericUpDown();
    
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
        /// ParametersLabel
        this.ParametersLabel.AutoSize = true;
        this.ParametersLabel.Location = new System.Drawing.Point(25, 25);
        this.ParametersLabel.Size = new Size(150, 25);
        this.ParametersLabel.Text = "Parametry:";
        
        /// MaxPolynomialDegreeLabel
        this.MaxPolynomialDegreeLabel.AutoSize = true;
        this.MaxPolynomialDegreeLabel.Location = new System.Drawing.Point(25, 50);
        this.MaxPolynomialDegreeLabel.Size = new Size(150, 25);
        this.MaxPolynomialDegreeLabel.Text = "Maksymalny stopień wielomianu:";
        
        /// MaxPolynomialDegreeNUD
        this.MaxPolynomialDegreeNUD.Increment = 1;
        this.MaxPolynomialDegreeNUD.Location = new System.Drawing.Point(25, 75);
        this.MaxPolynomialDegreeNUD.Maximum = 4;
        this.MaxPolynomialDegreeNUD.Minimum = 1;
        this.MaxPolynomialDegreeNUD.Size = new Size(150, 25);
        this.MaxPolynomialDegreeNUD.TextAlign = HorizontalAlignment.Center;
        

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
    }

    #endregion
}