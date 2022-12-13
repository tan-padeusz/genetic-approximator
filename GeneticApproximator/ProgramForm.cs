namespace GeneticApproximator;

public partial class ProgramForm : Form
{
    public ProgramForm()
    {
        InitializeComponent();
    }

    private void StartButtonClick(object sender, EventArgs args)
    {
        InterfaceInputs.AxisBorderValue = (double)this.AxisBorderValueNUD.Value;
        InterfaceInputs.BitsPerFactor = (int)this.BitsPerFactorNUD.Value;
        InterfaceInputs.Contestants = (int)this.ContestantsNUD.Value;
        InterfaceInputs.MaxPolynomialDegree = (int)this.MaxPolynomialDegreeNUD.Value;
        InterfaceInputs.MutationProbability = (double)this.MutationProbabilityNUD.Value;
        InterfaceInputs.PopulationSize = (int)this.PopulationSizeNUD.Value;

        // int pointCount = (int)this.InputPointsNUD.Value;
        // double pointRange = (double)this.CoordinatesRangeNUD.Value;
        // Point[] points = new Point[pointCount];
        // for (int index = 0; index < pointCount; index++) points[index] = new Point(pointRange);
        // InterfaceInputs.InputPoints = points;
        InterfaceInputs.InputPoints = InputPoint.GetTestPoints();
        
        Program.BackgroundWorker.RunWorkerAsync();
    }

    private void StopButtonClick(object sender, EventArgs args)
    {
        Program.BackgroundWorker.CancelAsync();
    }

    private void ClearOutputs()
    {
        this.ElapsedTimeOutputLabel.Text = "";
        this.PopulationsCreatedOutputLabel.Text = "";
        this.MinimalErrorOutputLabel.Text = "";
        this.BestFunctionOutputLabel.Text = "";
        this.ControlResultsRTB.Clear();
    }
}