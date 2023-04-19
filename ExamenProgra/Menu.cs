using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenProgra
{
    internal class Menu
    {
        bool continueFlag = true;
        private List<Items> item;
        public void Execute()
        {
           item = new List<Items>();

            continueFlag = true;

            while (continueFlag)
            {
                MenuPrincipal();

            }

        }

        public void MenuPrincipal()
        {
            Console.WriteLine("Enter the number you want to make:");
            Console.WriteLine("1. Create player/Npc/Item");
            Console.WriteLine("2. See information");
            Console.WriteLine("3. Delete Npc/Item");
            Console.WriteLine("4. Add something");
            Console.WriteLine("5. Exit");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowCreate();
                    break;
                case "2":
                    ShowInformation();
                    break;
                case "3":
                    ShowDelete();
                    break;
                case "4":
                    ShowAdd();
                    break;
                case "5":
                    continueFlag = false;
                    break;
                default:
                    break;
            }

        }
        public void ShowCreate()
        {
            Console.WriteLine("What do u like to do? ");
            Console.WriteLine("1.Create Player ");
            Console.WriteLine("2.Create Npc ");
            Console.WriteLine("2.Create Item ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddPlayer();
                    break;
                case "2":
                    AddNpc();
                    break;
                case "3":
                    AddItem();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
        public void AddPlayer()
        {
            Console.WriteLine("Bienvenido, introduzca sus datos de jugador");
            Player player = new Player();
            Console.WriteLine("Que nombre desea");
            string playerName = Console.ReadLine();
            player.GetName(playerName);
            Console.WriteLine("Cuanto de experiencia desea");
            float playerExperience = float.Parse(Console.ReadLine());
            player.GetExperience(playerExperience);
            Console.WriteLine(player.ShowData());
        }
        public void AddNpc()
        {

        }
        public void AddItem()
        {
           /* string name;
            string itemtype;
            float price;
            Console.WriteLine("Add name of the item:");
            name = Console.ReadLine();
            Console.WriteLine("Add type of the item:");
            itemtype = Console.ReadLine();
            Console.WriteLine("Add price of the item:");
            price = float.Parse(Console.ReadLine());

            item.Add(new Items(name, itemtype, price));*/
        }
        public void ShowInformation()
        {
            Console.WriteLine("What do u like to do? ");
            Console.WriteLine("1.See the information of Player ");
            Console.WriteLine("2.See the information of Npc ");
            Console.WriteLine("3.See the information of Item ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    PlayerInformation();
                    break;
                case "2":
                    NpcInformation();
                    break;
                case "3":
                    ItemInformation();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
        public void PlayerInformation()
        {

        }

        public void NpcInformation()
        {
        
        }
        public void ItemInformation()
        { 
        
        }

        public void ShowDelete()
        {
            Console.WriteLine("What do u like to do? ");
            Console.WriteLine("1.Delete Npc ");
            Console.WriteLine("2.Delete Item ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    DeleteNpc();
                    break;
                case "2":
                    DeleteItem();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        public void DeleteNpc()
        {

        }
        public void DeleteItem()
        {
            Console.WriteLine("Enter the number of the item you want to delete");
            AddItem();

            int i = int.Parse(Console.ReadLine());
            if (i >= 0 && i < item.Count)
            {
                item.RemoveAt(i);
            }
            else
            {
                Console.WriteLine("the item number you pressed does not exist");
            }
        }
        public void ShowAdd()
        {
            Console.WriteLine("Select a Item: "); //Add item Here
            
        }
    }
}
