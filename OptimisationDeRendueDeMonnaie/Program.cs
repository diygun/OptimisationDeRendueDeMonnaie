using System;

namespace OptimisationDeRendueDeMonnaie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OptimisationDuRenduDeMonnaie rdm = new OptimisationDuRenduDeMonnaie();
            Console.WriteLine("-------------------------");
            long i = 0;
            while (true)
            {
                Console.WriteLine("Veuillez entrez une somme ou 0 pour quitter:");
                i = Convert.ToInt64(Console.ReadLine());
                if (i == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(rdm.BankNotes(i));

                }
            }
        }
    }
}
