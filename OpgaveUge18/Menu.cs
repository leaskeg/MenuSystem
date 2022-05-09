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
        public void AddMenuItem()
        {
            MenuItems[0] = new MenuItem { };
        }
        public Menu()
        {
                
        }
    }
}
