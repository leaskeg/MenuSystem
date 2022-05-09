using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuSystem
{
    public class Menu
    {
        public string Title { get; set; }
        public int ItemCount = 0;
        public MenuItem[] MenuItems = new MenuItem[10];
       
        public void Show()
        {
            while (true)
            {
                Console.WriteLine(Title + "\n");
                for (int i = 0; i < ItemCount; i++)
                {

                    Console.WriteLine("  " + MenuItems[i].Title);

                }
                Console.WriteLine("\n(Tryk menupunkt eller 0 for at afslutte)");
                
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void AddMenuItem(string TitleTest, int num)
        {
            /*mi = new MenuItem();
            mi.Title = "4. Få svaret på livet, universet og alting";
            mainMenu.MenuItems[3] = mi;
            mainMenu.ItemCount++;
            */
            MenuItem mi = new MenuItem();
            mi.Title = TitleTest;
            MenuItems[num] = mi;
            ItemCount++;

            /*ItemCount++;
            MenuItem mi = new MenuItem();
            Title = TitleTest;
            
            MenuItems[num] = new MenuItem { };*/
        }

    }
}
