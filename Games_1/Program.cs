
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace Games_1;
class Games_1{
    static void num_detect()
    {

        Console.WriteLine("Введите число чтоб узнать на что оно делится");
        Console.Write("Ваше число>>>");

        int num = Convert.ToInt16(Console.ReadLine());
        for (int numer = 1; numer <= num; numer++)
        {
            if (num % numer == 0)
            {
                Console.Write(numer + "\t");
            }
        }Console.WriteLine();
    }



    static void Games_num()
    {
        // Написание игры угадай число отдельный файл как заготовка для полноценного проекта 





        Console.WriteLine("Добро пожаловать в игру угадай число!!!");
        Console.WriteLine("Вы должны угадать число от 0 до 100, которое я загадал.");
        Console.WriteLine("У вас 15 попыток");

        Random VALUE = new Random();
        int num = VALUE.Next(0, 100);
        int attempts = 0;


        try
        {

            while (true)
            {
                Console.Write("Введите своё предположение>> "); string command = Console.ReadLine();

                int com_ = Convert.ToInt16(command);
                if (attempts < 14)
                {


                    if (com_ == num)
                    {
                        Console.WriteLine("Вы выйграли !!!!!");
                        break;
                    }
                    else if (num < com_)
                    {
                        Console.WriteLine("Не угадали нужно меньше!");
                        attempts++;
                        continue;
                    }
                    else if (num > com_)
                    {
                        Console.WriteLine("Нужно больше");
                        attempts++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ты лох попытки закончились");
                    break;
                }
            }
        }
        catch
        {
            Console.WriteLine("Ошибка недопустимое значение!!");
        }


    }
    
        
        
    
    static void Tabl_um()
    {
        string[,] tabl = new string[10,10];
        for (int row = 0;row<= 10;row++)
        {
            for (int column = 0; column <= 10; column++)
            {
                Console.Write((column+"*"+row+"="+(column*row))+"\t");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {Boolean flag = true;
        while (flag)
            
        {   
            Console.WriteLine();
            Console.WriteLine("Вы в главном меню выберите режим!");
            Console.WriteLine("1. Игра угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("4. Выход");
            Console.Write("Введите режим >>>");
            try
            {
                string command = Console.ReadLine();
                int com_ = Convert.ToInt16(command);
                switch (com_)
                {
                    case 1:
                        
                        Games_num();
                        break;
                    case 2:
                        Tabl_um();
                        break;
                    case 3:
                        num_detect();
                        break;
                    case 4:
                        flag = false;
                        break; 
                }

            }
            catch
            {
                Console.WriteLine("Вы что то ввели не правильно");
            }
        }
    }
    
}
