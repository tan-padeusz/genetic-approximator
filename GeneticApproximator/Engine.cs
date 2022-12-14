using System.ComponentModel;
using System.Text;

namespace GeneticApproximator;

public static class Engine
{
    private static Individual? GlobalBestIndividual { get; set; } = null;
    private static long LastImprovementId { get; set; }
    private static Population CurrentPopulation { get; set; }
    
    private static long LastTickCount { get; set; }

    public static void Run(object? sender, DoWorkEventArgs args)
    {
        Engine.LastTickCount = Environment.TickCount;
        Program.Stopwatch.Restart();
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
            Thread.Sleep(100);
        }
    }

    public static void ProgressReported(object? sender, ProgressChangedEventArgs args)
    {
        Program.ProgramForm.ElapsedTimeOutputLabel.Text = Engine.FormatTime(Program.Stopwatch.ElapsedMilliseconds);
        Program.ProgramForm.PopulationsCreatedOutputLabel.Text = $"{Engine.CurrentPopulation.Id}";
        Program.ProgramForm.MinimalErrorOutputLabel.Text = $"{Engine.GlobalBestIndividual.Error}";
        Program.ProgramForm.BestFunctionOutputLabel.Text = Engine.GlobalBestIndividual.ToString();
    }

    public static void OnTaskFinished(object? sender, RunWorkerCompletedEventArgs args)
    {
        Program.Stopwatch.Stop();
        StringBuilder builder = new StringBuilder();
        builder.Append("[X ; Y ; Z] : [RESULT ; ERROR] : [TEST]\n");
        foreach (InputPoint point in InterfaceInputs.InputPoints)
        {
            double functionResult = Math.Round(Engine.GlobalBestIndividual.CalculateFunctionResult(point), 3);
            double errorValue = Math.Round(Math.Abs(functionResult - point.Z), 3);
            builder.Append($"{point.ToString()} : [{functionResult} ; {errorValue}] : [{Math.Round(Engine.TestFunction(point), 3)}]\n");
        }
        builder.Remove(builder.Length - 1, 1);
        Program.ProgramForm.ControlResultsRTB.Text = builder.ToString();
    }

    private static string FormatTime(long milliseconds)
    {
        long seconds = milliseconds / 1000;
        long minutes = seconds / 60;
        seconds -= minutes * 60;

        string minutesString = $"{minutes}";
        string secondsString = $"{seconds}";

        if (minutes < 10) minutesString = "0" + minutesString;
        if (seconds < 10) secondsString = "0" + secondsString;

        return minutesString + ":" + secondsString;
    }

    private static double TestFunction(InputPoint point)
    {
        return 4.8458 + 2.2165 * point.X - 4.1071 * point.Y;
    }
}