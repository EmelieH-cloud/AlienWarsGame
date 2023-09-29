

using AlienWars2023;

Welcome();
Console.Clear();
ShowMenu();
ShowAlien();
CalculateDamage();



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


}

void ShowMenu()
{
    bool isNotChosen = true;
    while (isNotChosen)
    {
        Console.WriteLine("Press e for easy, press m for medium, press h for hard");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Drawing d = new Drawing();

        if (keyInfo.Key == ConsoleKey.E)
        {
            Console.Clear();
            d.DrawEasy();
            isNotChosen = false;
        }
        else if (keyInfo.Key == ConsoleKey.M)
        {
            Console.Clear();
            d.DrawMedium();
            isNotChosen = false;
        }
        else if (keyInfo.Key == ConsoleKey.H)
        {
            Console.Clear();
            d.DrawHard();
            isNotChosen = false;
        }
    }
    Player1 p = new Player1(50);
    PressAnyKey(p);
}

void PressAnyKey(Player1 player)
{
    Console.WriteLine("\n\nPress any key to use the telescope to look for aliens");
    Console.ReadKey();
    Console.Clear();
}

AlienShip GetAlienShip()
{
    Random random = new Random();
    int s = random.Next(1, 11);
    AlienShip a = new AlienShip(s);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Length of spaceship: " + s + " meters");
    Console.ResetColor();
    return a;
}

Weapon GetWeapon()
{
    Console.WriteLine("Quick! choose a weapon! Do you need precision (press 'p') or speed (press 's')\n");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("  TAKE NOTE: small spaceships (< 5 meters) move slower than big ones! ");
    Console.ResetColor();

    string res = Console.ReadLine();
    if (res.Equals("p") || res.Equals("P"))
    {
        Weapon weapon = new Weapon(10, 2);
        return weapon;

    }
    else if (res.Equals("s") || res.Equals("S"))
    {
        Weapon weapon = new Weapon(2, 10);
        return weapon;
    }

    return null;
}

void CalculateDamage()
{
    int alienHealth = 50;

    while (alienHealth > 0)
    {
        AlienShip ship = GetAlienShip();
        Weapon weapon = GetWeapon();

        int m = ship.Meters;
        int precise = weapon.Precision;
        int speed = weapon.Speed;
        int largeDamage = 10;
        int smallDamage = 5;

        if (m < 5 && precise > speed)   // causes high damage 
        {
            alienHealth = alienHealth - largeDamage;
        }
        else if (m < 5 && speed > precise)  // causes low damage 
        {
            alienHealth = alienHealth - smallDamage;
        }
        else if (m >= 5 && speed > precise) // causes high damage 
        {
            alienHealth = alienHealth - largeDamage;
        }
        else if (m >= 5 && precise > speed) // causes low damage 
        {
            alienHealth = alienHealth - smallDamage;
        }
        Console.WriteLine("Health of the alienship is now: " + alienHealth);
    }
}

void ShowAlien()
{
    Console.WriteLine("       `. ___\r\n                    __,' __`.                _..----....____\r\n        __...--.'``;.   ,.   ;``--..__     .'    ,-._    _.-'\r\n  _..-''-------'   `'   `'   `'     O ``-''._   (,;') _,'\r\n,'________________                          \\`-._`-','\r\n `._              ```````````------...___   '-.._'-:\r\n    ```--.._      ,.                     ````--...__\\-.\r\n            `.--. `-`                       ____    |  |`\r\n              `. `.                       ,'`````.  ;  ;`\r\n                `._`.        __________   `.      \\'__/`\r\n                   `-:._____/______/___/____`.     \\  `\r\n                               |       `._    `.    \\\r\n                               `._________`-.   `.   `.___\r\n                                             SSt  `------'`");

}




