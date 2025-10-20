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

            while (true)
            {
                Console.Write("Add meg a keresztneved (Nagy kezdőbetű): ");
                kernev = Console.ReadLine();
                if (!string.IsNullOrEmpty(kernev) && char.IsUpper(kernev[0]))
                    break;

                Console.WriteLine("Hiba! A névnek nagybetűvel kell kezdődnie.");
            }

            
            while (true)
            {
                Console.Write("Add meg a testsúlyod (50-120 kg): ");
                if (int.TryParse(Console.ReadLine(), out testsuly) && testsuly >= 50 && testsuly <= 120)
                    break;

                Console.WriteLine("Hibás érték! Csak 50 és 120 kg közötti szám lehet.");
            }


        }
    }
}
