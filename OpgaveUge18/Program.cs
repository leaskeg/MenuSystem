using System;

namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Min fantastiske menu");

            mainMenu.MenuItems = new MenuItem[10];
            mainMenu.AddMenuItem("1. Gør dit", 0);
            mainMenu.AddMenuItem("2. Gør dat", 1);
            mainMenu.AddMenuItem("3. Gør noget", 2);
            mainMenu.AddMenuItem("4. Få svaret på livet, universet og alting", 3);
            mainMenu.AddMenuItem("5. Få svaret på livet, universet og alting", 4);
            mainMenu.AddMenuItem("6. Få svaret på livet, universet og alting", 5);
            mainMenu.AddMenuItem("7. Få svaret på livet, universet og alting", 6);


            mainMenu.Show();

            switch (mainMenu.ItemCount)
            {
                case 0:
                    break;

               case 1:
                    Console.WriteLine("Gør dit");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("Gør dat");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.WriteLine("Gør noget");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine("42");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.WriteLine("5");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.WriteLine("6");
                    Console.ReadKey();
                    break;

                case 7:
                    Console.WriteLine("7");
                    Console.ReadKey();
                    break;


                default:
                    Console.WriteLine("ikke et rigtigt tal,. ");
                    break;
            }
            
            Console.WriteLine("\nProgrammet er afsluttet, tryk for luk");
            Console.ReadKey();



        }

    }
}
