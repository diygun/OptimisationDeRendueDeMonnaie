using System;
using System.Collections.Generic;
using System.Text;

namespace OptimisationDeRendueDeMonnaie
{
    public class OptimisationDuRenduDeMonnaie
    {
        public OptimisationDuRenduDeMonnaie()
        {
        }
        public string BankNotes(long a)
        {
            long TenNotes = 0;
            long FiveNotes = 0;
            long TwoNotes = 0;
            string Result = "";
            long Rest = a;
            while (Rest > 0)
            {
                if ((Rest - 10 > 3 || Rest - 10 == 0) && Rest.Equals(11) == false)
                {
                    TenNotes = (Rest - (Rest % 10)) / 10;
                    Rest = Rest % 10;
                    if (Rest <= 3 && !Rest.Equals(0))
                    {
                        Rest += 10;
                        TenNotes--;
                    }
                }
                else if (Rest - 5 > 4 || Rest - 5 == 0)
                {
                    FiveNotes++;
                    Rest -= 5;
                }
                else if (Rest - 2 >= 0)
                {
                    TwoNotes++;
                    Rest -= 2;
                }
                else
                {
                    Console.WriteLine("Impossible");
                    break;
                }
            }
            if (TwoNotes > 0)
            {
                Result = Result + TwoNotes + " * 2";
            }

            if (FiveNotes > 0)
            {
                if (TwoNotes != 0)
                {
                    Result = Result + " + ";
                }
                Result = Result + FiveNotes + " * 5";
            }

            if (TenNotes > 0)
            {
                if (TwoNotes != 0 || FiveNotes != 0)
                {
                    Result = Result + " + ";
                }
                Result = Result + TenNotes + " * 10";
            }
            return Result;
        }

    }
}
