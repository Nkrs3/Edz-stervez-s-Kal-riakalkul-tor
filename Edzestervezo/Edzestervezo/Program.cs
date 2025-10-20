using System;

namespace FitProgram
{
    internal class WorkoutPlanner
    {
        static void Main(string[] args)
        {
            string veznev;
            string kernev;
            int testsuly = 0;
            int fitcel = 0;
            double alapido = 0;
            double kalszorzo = 0;
            string[] cellista = { "Állóképesség javítása", "Izomtömeg növelése", "Testsúlycsökkentés" };


            while (true)
            {
                Console.Write("Add meg a vezetékneved (Nagy kezdőbetű): ");
                veznev = Console.ReadLine();
                if (!string.IsNullOrEmpty(veznev) && char.IsUpper(veznev[0]))
                    break;

                Console.WriteLine("Hiba! A névnek nagybetűvel kell kezdődnie.");
            }



        }
    }
}
