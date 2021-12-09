using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultOne;
            Console.WriteLine("Введите первый х для ф от тангенса х:");
            double firstXEnter = double.Parse(Console.ReadLine());
            double a = -(Math.PI) / 2;
            double b = (Math.PI) / 2;
            if (firstXEnter < a)
            {
                if (firstXEnter > b)
                {
                    resultOne = FirstX(firstXEnter);
                    Console.WriteLine($"функция f от х = {resultOne:F3}");
                }
            }

            else
            {
                Console.WriteLine("ты  попутал значения");


            }

            Console.WriteLine("Введите второй х для ф от тангенса х:");
            double secondXEnter = double.Parse(Console.ReadLine());
            double c = (Math.PI) / 2;
            double resultTwo;
            if ( secondXEnter >= c )
            {
                resultTwo = DoubleX(secondXEnter);
                Console.WriteLine(resultTwo);



            }
            else
            {

                Console.WriteLine("снова попутал, ахахахахах");
            }

            Console.WriteLine("Введите третий х для ф от тангенса х:");
            double thirdXEnter = double.Parse(Console.ReadLine());
            double d = (Math.PI) / 2;
            double resultTree;
            if (thirdXEnter >= d)
            {
                resultTree = ThirdX(thirdXEnter);
                Console.WriteLine(resultTree);



            }
            else
            {

                Console.WriteLine("снова попутал, ну чел... у же не смешно");


                Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");
                Console.WriteLine("⠄⠄⠄⠄⣠⠞⠉⢉⠩⢍⡙⠛⠋⣉⠉⠍⢉⣉⣉⣉⠩⢉⠉⠛⠲⣄⠄⠄⠄⠄");
                Console.WriteLine("⠄⠄⠄⡴⠁⠄⠂⡠⠑⠄⠄⠄⠂⠄⠄⠄⠄⠠⠄⠄⠐⠁⢊⠄⠄⠈⢦⠄⠄⠄");
                Console.WriteLine("⠄⣠⡾⠁⠄⠄⠄⣴⡪⠽⣿⡓⢦⠄⠄⡀⠄⣠⢖⣻⣿⣒⣦⠄⡀⢀⣈⢦⡀⠄");
                Console.WriteLine("⣰⠑⢰⠋⢩⡙⠒⠦⠖⠋⠄⠈⠁⠄⠄⠄⠄⠈⠉⠄⠘⠦⠤⠴⠒⡟⠲⡌⠛⣆");
                Console.WriteLine("⢹⡰⡸⠈⢻⣈⠓⡦⢤⣀⡀⢾⠩⠤⠄⠄⠤⠌⡳⠐⣒⣠⣤⠖⢋⡟⠒⡏⡄⡟");
                Console.WriteLine("⠄⠙⢆⠄⠄⠻⡙⡿⢦⣄⣹⠙⠒⢲⠦⠴⡖⠒⠚⣏⣁⣤⣾⢚⡝⠁⠄⣨⠞⠄");
                Console.WriteLine("⠄⠄⠈⢧⠄⠄⠙⢧⡀⠈⡟⠛⠷⡾⣶⣾⣷⠾⠛⢻⠉⢀⡽⠋⠄⠄⣰⠃⠄⠄");
                Console.WriteLine("⠄⠄⠄⠄⠑⢤⡠⢂⠌⡛⠦⠤⣄⣇⣀⣀⣸⣀⡤⠼⠚⡉⢄⠠⣠⠞⠁⠄⠄⠄");
                Console.WriteLine("⠄⠄⠄⠄⠄⠄⠉⠓⠮⣔⡁⠦⠄⣤⠤⠤⣤⠄⠰⠌⣂⡬⠖⠋⠄⠄⠄⠄⠄⠄");
                Console.WriteLine("⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠉⠒⠤⢤⣀⣀⡤⠴⠒⠉⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄");



            }



            Console.ReadKey();
        }
        static double FirstX (double x)
        {
            return Math.Tan(x);         
        }
        static double DoubleX(double y)
        {
            return 1 / y;
        }
        static double ThirdX(double z)
        {

            return -(1 / z);
        }
    }
}
