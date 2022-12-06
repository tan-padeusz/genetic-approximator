using System.ComponentModel;

namespace GeneticApproximator;

public static class Engine
{
    private static Individual GlobalBestIndividual { get; set; }
    private static long LastImprovementId { get; set; }
    private static Population CurrentPopulation { get; set; }
    
    private static long LastTickCount { get; set; }

    public static void Run(object sender, DoWorkEventArgs args)
    {
        Engine.LastTickCount = Environment.TickCount;
        Engine.CurrentPopulation = new Population(InterfaceInputs.InputPoints);
        Engine.GlobalBestIndividual = Engine.CurrentPopulation.BestIndividual;
        Engine.LastImprovementId = Engine.CurrentPopulation.Id;
        Engine.ReportProgress();

        while (!Program.BackgroundWorker.CancellationPending)
        {
            Engine.CurrentPopulation = new Population(InterfaceInputs.InputPoints, Engine.CurrentPopulation);
            if (Engine.CurrentPopulation.BestIndividual.Error < Engine.GlobalBestIndividual.Error)
            {
                Engine.GlobalBestIndividual = Engine.CurrentPopulation.BestIndividual;
                Engine.LastImprovementId = Engine.CurrentPopulation.Id;
            }
            Engine.ReportProgress();
        }
    }

    private static void ReportProgress()
    {
        if (Environment.TickCount - Engine.LastTickCount > 1)
        {
            Program.BackgroundWorker.ReportProgress(0, "UpdateUI");
            Engine.LastTickCount = Environment.TickCount;
        }
    }

    public static void ProgressReported()
    {
        
    }

    public static void OnTaskFinished()
    {
        
    }
}