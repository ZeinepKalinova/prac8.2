using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в Продуктовый супермаркет!");

       
        Console.Write("Введите текущее время (часы): ");
        int currentHour = int.Parse(Console.ReadLine());

        string[] products = { "Хлеб", "Молоко", "Яйца", "Фрукты", "Овощи" };
        double[] prices = { 2.0, 2.5, 1.2, 4.0, 3.0 };

        Console.WriteLine("\nСписок продуктов:");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i]} - ${prices[i]:F2}");
        }

        Console.Write("\nВведите номера выбранных продуктов (через пробел): ");
        string[] choices = Console.ReadLine().Split(' ');

        double totalCost = 0;
        foreach (string choice in choices)
        {
            int productIndex = int.Parse(choice) - 1;
            if (productIndex >= 0 && productIndex < products.Length)
            {
                totalCost += prices[productIndex];
            }
        }

        if (currentHour >= 8 && currentHour <= 12)
        {
            double discount = 0.05 * totalCost;
            totalCost -= discount;
            Console.WriteLine($"\nПрименена скидка 5% ({discount:F2}$)");
        }

      
        Console.WriteLine($"\nОбщая сумма покупки: {totalCost:F2}$");

        Console.WriteLine("Спасибо за покупку! Приходите еще!");
    }
}
