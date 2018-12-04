using System;

namespace GA
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GeneticAlgorithm ga = new GeneticAlgorithm();
            ga.Init_position();
            ga.Initialize_population();
        }
    }
}
