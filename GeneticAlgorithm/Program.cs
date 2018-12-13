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
            for (int i = 0; i < 2000; i++)
            {
                //Console.WriteLine("1");
                ga.Fitness();
                //ga.Print();
                //ga.Print();
                //Console.WriteLine("2");
                ga.cal_fmax_favg();
                //ga.Print();
                //Console.WriteLine("3");
                ga.Selection();
                //ga.Print();
                //Console.WriteLine("4");
                ga.Pick_parents();
                //ga.Print();
                //Console.WriteLine("5");
                for (int j = 0; j < 50; j++)
                {
                    ga.Offspring();
                }
                //ga.Print();
                //Console.WriteLine("6");
                ga.Exchange();
                //ga.Initialize_population();
                //ga.Fitness();
            }
            ga.Fitness();
            ga.cal_fmax_favg();
            ga.Print_best();
            //ga.test();
        }
    }
}
