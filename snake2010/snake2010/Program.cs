using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake2010
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25); //задаём размер окна и убираем возможность перемотки;

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //HorizontalLine Line = new HorizontalLine(5,10,8,'+');
            //Line.Drow();

            //VerticalLine VLine = new VerticalLine(1, 20, 2, '|');
            //VLine.Drow();

            //рамочка
            HorizontalLine upLine = new HorizontalLine(0,78,0,'+');
            HorizontalLine downLine = new HorizontalLine(0,78,24,'+');

            VerticalLine leftLine = new VerticalLine(0,24,0,'+');
            VerticalLine rightLine = new VerticalLine(0,24,78,'+');

            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300); 
            //Console.ReadLine();
        }
    }
}
