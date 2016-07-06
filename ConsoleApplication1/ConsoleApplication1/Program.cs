using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                     
            horizontline upline = new horizontline(0,78,0, '+');
           
            horizontline downline = new horizontline(0, 78, 24, '+');
            
            Verticalline leftline = new Verticalline(0, 24, 0, '+');
           
            Verticalline rightline = new Verticalline(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }

                snake.Move();
                Thread.Sleep(100);

            }
        
           
        }

        
    }
    
}
