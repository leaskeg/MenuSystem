using System;

namespace MenuSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu mainMenu = new Menu("Min fantastiske menu");

            //mainMenu.Title = "Min fantastiske menu";
            mainMenu.MenuItems = new MenuItem[10];


            mainMenu.AddMenuItem("1. Gør dit", 0);

            mainMenu.AddMenuItem("2. Gør dat", 1);

            mainMenu.AddMenuItem("3. Gør noget", 2);

            mainMenu.AddMenuItem("4. Få svaret på livet, universet og alting", 3);


            mainMenu.Show();

            Console.ReadLine();
        }

    }
}
