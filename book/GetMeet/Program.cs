using System;

namespace GetMeet
{
    class Program
    {
        //Стартовая точка программы
        static void Main(string[] args)
        {
            //Приглашение для вывода имени
            var str = "What's your name? Hi, my name is ";
            Console.Write($"Hi, my name is Vicky!\n{str}");

            //Считывание введенного имени
            var name = Console.ReadLine();
            Console.SetCursorPosition(str.Length + name.Length, 1);
            Console.WriteLine("!");

            //Приветсвие с использованием введенного имени
            Console.WriteLine("Hi, " + name);

            //Ожыдание потверждения пользователя
            Console.WriteLine("Click <Enter> to end the program ...");
            Console.ReadKey();
        }
    }
}
