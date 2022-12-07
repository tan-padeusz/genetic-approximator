using System.ComponentModel;
using System.Diagnostics;

namespace GeneticApproximator;

static class Program
{
    public static ProgramForm ProgramForm = new ProgramForm();
    public static BackgroundWorker BackgroundWorker { get; } = Program.CreateBackgroundWorker();
    public static Stopwatch Stopwatch { get; } = new Stopwatch();
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font, see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(Program.ProgramForm);
    }

    private static BackgroundWorker CreateBackgroundWorker()
    {
        BackgroundWorker worker = new BackgroundWorker();
        worker.WorkerReportsProgress = true;
        worker.WorkerSupportsCancellation = true;
        worker.DoWork += Engine.Run;
        worker.ProgressChanged += Engine.ProgressReported;
        worker.RunWorkerCompleted += Engine.OnTaskFinished;
        return worker;
    }
}