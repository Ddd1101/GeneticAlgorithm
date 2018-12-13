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
            for (int i = 0; i < 10000; i++)
            {
                //Console.WriteLine("1");
                ga.Fitness();
                //ga.test_input_1();
                //Console.WriteLine("2");
                ga.cal_fmax_favg();
                //Console.WriteLine("3");
                ga.Selection();
                //Console.WriteLine("4");
                ga.Pick_parents();
                //Console.WriteLine("5");
                for (int j = 0; j < 10; j++)
                {
                    ga.Offspring();
                }
                //Console.WriteLine("6");
                ga.Exchang();
            }
            //ga.test();
        }
    }
}
