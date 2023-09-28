/*
Classes:
FirstHunter
SecondHunter
ThirdHunter
Alienship: int size 
Weapon

Logic:
Three difficulty levels, the higher the level, the more important
the choice of weapon + alienship will become. 

Decision-making:
Each spaceship will be presented with randomly generated facts.  

 */

Welcome();




void Welcome()
{
    for (int i = 0; i <= 10; i++)
    {
        Console.CursorVisible = false;
        string display = "";
        Thread.Sleep(100);
        if (i == 0)
        {
            display = "  ___  \r\n / _ \\ \r\n/ /_\\ \\\r\n|  _  |\r\n| | | |\r\n\\_| |_/";
        }
        else if (i == 1)
        {
            display += " _     \r\n| |    \r\n| |    \r\n| |    \r\n| |____\r\n\\_____/";
        }
        else if (i == 2)
        {
            display += " _____ \r\n|_   _|\r\n  | |  \r\n  | |  \r\n _| |_ \r\n \\___/ ";
        }
        else if (i == 3)
        {
            display += "|  ___|\r\n| |__  \r\n|  __| \r\n| |___ \r\n\\____/";
        }
        else if (i == 4)
        {
            display += " _   _ \r\n| \\ | |\r\n|  \\| |\r\n| . ` |\r\n| |\\  |\r\n\\_| \\_/";
        }
        else if (i == 5)
        {
            Console.Clear();
            display = " _    _ \r\n| |  | |\r\n| |  | |\r\n| |/\\| |\r\n\\  /\\  /\r\n \\/  \\/ ";
        }
        else if (i == 6)
        {
            display = "  ___  \r\n / _ \\ \r\n/ /_\\ \\\r\n|  _  |\r\n| | | |\r\n\\_| |_/";
        }
        else if (i == 7)
        {
            display = "______ \r\n| ___ \\\r\n| |_/ /\r\n|    / \r\n| |\\ \\ \r\n\\_| \\_|";
        }
        else if (i == 8)
        {
            display = " _____ \r\n/  ___|\r\n\\ `--. \r\n `--. \\\r\n/\\__/ /\r\n\\____/ ";
        }
        else if (i == 9)
        {
            Console.Clear();
            Console.WriteLine("\n");
            display = "\r\n            / o       o \\\r\n           /   \\     /   \\\r\n          /     )-\"-(     \\\r\n         /     ( 6 6 )     \\\r\n        /       \\ \" /       \\\r\n       /         )=(         \\\r\n      /   o   .--\"-\"--.   o   \\\r\n     /    I  /  -   -  \\  I    \\\r\n .--(    (_}y/\\       /\\y{_)    )--.\r\n(    \".___l\\/__\\_____/__\\/l___,\"    )\r\n \\                                 /\r\n  \"-._      o O o O o O o      _,-\"\r\n      `--Y--.___________.--Y--'\r\n         |==.___________.==|    \r\n         `==.___________.==' `  ";
            Console.WriteLine("ARE YOU READY?");
            Console.WriteLine("(Type 'yes' to confirm)");
            Console.WriteLine("\n");
            Console.WriteLine(display);
            break;

        }

        Console.WriteLine(display);
    }
    Console.WriteLine("\n");
    Console.CursorVisible = true;
    Console.Write("Answer: ");
    string answer = Console.ReadLine();
    while (!answer.Equals("yes") && !answer.Equals("YES"))
    {
        Console.WriteLine("There is only one way - FORWARD!");
        answer = Console.ReadLine();
    }

    Console.Clear();
    ShowMenu();

}

void ShowMenu()
{
    bool isNotChosen = false;
    while (!isNotChosen)
    {
        Console.WriteLine("Press e for easy, press m for medium, press h for hard");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.E)
        {
            Console.Clear();
            DrawEasy();
            isNotChosen = true;
        }
        else if (keyInfo.Key == ConsoleKey.M)
        {
            Console.Clear();
            DrawMedium();
            isNotChosen = true;
        }
        else if (keyInfo.Key == ConsoleKey.H)
        {
            Console.Clear();
            DrawHard();
            isNotChosen = true;
        }
    }

}

void DrawEasy()
{
    Console.Write("\n  ////^\\\\\\\\\r\n      | ^   ^ |\r\n     @ (o) (o) @\r\n      |   <   |\r\n      |  ___  |\r\n       \\_____/\r\n     ____|  |____\r\n    /    \\__/    \\\r\n   /              \\\r\n  /\\_/|        |\\_/\\\r\n / /  |        |  \\ \\\r\n( <   |        |   > )\r\n \\ \\  |        |  / /\r\n  \\ \\ |________| / /\r\n   \\ \\|");
}

void DrawMedium()
{
    Console.Write("\n  .-\"\"-.\r\n      /-.{}  \\\r\n      | _\\__.|\r\n      \\/^)^ \\/\r\n       \\ =  /\r\n  .---./`--`\\.--._\r\n /     `;--'`     \\\r\n;        /`       ;\r\n|       |*        |\r\n/   |   |     |    \\\r\n|    \\  |*    /    |\r\n\\_   |\\_|____/|  __/\r\n  \\__//======\\\\__/\r\n  / //_      _\\\\ \\\r\n  -'  |`\"\"\"\"`|  `-\r\n      |  L   |\r\n      >_ || _<\r\n      |  ||  |\r\n      |  ||  |\r\n     /   ||   \\\r\n    /    /,    \\\r\n     `|\"|`\"|\"|\"`\r\n     /  )  /  )         \r\n    /__/  /__/");
}

void DrawHard()
{
    Console.Write("\n         \r\n                 #_   _#\r\n                 |a` `a|\r\n                 |  u  |\r\n                 \\  =  /\r\n                 |\\___/|\r\n        ___ ____/:     :\\____ ___\r\n      .'   `.-===-\\   /-===-.`   '.\r\n     /      .-\"\"\"\"\"-.-\"\"\"\"\"-.      \\\r\n    /'             =:=             '\\\r\n  .'  ' .:    o   -=:=-   o    :. '  `.\r\n  (.'   /'. '-.....-'-.....-' .'\\   '.)\r\n  /' ._/   \".     --:--     .\"   \\_. '\\\r\n |  .'|      \".  ---:---  .\"      |'.  |\r\n |  : |       |  ---:---  |       | :  |\r\n  \\ : |       |_____._____|       | : /\r\n  /   (       |----|------|       )   \\\r\n /... .|      |    |      |      |. ...\\\r\n|::::/''     /     |       \\     ''\\::::|\r\n'\"\"\"\"       /'    .L_      `\\       \"\"\"\"'\r\n           /'-.,__/` `\\__..-'\\\r\n          ;      /     \\      ;\r\n          :     /       \\     |\r\n          |    /         \\.   |\r\n          |`../           |  ,/\r\n          ( _ )           |  _)\r\n          |   |           |   |\r\n          |___|           \\___|\r\n          :===|            |==|\r\n           \\  /            |__|\r\n           /\\/\\           /\"\"\"`8.__\r\n           |oo|           \\__.//___)\r\n           |==|\r\n           \\__/");
}


