using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            int king=1, queen=2, rook=3, knight=4, bishop=5, pawn=6;
            int piece;

            Console.WriteLine("Введите название фигуры: ");
            piece = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное положение фигуры: ");
            string nachalo = Console.ReadLine();

            Console.WriteLine("Введите конечное положение фигуры: ");
            string konechn = Console.ReadLine();

            if (piece == knight)
            {
                if (knight1.IsCorrectKnight(nachalo[0], nachalo[1], konechn[0], konechn[1]))
                {
                    Console.WriteLine("верно");
                }
                else
                {
                    Console.WriteLine("неверно");
                }
            }
        }
    }
}
