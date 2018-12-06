using System;

namespace GA
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GeneticAlgorithm ga = new GeneticAlgorithm();
            ga.Init_position();
            ga.test_input();
            ga.Initialize_population();
            //ga.test_input_1();
            ga.test();
        }
    }
}
