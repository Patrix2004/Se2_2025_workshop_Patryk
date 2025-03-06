using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class Calc
    {
        public int calc(string s)
        {
            if(s == "")
            {
                return 0;
            }
            if (s.Length == 1)
                return int.Parse(s);


            if (s.Contains(","))
            {

                var parts = s.Split(',');

                if (parts.Length == 2)
                {
                    int firstNumber;
                    int secondNumber;

                    if (int.Parse(parts[0].Trim()) > 1000)
                    {
                        firstNumber = 0;
                    }
                    else
                    {
                        firstNumber = int.Parse(parts[0].Trim());
                    }
                    if (int.Parse(parts[1].Trim()) > 1000)
                    {
                        secondNumber = 0;
                    }
                    else
                    {
                        secondNumber = int.Parse(parts[1].Trim());
                    }


                    return firstNumber + secondNumber;
                }
                if(parts.Length == 3)
                {
                    int firstNumber = int.Parse(parts[0].Trim());
                    int secondNumber = int.Parse(parts[1].Trim());
                    int thirdNumber = int.Parse(parts[2].Trim());
                    return firstNumber + secondNumber + thirdNumber;
                }
            }

            if (s.Contains("\n"))
            {

                var parts = s.Split('\n');


                if (parts.Length == 2)
                {
                    int firstNumber = int.Parse(parts[0].Trim());
                    int secondNumber = int.Parse(parts[1].Trim());

                    return firstNumber + secondNumber;
                }
                if (parts.Length == 3)
                {
                    int firstNumber = int.Parse(parts[0].Trim());
                    int secondNumber = int.Parse(parts[1].Trim());
                    int thirdNumber = int.Parse(parts[2].Trim());
                    return firstNumber + secondNumber + thirdNumber;
                }
            }
            if (s.Contains("-"))
            {
                throw new ArgumentException("cant be negative.");
            }



                return 1;
        }
    }
}
