using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hw
{
    class Ex6_3
    {
        private Random rnd = new Random();
        const int COUNT_OF_MONTHS = 12;
        const int COUNT_OF_DAYS_IN_MONTHS = 30;
        private Dictionary<string, double[]> temperatures = new Dictionary<string, double[]>();
        private string[] allMonths = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июдь", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        private void BubbleSort(ref List<double> mass)
        {
            for (int i = 0; i < mass.Count; i++)
            {
                for (int j = 0; j < mass.Count; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        double rotate = mass[j];
                        mass[j] = mass[i];
                        mass[i] = rotate;
                    }
                }
            }
        }
        public void setTemperatures()
        {
            for (int i = 0; i < COUNT_OF_MONTHS; i++)
            {
                temperatures.Add(allMonths[i], new double[COUNT_OF_DAYS_IN_MONTHS]);
                for (int j = 0; j < (int)COUNT_OF_DAYS_IN_MONTHS; j++)
                {
                    temperatures[allMonths[i]][j] = rnd.Next(-50, 50);
                }

            }
        }
        public List<double> averageTemperatureInAMonth()
        {
            List<double> averageTemperaturesInAMonth = new List<double>();
            for (int i = 0; i < COUNT_OF_MONTHS; i++)
            {
                double sumOfTemperatures = 0;
                for (int j = 0; j < COUNT_OF_DAYS_IN_MONTHS; j++)
                {
                    sumOfTemperatures += temperatures[allMonths[i]][j];
                }
                averageTemperaturesInAMonth.Add(sumOfTemperatures / COUNT_OF_DAYS_IN_MONTHS);
            }
            BubbleSort(ref averageTemperaturesInAMonth);
            return averageTemperaturesInAMonth;
        }
    }
    class Program
    { //метод задание2
        public static string FirstUpper(string str, out string a)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();//Извлекает из подстроки - строку
                else s[i] = s[i].ToUpper();
            }
            a = string.Join(" ", s);
            return a;
        }
        /* public static void Exchange(char[]a, string sas, string sos)
           {
             foreach (var singleChar in a)
             {
                 sas = sos.Replace('*', singleChar);
                 break;
             }
             Console.WriteLine(sas);
           }*/
        static void Main(string[] args)
        {
            Console.WriteLine("пароль");
            string[] password = { "keys1" };
            string workwithFile = "D:\\lesson5\\password1.txt";
            byte[] Bytes1 = System.Text.Encoding.Unicode.GetBytes(password[0]);
            Console.Write("Верным ключом является: ");
            foreach (byte item in Bytes1)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n");
            string key = Convert.ToString(Bytes1[0]);
            string[] readAllFile = File.ReadAllLines(workwithFile);
            for (int i = 0; i < readAllFile.Length; i++)
            {
                bool b = readAllFile[i].Contains(key);
                if (b)
                {
                    Console.WriteLine("true " + readAllFile[i]);
                }
                else
                {
                    Console.WriteLine("false " + readAllFile[i]);
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Адская кухня");
            Console.WriteLine("Введите 4 слова для Гордона Рамзи");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string word4 = Console.ReadLine();
            string sentence = word1 + " " + word2 + " " + word3 + " " + word4;
            string asa = " ";
            FirstUpper(sentence, out asa);
            string newsentence = asa;
            string s13 = newsentence.Replace('а', '@');
            string s14 = s13.Replace('А', '@');
            //char[] charArray = { 'у', 'е', 'о', 'э', 'я','и', 'ю', 'ы'};
            string s15 = s14.Replace('*', 'у');
            /* string s16 = s15.Replace('*', 'е');
             string s17 = s16.Replace('*', 'о');
             string s18 = s17.Replace('*', 'э');
             string s19 = s18.Replace('*', 'я');
             string s20 = s19.Replace('*', 'и');
             string s21 = s20.Replace('*', 'ю');
             string s22 = s21.Replace('*', 'ы');*/
            //Console.WriteLine(s15);
            Console.WriteLine("task3");
            Ex6_3 ex6_3 = new Ex6_3();
            ex6_3.setTemperatures();
            List<double> averageTemperatures = ex6_3.averageTemperatureInAMonth();
            foreach (double answer in averageTemperatures)
            {
                Console.WriteLine(answer);
            }


        }
    }

}
