namespace CurrencyCalculator
{
   class Program
   {
      
      static void Main(string[] args)
      {
         Dictionary<string, decimal> currency = new Dictionary<string, decimal>
         {
            ["USD"] = 493.50m,
            ["EUR"] = 520.30m,
            ["RUB"] = 5.20m,
            ["KZT"] = 1.00m 
         };
 
         bool exit = false;
         
         while (!exit)
         {
            Console.Clear();
            Console.WriteLine("КОНВЕРТЕР ВАЛЮТ\n1.Посмотреть курс валют\n2.Обменять валюту\n0.Выход\n");
            Console.WriteLine("Выберите опцию: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
               switch (choice)
               {
                  case 1:
                     ShowCurrencyRates(currency);
                     break;

                  case 2:
                     ExchangeCurrency(currency);
                     break;

                  case 0:
                     exit = true;
                     Console.WriteLine("Bye bye!");
                     break;
                  default:
                     Console.WriteLine("Incorrect input!");
                     break;
               }
            }
            else
            {
               Console.WriteLine("Enter number!");
            }
            if (!exit)
            {
               Console.WriteLine("Press any key to continue....");
               Console.ReadKey();
            }
         }
         
      }

      static void ShowCurrencyRates(Dictionary<string,decimal> currency)
         {
            Console.Clear();
            Console.WriteLine("Курс валют к тенге:");

            foreach (var pair in currency)
               {
            if (pair.Key != "KZT") {
               Console.WriteLine($"1 {pair.Key} = {pair.Value:F2} KZT");
                  }
               }
         }


      private static void ExchangeCurrency(Dictionary<string, decimal> currency)
      {
         Console.Clear();
         Console.WriteLine("Введи наименование исходной валюты(KZT/USD/EUR/..): ");
         string name1 = Console.ReadLine().ToUpper();
         if (currency.TryGetValue(name1, out decimal curVal1))
         {
            Console.Clear();
            Console.WriteLine("Введите наименование исходящей валюты(KZT/USD/EUR/..): ");
            string name2 = Console.ReadLine().ToUpper();
            if (currency.TryGetValue(name2, out decimal curVal2))
            {
               Console.Clear();
               Console.WriteLine("Количество валюты: ");
               decimal volume = int.Parse(Console.ReadLine());
               decimal result = (volume / curVal2) * curVal1;
               Console.Clear();
               Console.WriteLine($"{volume:F2} {name1} = {result:F2} {name2}");
            }
            else
            {
               Console.WriteLine($"Валюта {name2} не найдена!");
            }
         }
         else
         {
            Console.WriteLine($"Валюта {name1} не найдена!");
         }
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();

         }
      }
   public enum CurrencyCode
      {
         USD,
         EUR,
         RUB,
         KZT
      } 
   }
