using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("How much money would you like to convert?");
            string userMoney = Console.ReadLine();

            double money = Convert.ToDouble(userMoney);
            Console.WriteLine($"{money} is equal to...");

            // Define the coins
            int goldValue = 10;
            int silverValue = 5;

            // Find max number of gold coins that "fit" into the amount.
            double goldCoins = Math.Floor(money / goldValue);
            double remainder = money % goldValue;

            double silverCoins = Math.Floor(remainder / silverValue);
            remainder = remainder % silverValue;

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");

        }
    }
}


