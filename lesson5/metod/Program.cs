using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace metod
{
    class Ex6_1
    {
        public void DoEx6_1(string path)
        {
            string allFile = File.ReadAllText(path);
            int[] letters = countOfConsonatsAndVowels(allFile);
            Console.WriteLine("Гласных: " + letters[0] + "\nСогласных: " + letters[1]);
        }
        private int[] countOfConsonatsAndVowels(string text)
        {

            int vowels = 0;
            int consonants = 0;
            int anotherSymbols = 0;
            string vowelsАlls = "уеыаоэяию";
            foreach (char letter in text)
            {
                if (!Char.IsLetter(letter))
                {
                    anotherSymbols++;
                    continue;
                }
                bool letterIsVowels = false;
                foreach (char vowel in vowelsАlls)
                {
                    if (letter == vowel)
                    {
                        letterIsVowels = true;
                        break;
                    }
                }
                if (letterIsVowels)
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
            int[] answer = { vowels, consonants, anotherSymbols };
            return answer;
        }
    }  
    class Ex6_3
    {   //класс для задания 6.3
        private Random rnd = new Random();
        const byte countsmonth = 12;
        const byte countsday = 30;
        private int[,] temperatures = new int[countsmonth, countsday];
        private void Sort(ref int[] mass)
        {
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        int change = mass[j];
                        mass[j] = mass[i];
                        mass[i] = change;
                    }
                }
            }
        }
        public void setTemperatures()
        {
            for (byte month = 0; month < countsmonth; month++)
            {
                for (byte day = 0; day < countsday; day++)
                {
                    temperatures[month, day] = rnd.Next(-50, 50);
                }
            }
        }
        public int[] averageTemperatureInAMonth()
        {
            int[] averageTemperaturesInAMonth = new int[countsmonth];
            for (int i = 0; i < countsmonth; i++)
            {
                int sumOfTemperatures = 0;
                for (int j = 0; j < countsday; j++)
                {
                    sumOfTemperatures += temperatures[i, j];
                }
                averageTemperaturesInAMonth[i] = sumOfTemperatures / countsday;
            }
            Sort(ref averageTemperaturesInAMonth);
            return averageTemperaturesInAMonth;
        }
    }

    class Program
    {   
        
        // метод для задания 2
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static void Print(int[,] endmatriza)
        {
            for (int i = 0; i < endmatriza.GetLength(0); i++)
            {
                for (int j = 0; j < endmatriza.GetLength(1); j++)
                {
                    Console.Write("{0} ", endmatriza[i, j]);
                }
                Console.WriteLine();
            }
        }
        
       

        static void Main(string[] args)
        {          
            Console.WriteLine("task1");
            //new Ex6_1().DoEx6_1(args[0]);
            Console.WriteLine("task2");
            Random random = new Random();
            int[,] matriza1 = new int[3, 2];
            int[,] matriza2 = new int[2, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriza1[i, j] = random.Next(10);
                }

            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriza2[i, j] = random.Next(10);
                }

            }
            int[,] newmatriza = Multiplication(matriza1, matriza2);
            Print(newmatriza);
            Console.WriteLine("task3");
            Ex6_3 ex6_3 = new Ex6_3();
            ex6_3.setTemperatures();
            int[] averageTemperatures = ex6_3.averageTemperatureInAMonth();
            for (int i = 0; i < averageTemperatures.Length; i++)
            {
                Console.WriteLine(averageTemperatures[i]);
            }
                       
        }
    
    }
}
