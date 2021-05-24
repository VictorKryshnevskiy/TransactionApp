using System;
using System.Text.Json;


namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            var transactionService = new TransactionService();
            Console.WriteLine("Здравствуйте!");
            while (!exit)
            {
                Console.WriteLine("Для добавления транзакции введите 1, для поиска тразакции по ID нажмите 2, для выхода из приложения нажмите 3");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Введите данные транзакции");
                        SaveTransaction(transactionService);
                        break;
                    case "2":
                        Console.WriteLine("Введите ID транзакции");
                        if (int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine(transactionService.Get(id));
                        }
                        else
                        {
                            Console.WriteLine("Введите ID корректно");
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Пожалуйста, выберите один из вариантов");
                        break;
                }
            }
        }
        static void SaveTransaction(TransactionService transactionService)
        {
            var transaction = new Transaction();
            Console.WriteLine("Введите Id");
            int id;
            decimal sum;
            DateTime date;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Введите ID корректно");
            }
            transaction.Id = id;
            Console.WriteLine("Введите дату");
            while (DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Введите дату корректно");
            }
            transaction.TransactionDate = date;
            Console.WriteLine("Введите сумму");
            while (Decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Введите сумму корректно");
            }
            transaction.Amount = sum;
            transactionService.Add(transaction);
        }
    }
}
