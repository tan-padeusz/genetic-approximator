namespace GeneticApproximator;

public class Population
{
    private static Random Random { get; } = new Random();
    
    public double AverageError { get; }
    
    public Individual BestIndividual { get; }
    
    public long Id { get; }
    
    private Individual[] Individuals { get; }

    public Population(Point[] points)
    {
        this.Id = 1;
        this.Individuals = this.GeneratePopulation(points);
        this.BestIndividual = this.FindBestIndividual();
        this.AverageError = this.CalculateAverageError();
    }

    public Population(Point[] points, Population previousPopulation)
    {
        this.Id = previousPopulation.Id + 1;
        this.Individuals = this.GeneratePopulation(points, previousPopulation);
        this.BestIndividual = this.FindBestIndividual();
        this.AverageError = this.CalculateAverageError();
    }

    private double CalculateAverageError()
    {
        double error = 0;
        foreach (Individual individual in this.Individuals) error += individual.Error;
        return error / this.Individuals.Length;
    }

    private Individual[] GeneratePopulation(Point[] points)
    {
        int size = InterfaceInputs.PopulationSize;
        Individual[] individuals = new Individual[size];
        for (int index = 0; index < size; index++)
        {
            Individual individual;
            do individual = new Individual(points); while (Double.IsNaN(individual.Error));
            individuals[index] = individual;
        }
        return individuals;
    }

    private Individual[] GeneratePopulation(Point[] points, Population previousPopulation)
    {
        int size = InterfaceInputs.PopulationSize;
        Individual[] individuals = new Individual[size];
        for (int index = 0; index < size; index++)
        {
            Individual individual;
            do individual = this.Contest(points, previousPopulation); while (Double.IsNaN(individual.Error));
            individuals[index] = individual;
        }
        return individuals;
    }

    private Individual Contest(Point[] points, Population previousPopulation)
    {
        int availableIndividuals = previousPopulation.Individuals.Length;
        Individual?[] bestIndividuals = new Individual?[] { null, null };
        for (int contestantIndex = 0; contestantIndex < InterfaceInputs.Contestants * 2; contestantIndex++)
        {
            int randomIndex = Population.Random.Next(availableIndividuals);
            Individual individual = previousPopulation.Individuals[randomIndex];
            int groupIndex = contestantIndex % 2;
            if (bestIndividuals[groupIndex] == null || bestIndividuals[groupIndex]!.Error > individual.Error)
                bestIndividuals[groupIndex] = individual;
            previousPopulation.Individuals[randomIndex] = previousPopulation.Individuals[availableIndividuals - 1];
            availableIndividuals--;
        }
        Parents parents = new Parents(bestIndividuals[0]!, bestIndividuals[1]!);
        return new Individual(points, parents);
    }

    private Individual FindBestIndividual()
    {
        Individual bestIndividual = this.Individuals[0];
        for (int index = 1; index < InterfaceInputs.PopulationSize; index++)
        {
            Individual currentIndividual = this.Individuals[index];
            if (currentIndividual.Error < bestIndividual.Error) bestIndividual = currentIndividual;
        }
        return bestIndividual;
    }
}