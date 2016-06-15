﻿using System;
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

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //Console.WriteLine("Нажмите enter, чтобы начать");
            //Console.ReadLine();

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //HorizontalLine Line = new HorizontalLine(5,10,8,'+');
            //Line.Drow();

            //VerticalLine VLine = new VerticalLine(1, 20, 2, '|');
            //VLine.Drow();

            //начальная точка
            Point p = new Point(4, 5, '*');
            //змейка
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            //Создаём еду для змейки
            FoodCreator foodCreator = new FoodCreator(80,25,'$'); //Диапозон поля в котором может быть создана еда
            Point food = foodCreator.CreateFood(); //точка создания еды на поле
            food.Draw(); // отрисовываем еду


            //управление змейкой
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) //проверяю столкновение змейки и стены(границы игрового поля) или столкновение со своим хвостом
                {
                    break; //если столкновение было выходим из игры
                }

                if (snake.Eat(food)) //змея нашла еду
                {
                    food = foodCreator.CreateFood(); //создаём новую еду
                    food.Draw(); //отрисовываем еду
                }
                else //еды нет ползём дальше
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable) //нажатие кнопки было или нет
                {
                    ConsoleKeyInfo key = Console.ReadKey(); //читаем нажатую кнопку
                    snake.HandleKey(key.Key); //обрабатываем нажатую кнопку
                }
            }
            //Console.ReadLine();
        }
    }
}
