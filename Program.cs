namespace CurrencyCalculator
{
   class Program
   {
      static void Main(string[] args)
      {
         
         string[] menu = { "1.Курс валют\n2.Обменник\n0.Exit\n", "1.Search \n0.Exit\n"};
         Console.WriteLine(menu[0]);
         Console.WriteLine("Select option from the list: ");
         int choice = int.Parse(Console.ReadLine());
         while (choice != 0)
         {
            if (choice == 1)
            {
               int subchoice = 99;
               while (subchoice != 0)
               {
                  Console.WriteLine(menu[1]);
                  subchoice = int.Parse(Console.ReadLine());
               }
            }
            else if (choice == 2)
            {
               
            }
         Console.WriteLine(menu[0]);
         Console.WriteLine("Select option from the list: ");
         choice = int.Parse(Console.ReadLine());
         }
          
      }
   }
}