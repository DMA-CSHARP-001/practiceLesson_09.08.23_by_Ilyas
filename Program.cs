using System.Text;

namespace practiceLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            /*    int[] array = new int[5];
                int sum = 0;
                int avg = 0;
                int curry = 0;
                for (int i = 0; i < 5; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                    if (array[i] % 2 != 0)
                    {
                        sum += array[i];
                        curry++;
                        avg += array[i];
                    }
                }
                avg /= curry;
                Console.WriteLine($"sum = {sum}, avg = {avg}");*/
            #endregion
            #region task2
            /*   Console.WriteLine("telebelerin sayi : ");
               int countStudent = int.Parse(Console.ReadLine());
               Student[] students= new Student[countStudent];
               for(int i = 0; i < countStudent; i++)
               {
                   students[i] = new Student();
                   Console.WriteLine($" {i} student name = ");
                   students[i].name = Console.ReadLine();
                   Console.WriteLine($" {i} student lastname = ");
                   students[i].lastName = Console.ReadLine();
                   Console.WriteLine($" {i} student age = ");
                   students[i].age = int.Parse(Console.ReadLine());
                   Console.WriteLine($" {i} student mark = ");
                   students[i].Mark = int.Parse(Console.ReadLine());
               }
               int maxMark = 0;
               for(int i = 0; i < students.Length;i++)
               {
                   if (students[i].mark > maxMark)
                   {
                       maxMark= students[i].mark;
                   }
               }
               Console.WriteLine($"max Mark = {maxMark}");*/
            #endregion

            #region task3
            /* Console.Write("input: ");
             int inputInteger = int.Parse(Console.ReadLine());
             for(int i = 1; i <= inputInteger; i++)
             {
                 for(int j = 1; j <= i; j++)
                 {
                     Console.Write($"{j} ");
                 }
                 Console.WriteLine();
             }*/
            #endregion

            #region task5
            /*   string local = "test";
               StringBuilder input = new();
               while (true)
               {
                   Console.Write("please, input your word: ");
                   input.Append(Console.ReadLine());
                   if (CheckEqual(local, input.ToString()))
                   {
                       Console.WriteLine("taptin!!!!");
                       return;
                   }
                   else
                   {
                       Console.WriteLine("tapmadin, shansinizi yene sinayin");
                       input.Remove(0, input.Length);
                       continue;
                   }
               }*/
            #endregion


            #region task6
            /*Console.WriteLine("edetleri yazin:");
            if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
            {
                Changer(a, b, out a, out b);
                Console.WriteLine($"new a = {a}");
                Console.WriteLine($"new b = {b}");
            }*/
            #endregion

            #region task7
           /* Console.Write("Please, enter your polyndrom: ");
            string inputString = Console.ReadLine();
            if (isPolyndrom(inputString))
                Console.WriteLine("it's a polyndrome");
            else
                Console.WriteLine("it's not a polydrome");*/
            #endregion
        }
        public static bool isPolyndrom(string inputString)
        {
            string firstHalf = inputString[..(inputString.Length / 2)];
            string secondHalf = inputString[((inputString.Length + 1) / 2)..];
            for (int i = 0; i < firstHalf.Length; i++)
            {
                if (firstHalf[i] != secondHalf[firstHalf.Length - i - 1])
                    return false;
            }
            return true;
        }
        public static void Changer(int aCopy, int bCopy, out int a, out int b)
        {
            a = bCopy;
            b = aCopy;
        }
        public static bool CheckEqual(string local, string inputString)
        {
            Console.WriteLine(local);
            Console.WriteLine(inputString);
            return local == inputString;
        }
        struct Student
        {
            public string name;
            public string lastName;
            public int age;
            int mark;
            public int Mark
            {
                get
                {
                    return mark;
                }
                set
                {
                    if (value > 100 || value < 0)
                        Console.WriteLine("mark can be between 0 - 100");
                    else
                        mark = value;
                }
            }
        }
    }
}