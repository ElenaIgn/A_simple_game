using System;

class Program

{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n = rnd.Next(0, 11);

        // объявление переменных
        int playerHealth = 100;
        int enemyHealth = 100;
        int playerEnergy = 100;
        int enemyEnergy = 100;
        int action = -1;

        while (true)
        {
            // отображение скатов и скиллов
            Console.Clear();
            Console.WriteLine(@"    Жизни: {0}                      жизни вируса: {1}", playerHealth, enemyHealth);
            Console.WriteLine(@"    Энергия: {0}                    энергия вируса: {1}", playerEnergy, enemyEnergy);
            Console.WriteLine();

            Console.WriteLine("1. Почистить папку Темп (20 урона, -10 энергии)");
            Console.WriteLine("2. Использовать Касперского (30 урона, -40 энергии)");
            Console.WriteLine("3. Выпить кофе (+20 энергии)");
            Console.WriteLine("4. Заказать доставку пиццы (+30 жизни, -20 энергии)");

            Console.WriteLine();
            // определение победы или поражения

            if (playerHealth <= 0)
            {
                Console.WriteLine("Вирус выиграл!");
                break;
            }

            if (enemyHealth <= 0)
            {
                Console.WriteLine("Ты выиграл!");
                break;
            }
            action = int.Parse(Console.ReadLine());

            // получение действия от игрока
            // описание работы скилов игрока 
            if (action == 1)
            {
                if (playerEnergy >= 10)
                {
                    enemyHealth -= 20;
                    playerEnergy -= 10;
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход!");
                    Console.ReadLine();
                }

            }
            if (action == 2)
            {
                if (playerEnergy >= 40)
                {
                    enemyHealth -= 30;
                    playerEnergy -= 40;
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход!");
                    Console.ReadLine();
                }

            }
            if (action == 3)
            {
                playerEnergy += 20;
                
            }

            if (action == 4)
            {
                if (playerEnergy >= 20)
                {
                    playerHealth += 30;
                    playerEnergy -= 20;
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход!");
                    Console.ReadLine();
                }

            }

            action = rnd.Next(1, 4);

            if (enemyHealth <= 25)
            {
                action = 2;
            }
            // описание действия от противника

            if (action == 1)
            {
                if (enemyEnergy >= 12)
                {
                    playerHealth -= 25;
                    enemyEnergy -= 12;
                    Console.WriteLine("Вы получили 25 урона!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход!");
                    Console.ReadLine();
                }

            }
            if (action == 2)
            {
                enemyEnergy += 30;
                //Console.WriteLine("Вы получили 30 урона!");
                //Console.ReadLine();
            }
            if (action == 3)
            {
                if (enemyEnergy >= 20)
                {
                    playerHealth -= 25;
                    enemyEnergy -= 20;
                    Console.WriteLine("Вы получили 25 урона!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Не достаточно энергии. Ты пропустил этот ход!");
                    Console.ReadLine();
                }

            }

            // описание работы скиллов противника
            
        }


        




        Console.ReadLine();
    }
}