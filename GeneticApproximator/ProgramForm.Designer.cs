using System.Runtime.CompilerServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace GeneticApproximator;

partial class ProgramForm
{
    public Label AxisBorderValueLabel { get; } = new Label();
    public NumericUpDown AxisBorderValueNUD { get; } = new NumericUpDown();
    public Label BestFunctionLabel { get; } = new Label();
    public Label BestFunctionOutputLabel { get; } = new Label();
    public Label BitsPerFactorLabel { get; } = new Label();
    public NumericUpDown BitsPerFactorNUD { get; } = new NumericUpDown();
    public Chart Chart { get; } = new Chart();
    public Label ContestantsLabel { get; } = new Label();
    public NumericUpDown ContestantsNUD { get; } = new NumericUpDown();
    public RichTextBox ControlResultsRTB { get; } = new RichTextBox();
    public Label CoordinatesRangeLabel { get; } = new Label();
    public NumericUpDown CoordinatesRangeNUD { get; } = new NumericUpDown();
    public Label ElapsedTimeLabel { get; } = new Label();
    public Label ElapsedTimeOutputLabel { get; } = new Label();
    public Label HorizontalSeparator { get; } = new Label();
    public Label InputPointsLabel { get; } = new Label();
    public NumericUpDown InputPointsNUD { get; } = new NumericUpDown();
    public Label LeftVerticalSeparator { get; } = new Label();
    public Label MaxPolynomialDegreeLabel { get; } = new Label();
    public NumericUpDown MaxPolynomialDegreeNUD { get; } = new NumericUpDown();
    public Label MinimalErrorLabel { get; } = new Label();
    public Label MinimalErrorOutputLabel { get; } = new Label();
    public Label MutationProbabilityLabel { get; } = new Label();
    public NumericUpDown MutationProbabilityNUD { get; } = new NumericUpDown();
    public Label PopulationsCreatedLabel { get; } = new Label();
    public Label PopulationsCreatedOutputLabel { get; } = new Label();
    public Label PopulationSizeLabel { get; } = new Label();
    public NumericUpDown PopulationSizeNUD { get; } = new NumericUpDown();
    public Label RightVerticalSeparator { get; } = new Label();
    public Button StartButton { get; } = new Button();
    public Button StopButton { get; } = new Button();
    

    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer Components { get; } = new System.ComponentModel.Container();

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && this.Components != null) this.Components.Dispose();
        base.Dispose(disposing);
    }

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        /// AxisBorderValueLabel
        this.AxisBorderValueLabel.Location = new System.Drawing.Point(10, 310);
        this.AxisBorderValueLabel.Size = new System.Drawing.Size(200, 20);
        this.AxisBorderValueLabel.Text = "AXIS BORDER VALUE";
        this.AxisBorderValueLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// AxisBorderValueNUD
        this.AxisBorderValueNUD.DecimalPlaces = 3;
        this.AxisBorderValueNUD.Increment = 1;
        this.AxisBorderValueNUD.Location = new System.Drawing.Point(10, 330);
        this.AxisBorderValueNUD.Maximum = 100;
        this.AxisBorderValueNUD.Minimum = 1;
        this.AxisBorderValueNUD.Size = new System.Drawing.Size(200, 20);
        this.AxisBorderValueNUD.TextAlign = HorizontalAlignment.Center;
        this.AxisBorderValueNUD.Value = 10;
        
        /// BestFunctionLabel
        this.BestFunctionLabel.Location = new System.Drawing.Point(230, 60);
        this.BestFunctionLabel.Size = new System.Drawing.Size(610, 20);
        this.BestFunctionLabel.Text = "BEST FUNCTION";
        this.BestFunctionLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// BestFunctionOutputLabel
        this.BestFunctionOutputLabel.Location = new System.Drawing.Point(230, 80);
        this.BestFunctionOutputLabel.Size = new System.Drawing.Size(610, 20);
        this.BestFunctionOutputLabel.Text = "BEST FUNCTION";
        this.BestFunctionOutputLabel.TextAlign = ContentAlignment.MiddleLeft;
        
        /// BitsPerFactorLabel
        this.BitsPerFactorLabel.Location = new System.Drawing.Point(10, 260);
        this.BitsPerFactorLabel.Size = new System.Drawing.Size(200, 20);
        this.BitsPerFactorLabel.Text = "BITS PER FACTOR";
        this.BitsPerFactorLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// BitsPerFactorNUD
        this.BitsPerFactorNUD.Increment = 1;
        this.BitsPerFactorNUD.Location = new System.Drawing.Point(10, 280);
        this.BitsPerFactorNUD.Maximum = 32;
        this.BitsPerFactorNUD.Minimum = 2;
        this.BitsPerFactorNUD.Size = new System.Drawing.Size(200, 20);
        this.BitsPerFactorNUD.TextAlign = HorizontalAlignment.Center;
        this.BitsPerFactorNUD.Value = 8;
        
        /// Chart
        this.Chart.ChartAreas.Add(this.CreateChartArea());
        this.Chart.Location = new System.Drawing.Point(870, 10);
        this.Chart.Size = new System.Drawing.Size(440, 440);
        
        /// ContestantsLabel
        this.ContestantsLabel.Location = new System.Drawing.Point(10, 210);
        this.ContestantsLabel.Size = new System.Drawing.Size(200, 20);
        this.ContestantsLabel.Text = "CONTESTANTS";
        this.ContestantsLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// ContestantsNUD
        this.ContestantsNUD.Increment = 5;
        this.ContestantsNUD.Location = new System.Drawing.Point(10, 230);
        this.ContestantsNUD.Maximum = 50;
        this.ContestantsNUD.Minimum = 10;
        this.ContestantsNUD.Size = new System.Drawing.Size(200, 20);
        this.ContestantsNUD.TextAlign = HorizontalAlignment.Center;
        this.ContestantsNUD.Value = 20;
        
        /// ControlResultsRTB
        this.ControlResultsRTB.Location = new System.Drawing.Point(230, 170);
        this.ControlResultsRTB.Size = new System.Drawing.Size(620, 280);
        
        /// CoordinatesRangeLabel
        this.CoordinatesRangeLabel.Location = new System.Drawing.Point(10, 60);
        this.CoordinatesRangeLabel.Size = new System.Drawing.Size(200, 20);
        this.CoordinatesRangeLabel.Text = "COORDINATES RANGE";
        this.CoordinatesRangeLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// CoordinatesRangeNUD
        this.CoordinatesRangeNUD.DecimalPlaces = 3;
        this.CoordinatesRangeNUD.Increment = 10;
        this.CoordinatesRangeNUD.Location = new System.Drawing.Point(10, 80);
        this.CoordinatesRangeNUD.Maximum = 1000;
        this.CoordinatesRangeNUD.Minimum = 1;
        this.CoordinatesRangeNUD.Size = new System.Drawing.Size(200, 20);
        this.CoordinatesRangeNUD.TextAlign = HorizontalAlignment.Center;
        this.CoordinatesRangeNUD.Value = 100;
        
        /// ElapsedTimeLabel
        this.ElapsedTimeLabel.Location = new System.Drawing.Point(230, 10);
        this.ElapsedTimeLabel.Size = new System.Drawing.Size(200, 20);
        this.ElapsedTimeLabel.Text = "TIME";
        this.ElapsedTimeLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// ElapsedTimeOutputLabel
        this.ElapsedTimeOutputLabel.Location = new System.Drawing.Point(230, 30);
        this.ElapsedTimeOutputLabel.Size = new System.Drawing.Size(200, 20);
        this.ElapsedTimeOutputLabel.Text = "TIME";
        this.ElapsedTimeOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// HorizontalSeparator
        this.HorizontalSeparator.BackColor = Color.DarkGray;
        this.HorizontalSeparator.Location = new System.Drawing.Point(230, 159);
        this.HorizontalSeparator.Size = new System.Drawing.Size(610, 3);
        
        /// InputPointsLabel
        this.InputPointsLabel.Location = new System.Drawing.Point(10, 10);
        this.InputPointsLabel.Size = new System.Drawing.Size(200, 20);
        this.InputPointsLabel.Text = "INPUT POINTS";
        this.InputPointsLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// InputPointsNUD
        this.InputPointsNUD.Increment = 2;
        this.InputPointsNUD.Location = new System.Drawing.Point(10, 30);
        this.InputPointsNUD.Maximum = 100;
        this.InputPointsNUD.Minimum = 10;
        this.InputPointsNUD.Size = new System.Drawing.Size(200, 20);
        this.InputPointsNUD.TextAlign = HorizontalAlignment.Center;
        this.InputPointsNUD.Value = 20;
        
        /// LeftVerticalSeparator
        this.LeftVerticalSeparator.BackColor = Color.DarkGray;
        this.LeftVerticalSeparator.Location = new System.Drawing.Point(219, 10);
        this.LeftVerticalSeparator.Size = new System.Drawing.Size(3, 440);

        /// MaxPolynomialDegreeLabel
        this.MaxPolynomialDegreeLabel.Location = new System.Drawing.Point(10, 110);
        this.MaxPolynomialDegreeLabel.Size = new System.Drawing.Size(200, 20);
        this.MaxPolynomialDegreeLabel.Text = "MAX POLYNOMIAL DEGREE";
        this.MaxPolynomialDegreeLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// MaxPolynomialDegreeNUD
        this.MaxPolynomialDegreeNUD.Increment = 1;
        this.MaxPolynomialDegreeNUD.Location = new System.Drawing.Point(10, 130);
        this.MaxPolynomialDegreeNUD.Maximum = 4;
        this.MaxPolynomialDegreeNUD.Minimum = 1;
        this.MaxPolynomialDegreeNUD.Size = new System.Drawing.Size(200, 20);
        this.MaxPolynomialDegreeNUD.TextAlign = HorizontalAlignment.Center;
        this.MaxPolynomialDegreeNUD.Value = 2;
        
        /// MinimalErrorLabel
        this.MinimalErrorLabel.Location = new System.Drawing.Point(650, 10);
        this.MinimalErrorLabel.Size = new System.Drawing.Size(200, 20);
        this.MinimalErrorLabel.Text = "MINIMAL ERROR";
        this.MinimalErrorLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// MinimalErrorOutputLabel
        this.MinimalErrorOutputLabel.Location = new System.Drawing.Point(650, 30);
        this.MinimalErrorOutputLabel.Size = new System.Drawing.Size(200, 20);
        this.MinimalErrorOutputLabel.Text = "MINIMAL ERROR";
        this.MinimalErrorOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// MutationProbabilityLabel
        this.MutationProbabilityLabel.Location = new System.Drawing.Point(10, 360);
        this.MutationProbabilityLabel.Size = new System.Drawing.Size(200, 20);
        this.MutationProbabilityLabel.Text = "MUTATION PROBABILITY";
        this.MutationProbabilityLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// MutationProbabilityNUD
        this.MutationProbabilityNUD.DecimalPlaces = 3;
        this.MutationProbabilityNUD.Increment = (decimal)0.005;
        this.MutationProbabilityNUD.Location = new System.Drawing.Point(10, 380);
        this.MutationProbabilityNUD.Maximum = 1;
        this.MutationProbabilityNUD.Minimum = 0;
        this.MutationProbabilityNUD.Size = new System.Drawing.Size(200, 20);
        this.MutationProbabilityNUD.TextAlign = HorizontalAlignment.Center;
        this.MutationProbabilityNUD.Value = (decimal)0.05;
        
        /// PopulationsCreatedLabel
        this.PopulationsCreatedLabel.Location = new System.Drawing.Point(440, 10);
        this.PopulationsCreatedLabel.Size = new System.Drawing.Size(200, 20);
        this.PopulationsCreatedLabel.Text = "POPULATIONS CREATED";
        this.PopulationsCreatedLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// PopulationsCreatedOutputLabel
        this.PopulationsCreatedOutputLabel.Location = new System.Drawing.Point(440, 30);
        this.PopulationsCreatedOutputLabel.Size = new System.Drawing.Size(200, 20);
        this.PopulationsCreatedOutputLabel.Text = "POPULATIONS CREATED";
        this.PopulationsCreatedOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// PopulationSizeLabel
        this.PopulationSizeLabel.Location = new System.Drawing.Point(10, 160);
        this.PopulationSizeLabel.Size = new System.Drawing.Size(200, 20);
        this.PopulationSizeLabel.Text = "POPULATION SIZE";
        this.PopulationSizeLabel.TextAlign = ContentAlignment.MiddleCenter;
        
        /// PopulationSizeNUD
        this.PopulationSizeNUD.Increment = 100;
        this.PopulationSizeNUD.Location = new System.Drawing.Point(10, 180);
        this.PopulationSizeNUD.Maximum = 10000;
        this.PopulationSizeNUD.Minimum = 100;
        this.PopulationSizeNUD.Size = new System.Drawing.Size(200, 20);
        this.PopulationSizeNUD.TextAlign = HorizontalAlignment.Center;
        this.PopulationSizeNUD.Value = 1000;
        
        /// RightVerticalSeparator
        this.RightVerticalSeparator.BackColor = Color.DarkGray;
        this.RightVerticalSeparator.Location = new System.Drawing.Point(859, 10);
        this.RightVerticalSeparator.Size = new System.Drawing.Size(3, 440);
        
        /// StartButton
        this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
        this.StartButton.Location = new System.Drawing.Point(10, 410);
        this.StartButton.Size = new System.Drawing.Size(200, 40);
        this.StartButton.Text = "START";
        this.StartButton.TextAlign = ContentAlignment.MiddleCenter;
        
        /// StopButton
        this.StopButton.Click += new System.EventHandler(this.StopButtonClick);
        this.StopButton.Location = new System.Drawing.Point(440, 110);
        this.StopButton.Size = new System.Drawing.Size(200, 40);
        this.StopButton.Text = "STOP";
        this.StopButton.TextAlign = ContentAlignment.MiddleCenter;
        
        
        
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1320, 460);
        this.Controls.AddRange(new Control[]
        {
            this.AxisBorderValueLabel,
            this.AxisBorderValueNUD,
            this.BestFunctionLabel,
            this.BestFunctionOutputLabel,
            this.BitsPerFactorLabel,
            this.BitsPerFactorNUD,
            this.Chart,
            this.ContestantsLabel,
            this.ContestantsNUD,
            this.ControlResultsRTB,
            this.CoordinatesRangeLabel,
            this.CoordinatesRangeNUD,
            this.ElapsedTimeLabel,
            this.ElapsedTimeOutputLabel,
            this.HorizontalSeparator,
            this.InputPointsLabel,
            this.InputPointsNUD,
            this.LeftVerticalSeparator,
            this.MaxPolynomialDegreeLabel,
            this.MaxPolynomialDegreeNUD,
            this.MinimalErrorLabel,
            this.MinimalErrorOutputLabel,
            this.MutationProbabilityLabel,
            this.MutationProbabilityNUD,
            this.PopulationsCreatedLabel,
            this.PopulationsCreatedOutputLabel,
            this.PopulationSizeLabel,
            this.PopulationSizeNUD,
            this.RightVerticalSeparator,
            this.StartButton,
            this.StopButton,
        });
        this.Text = "GENETIC APPROXIMATOR";
    }

    private ChartArea CreateChartArea()
    {
        ChartArea area = new ChartArea();
        
        area.AxisX.Title = "X";
        area.AxisX.Minimum = 0;
        area.AxisX.Maximum = 100;
        area.AxisX.Interval = 10;

        area.AxisY.Title = "Y";
        area.AxisY.Minimum = 0;
        area.AxisY.Maximum = 100;
        area.AxisY.Interval = 10;

        area.Area3DStyle.Enable3D = true;

        return area;
    }
}