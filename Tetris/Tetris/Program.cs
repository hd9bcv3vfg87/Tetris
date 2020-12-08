using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            int x1 = 19;
            int y1 = 15;
            char c1 = 'X';

            Draw(x1, y1, c1);
            
            int x2 = 20;
            int y2 = 15;
            char c2 = 'Y';

            Draw(x2, y2, c2);
            
            int x3 = 21;
            int y3 = 15;
            char c3 = 'Й';

            Draw(x3, y3, c3);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char c)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }

    }
}
