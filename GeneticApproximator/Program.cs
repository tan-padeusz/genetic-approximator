using System.ComponentModel;
using System.Diagnostics;

namespace GeneticApproximator;

static class Program
{
    public static ProgramForm ProgramForm = new ProgramForm();
    public static BackgroundWorker BackgroundWorker { get; } = new BackgroundWorker();
    public static Stopwatch Stopwatch { get; } = new Stopwatch();
    
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(Program.ProgramForm);
    }
}