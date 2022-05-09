using System;

namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            while (status)
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
                        status = false;
                        break;

                    case 1:
                        Console.WriteLine("Gør dit");
                        
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("Gør dat");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Gør noget");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("42");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("5");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        Console.WriteLine("6");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 7:
                        Console.WriteLine("7");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    default:
                        Console.WriteLine("ikke et rigtigt tal,. ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            Console.WriteLine("\nProgrammet er afsluttet, tryk for luk");
            Console.ReadKey();



        }

    }
}
