using System.ComponentModel;

namespace GeneticApproximator;

public static class Engine
{
    private static Individual GlobalBestIndividual { get; set; }
    private static long LastImprovementId { get; set; }
    private static Population CurrentPopulation { get; set; }

    public static void Run(object sender, DoWorkEventArgs args)
    {
        
    }

    public static void OnTaskFinished()
    {
        
    }
}