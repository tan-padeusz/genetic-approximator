namespace GeneticApproximator;

public partial class ProgramForm : Form
{
    public ProgramForm()
    {
        InitializeComponent();
    }

    private void StartButtonClick(object sender, EventArgs args)
    {
        
    }

    private void StopButtonClick(object sender, EventArgs args)
    {
        
    }

    private void ClearOutputs()
    {
        this.PopulationsCreatedOutputLabel.Text = "POPULATIONS CREATED";
        this.MinimalErrorOutputLabel.Text = "MINIMAL ERROR";
        this.BestFunctionOutputLabel.Text = "BEST FUNCTION";
    }
}