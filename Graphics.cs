using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robe
{
    internal class Graphics
    {
        public void DrawTitle() {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            Console.WriteLine(""" ___    ________________________________________   ___""");
            Console.WriteLine(""" \  \   \______  \   / ___\  |   ___ \|   _____/   \  \""");
            Console.WriteLine("""  \  \   |      _/  /  | | \ |   |_|_/|   ____/     \  \""");
            Console.WriteLine("""   |  )  |    |  \ /   |_|  \|   |_| \|       \      |  )""");
            Console.WriteLine("""  /__/   |____| \_\\______  /|______  /|______ \    /__/""");
            Console.WriteLine(""" /__/        \/           \/        \/        \/   /__/""");
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }

<<<<<<< Updated upstream
        public void DrawTitleOptions()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/START (1)/          /SETTINGS (2)/          /QUIT (3)/""");
=======
        public void DrawOptions() {
            Console.WriteLine(""" ______________________________________________________""");
            Console.WriteLine("""/START (1)/          /SETTINGS (2)/          /QUIT (3)/""");
>>>>>>> Stashed changes
        }

        public void DrawBattle(Entity player, Entity[] Enemy)
        {
            //if (Enemy.Length > 5){
            //    throw new Exception("Too many enemies, max is 5");
            //}

            //if (Enemy.Length < 1){
            //    throw new Exception("Not enough enemies, min is 1");
            //}
            
            
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");

            console.Write($"{player.GetName()} ");
            foreach(Entity enemy in Enemy)
            {
                console.Write($"{enemy.GetName()} ");
            }
            console.WriteLine("");

            console.Write($"HP:{player.GetHealth()} ");
            foreach(Entity enemy in Enemy)
            {
                console.Write($"HP:{enemy.GetHealth()} ");
            }
            console.WriteLine("");
            console.Write($"AP:{player.GetAPower()} ");
            foreach(Entity enemy in Enemy)
            {
                console.Write($"AP:{enemy.GetAPower()} ");
            }
            console.WriteLine("");
            console.WriteLine("//////////////////////////////////////////////");
            console.WriteLine("//////////////////////////////////////////////");
            console.WriteLine("//////////////////////////////////////////////");
            
        }

        public void DrawBattleOptions()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/ATTACK (1)/          /DEFEND (2)/          /ITEM (3)/""");
        }

        public void DrawDeathScreen()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
            console.WriteLine("""    _______   _      _       _       _____   _   _ """);
            console.WriteLine("""    |  ___|  / \    | |     | |     | ____| | \ | |""");
            console.WriteLine("""    | |_    / _ \   | |     | |     |  _|   |  \| |""");
            console.WriteLine("""    |  _|  / ___ \  | |___  | |___  | |___  | |\  |""");
            console.WriteLine("""    |_|   /_/   \_\ |_____| |_____| |_____| |_| \_|""");
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/_____/_____/_____/_____/_____/_____/_____/_____/_____/""");
        }

        public void DrawDeathScreenOptions()
        {
            console.WriteLine(""" ______________________________________________________""");
            console.WriteLine("""/RESTART (1)/                                /QUIT (2)/""");
        }

        //public void DrawEvent()
        //{
        //
        //}

        //public void DrawEventOptions()
        //{
        //
        //}

        //public void DrawSettings()
        //{
        //
        //}

        //public void DrawSettingsOptions()
        //{
        //
        //}

        //public void DrawInventory()
        //{
        //
        //}

        //public void DrawInventoryOptions()
        //{
        //
        //}

    }
}