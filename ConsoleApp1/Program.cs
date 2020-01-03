using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge = 22;
            bool isMale = true;
            int len = characterName.Length;
            Console.WriteLine("Hello World!");


            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 700;


            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.pages);

            twodarray();

            Console.WriteLine("Character Name is " + characterName);
            Console.WriteLine("Character Age is " + characterAge);
            Console.WriteLine(isMale);
            Console.WriteLine(len);
            Console.WriteLine(characterName.ToUpper());

            Console.WriteLine(characterName.Contains("hn"));
            Console.WriteLine(characterName[0]);
            Console.WriteLine(characterName.IndexOf("ohn"));
            Console.WriteLine(characterName.IndexOf('j'));
            Console.WriteLine(characterName.Substring(1, 3));

            Console.WriteLine(Math.Abs(-4));
            Console.WriteLine(Math.Pow(2, 3));


            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int add = num1 + num2;
            Console.WriteLine("Sum = " + add);
            SayHi();
        }

        static void SayHi()
        {
            Console.WriteLine("Hello User");
        }

        static void twodarray()
        {
            int[,] numberGrid= { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine(numberGrid[0,0]);

        }
    }
}
