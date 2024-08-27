using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace h
{
    internal class Program
    {
        static string name;
        static double english, math, science, filipino, history;

        static double avg;
        static bool isNotValid = false;
        static void Main(string[] args)
        {
            while(!isNotValid)
            try
            {
                    bool isCorrect = false;
                    try {
                        Console.Write("Enter your name: ");
                        name = Console.ReadLine();
                        Console.WriteLine();

                        while (!isCorrect)
                        {
                                                  
                            Console.WriteLine("Enter your grades");
                            Console.WriteLine();

                            Console.WriteLine("           Grades");
                            Console.Write("English:     ");
                            english = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Math:        ");
                            math = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Science:     ");
                            science = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Filipino:    ");
                            filipino = Convert.ToDouble(Console.ReadLine());

                            Console.Write("History:     ");
                            history = Convert.ToDouble(Console.ReadLine());

                            if (english <= 100 && math <= 100 && science <= 100 && filipino <= 100 && history <= 100)
                            {
                                Average();
                                isNotValid = true;
                                break;
                            }
                            else {
                                Console.WriteLine("Grades are up to 100 only. Try again");
                                Console.WriteLine();
                                continue;
                            }
                        }
                    }
                     catch (FormatException) {
                            Console.WriteLine("Invalid input. Please try again");
                        continue;
                    }
                    
            }
            catch (Exception) {
                    Console.WriteLine("Something is wrong. Please try again");
                    continue;

            }
           
            
           
        }
        static void Average(){
            avg = (english + math + science + filipino + history) / 5;

            Console.WriteLine();
            if (avg <= 100 && avg >= 75)
            {
                Console.WriteLine("The student passed.");
            }
            else {
                Console.WriteLine("The student failed.");
            }
            Console.WriteLine($"The general average of {name} is {avg}");
        }
    }
}
