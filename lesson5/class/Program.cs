using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;


namespace @class
{      
    class Program
    {    //задание4
        public struct T
        {

            public string Name { get; set; }
            public string Post { get; set; }
            public int DegreeofImpudence { get; set; }
            public int DegreeofStupidity { get; set; }

            public override string ToString()
            {
                return "Name: " + Name + " " + "Post: " + Post + " " + " DegreeofImpudence: " + DegreeofImpudence + " " + "DegreeofStupidity : " + DegreeofStupidity;
            }
        }
        public struct K
        {   //задание4
            public string Name { get; set; }
            public Table table;
            public Table GetTable()
            {
                return table;
            }

            public void SetTable(Table value)
            {
                table = value;
            }
        }
        public class Table
        {
            public string Name { get; set; }
            public string Colour { get; set; }
        }
        static int Transformation(int[] array, ref int input)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int n = 0;
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    array[i] = n;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный формат элемента массива");
                }
            }
            for (int h = 0; h < array.Length; h++)
            {
                if ((array[h] > -1) && (array[h] < 10))
                {
                    if (array[h] == 5)
                    {
                        input++;
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели число(а) не из верного диапазона");
                }
            }
            return input;
        }
        static void Swap(List<string> pictures, int i, int exchange, string value1, string value2)
        {
            pictures[i] = value2;
            pictures[exchange] = value1;
        }

        static void Main(string[] args)
        {
             Console.WriteLine("task1");
             int[] Bavarian = new int[5];
             int[] Scandinavian = new int[5];            
             Console.WriteLine("Введите 5 элементов массива для команды от 0 до 9 'Bavarian' ");
             Console.WriteLine("Введите 5 элементов массива для команды от 0 до 9 'Scandinavian' ");
             int numberof5SBavarian = 0;
             int numberof5Scandinavian = 0;
             Transformation(Bavarian,ref numberof5SBavarian);
             Transformation( Scandinavian,ref numberof5Scandinavian);
            if (numberof5SBavarian == numberof5Scandinavian)
            {
                Console.WriteLine("Drinks All Round!Free Beers on Bjorg!");
            }
            else 
            {
                Console.WriteLine("Ой Бьорг - пончик!Ни для кого пива!");
            }   
            Console.WriteLine("Упражнение 2");
            List<string> pictures = new List<string>()
{
            @"pictures\pic0.jpg",
            @"pictures\копия.pic0",
            @"pictures\pic1",
            @"pictures\копия.pic1",
            @"pictures\pic2",
            @"pictures\копия.pic2",
            @"pictures\pic3",
            @"pictures\копия.pic3",
            @"pictures\pic4",
            @"pictures\копия.pic4",
            @"pictures\pic5",
            @"pictures\копия.pic5",
            @"pictures\pic6",
            @"pictures\копия.pic6",
            @"pictures\pic7",
            @"pictures\копия.pic7",
            @"pictures\pic8",
            @"pictures\копия.pic8",
            @"pictures\pic9",
            @"pictures\копия.pic9",
            @"pictures\pic10",
            @"pictures\копия.pic10",
            @"pictures\pic11",
            @"pictures\копия.pic11",
            @"pictures\pic12",
            @"pictures\копия.pic12",
            @"pictures\pic13",
            @"pictures\копия.pic13",
            @"pictures\pic14",
            @"pictures\копия.pic14",
            @"pictures\pic15",
            @"pictures\копия.pic15",
            @"pictures\pic16",
            @"pictures\копия.pic16",
            @"pictures\pic17",
            @"pictures\копия.pic17",
            @"pictures\pic18",
            @"pictures\копия.pic18",
            @"pictures\pic19",
            @"pictures\копия.pic19",
            @"pictures\pic20",
            @"pictures\копия.pic20",
            @"pictures\pic21",
            @"pictures\копия.pic21",
            @"pictures\pic22",
            @"pictures\копия.pic22",
            @"pictures\pic23",
            @"pictures\копия.pic23",
            @"pictures\pic24",
            @"pictures\копия.pic24",
            @"pictures\pic25",
            @"pictures\копия.pic25",
            @"pictures\pic26",
            @"pictures\копия.pic26",
            @"pictures\pic27",
            @"pictures\копия.pic27",
            @"pictures\pic28",
            @"pictures\копия.pic28",
            @"pictures\pic29",
            @"pictures\копия.pic29",
            @"pictures\pic30",
            @"pictures\копия.pic30",
            @"pictures\pic31",
            @"pictures\копия.pic31" ,
                                        };
            Console.WriteLine("Неперемешанный");
            foreach (string item in pictures)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < pictures.Count(); i++)
            {
                Random random = new Random();
                int exchange = random.Next(pictures.Count());
                Swap(pictures, i, exchange, pictures[i], pictures[exchange]);
            }
            Console.WriteLine("Перемешанный");
            foreach (string item in pictures)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("task3");
            string workwithFile = "D:\\lesson5\\student.txt";
            string readAllFile = File.ReadAllText(workwithFile);
            Console.WriteLine(readAllFile);
            Console.WriteLine("Новый студент|Удалить|Сортировать");
            string input =Console.ReadLine().ToLower();
            string add ="";
            switch (input)
            {
                case "удалить":
                    Console.WriteLine("введите фамилию и имя студента,которого нужно удалить из списка");
                    string deletename = Console.ReadLine().ToLower();
                    string[] readEveryLine = new string[10];
                    readEveryLine = File.ReadAllLines(workwithFile);
                    for (int i = 0; i < readEveryLine.Length; i++)
                    { bool deleted = readEveryLine[i].Contains(deletename);
                        if (deleted)
                        {
                            readEveryLine[i] = "";
                        }                        
                    }
                    for (int g = 0; g < readEveryLine.Length; g++)
                    {
                        Console.WriteLine(readEveryLine[g]);
                    }
                    break;
                   case "сортировать":
                    Dictionary<int, string> studentspoint = new Dictionary<int, string>();
                    studentspoint.Add(252, "чернятов адель");
                    studentspoint.Add(263, "игуменов илья");
                    studentspoint.Add(241, "кучаев ринат");
                    studentspoint.Add(274, "хасанов булат");
                    studentspoint.Add(250, "тимофеева анастасия");
                    studentspoint.Add(246, "тальдаева лия");
                    studentspoint.Add(242, "шигина арина");
                    // Dictionary<string, int> myDict = new Dictionary<string, int>();                                 
                     break;
                 case "новый студент":
                     Console.WriteLine("Введите нового струдента");
                     add = Console.ReadLine().ToLower();
                     File.AppendAllText(workwithFile, Environment.NewLine); // Добавим новую строку в файл
                     File.AppendAllText(workwithFile, add);
                     string newFile = File.ReadAllText(workwithFile);
                     Console.WriteLine(newFile );                    
                     break;
                 default:
                     Console.WriteLine("вы неправильно ввели оператор");
                     break;

            }
            Console.WriteLine("task4");
            Stack<Table> tables = new Stack<Table>();
            tables.Push(new Table() { Name = "2", Colour = "Blue" });
            tables.Push(new Table() { Name = "4", Colour = "Orange" });
            tables.Push(new Table() { Name = "2", Colour = "Blue" });
            tables.Push(new Table() { Name = "3", Colour = "Green" });
            tables.Push(new Table() { Name = "3", Colour = "Green" });
            tables.Push(new Table() { Name = "3", Colour = "Green" });
            tables.Push(new Table() { Name = "1", Colour = "Red" });
            tables.Push(new Table() { Name = "1", Colour = "Red" });
            tables.Push(new Table() { Name = "1", Colour = "Red" });
            tables.Push(new Table() { Name = "2", Colour = "Blue" });
            tables.Push(new Table() { Name = "1", Colour = "Red" });
       
            Console.WriteLine("Вы наблюдаете за первоначальной очередью");
            List<T> Employers = new List<T>();
            Employers.Add(new T() { Name ="Mark",Post ="Clerk", DegreeofImpudence=1, DegreeofStupidity=0});
            Employers.Add(new T() { Name = "Renat", Post = "Clerk", DegreeofImpudence=0 , DegreeofStupidity=0});
            Employers.Add(new T() { Name = "Ramil", Post ="Office worker", DegreeofImpudence=2, DegreeofStupidity=1});
            Employers.Add(new T() { Name = "Marya", Post = "Office worker", DegreeofImpudence=2, DegreeofStupidity=1});
            Employers.Add(new T() { Name = "Nastya", Post = "Office worker", DegreeofImpudence=1, DegreeofStupidity=0});
            Employers.Add(new T() { Name = "Adel", Post = "Office worker", DegreeofImpudence=0, DegreeofStupidity=1});
            Employers.Add(new T() { Name = "Ilya", Post = "Office worker", DegreeofImpudence=4, DegreeofStupidity=0});
            Employers.Add(new T() { Name = "Robert", Post = "Office worker", DegreeofImpudence=0 , DegreeofStupidity=0});
            Employers.Add(new T() { Name = "Maksim", Post = "Office worker", DegreeofImpudence=0, DegreeofStupidity=1});
            Employers.Add(new T() { Name = "Aleksey", Post = "Office worker", DegreeofImpudence=1, DegreeofStupidity=1});
            Employers.Add(new T() { Name = "Natasha", Post = "Office worker", DegreeofImpudence=2, DegreeofStupidity=0});
            foreach (var item in Employers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Преобразуем нашу очередь с учетом степени наглости и тупости");
            Console.WriteLine("\n");
            List<T> Employersnew = new List<T>();
            Employersnew.Add(new T() { Name = "Ramil", Post = "Office worker", DegreeofImpudence = 2, DegreeofStupidity = 1 });
            Employersnew.Add(new T() { Name = "Marya", Post = "Office worker", DegreeofImpudence = 2, DegreeofStupidity = 1 });
            Employersnew.Add(new T() { Name = "Mark", Post = "Clerk", DegreeofImpudence = 1, DegreeofStupidity = 0 });
            Employersnew.Add(new T() { Name = "Renat", Post = "Office worker", DegreeofImpudence = 0, DegreeofStupidity = 0 });
            Employersnew.Add(new T() { Name = "Nastya", Post = "Office worker", DegreeofImpudence = 1, DegreeofStupidity = 0 });
            Employersnew.Add(new T() { Name = "Adel", Post = "Office worker", DegreeofImpudence = 0, DegreeofStupidity = 1 });
            Employersnew.Add(new T() { Name = "Ilya", Post = "Office worker", DegreeofImpudence = 4, DegreeofStupidity = 0 });
            Employersnew.Add(new T() { Name = "Robert", Post = "Office worker", DegreeofImpudence = 0, DegreeofStupidity = 0 });
            Employersnew.Add(new T() { Name = "Aleksey", Post = "Office worker", DegreeofImpudence = 1, DegreeofStupidity = 1 });
            Employersnew.Add(new T() { Name = "Maksim", Post = "Office worker", DegreeofImpudence = 0, DegreeofStupidity = 1 });
            Employersnew.Add(new T() { Name = "Natasha", Post = "Office worker", DegreeofImpudence = 2, DegreeofStupidity = 0 });
            foreach (var item in Employersnew)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Предположим,что работники являются знакомыми,с каждыми 4 людьми,стоящими позади них в очереди в новом списке,а начиная с 3-го человека с конца знакомтсва идут по верхнему списку");
            Console.WriteLine("К примеру : ");
            string[] meeting = new string[3];
            meeting[0] = "Ramil знаком с Marya,Mark,Renat,Nastya";
            meeting[1] = "Marya знакома c Mark,Renat,Nastya,Adel";
            meeting[2] = "Natasha знакома с Ramil,Marya,Mark,Renat";
            for (int i = 0; i < meeting.Length; i++)
            {
                Console.WriteLine(meeting[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Рассадим работников");
            Console.WriteLine("\n");
            for (int i = 0; i < Employersnew.Count; i++)
            {
                Console.Write(Employersnew[i] +" ");
                Table table  = tables.Pop();
                Console.WriteLine(" стол номер "+ table.Name + " " +table.Colour);               
            }


        }

    }
}   
