using System;

class Program
{
    static void Main()
    {
        string[] choices = { "камень", "ножницы", "бумага" };

        Console.WriteLine("Выберите: камень, ножницы или бумага:");
        string userChoice = Console.ReadLine().ToLower();

        Random random = new Random();
        int randomIndex = random.Next(0, choices.Length);
        string computerChoice = choices[randomIndex];

        Console.WriteLine("Компьютер выбрал: " + computerChoice);

        if (userChoice == computerChoice)
        {
            Console.WriteLine("Ничья!");
        }
        else if ((userChoice == "камень" && computerChoice == "ножницы") ||
                 (userChoice == "ножницы" && computerChoice == "бумага") ||
                 (userChoice == "бумага" && computerChoice == "камень"))
        {
            Console.WriteLine("Вы победили!");
        }
        else
        {
            Console.WriteLine("Вы проиграли!");
        }
    }
}
