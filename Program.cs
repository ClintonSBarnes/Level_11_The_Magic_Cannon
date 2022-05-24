// See https://aka.ms/new-console-template for more information

int cannon = 100;
string autoStatus;
string reload = "Y";

Console.WriteLine("The magic cannon has been prepared for the defense of Consolas. " +
    "You have 100 rounds to fire.\nWould you like to fire the cannon in (A)utomatic mode or (S)emiauto mode?");
autoStatus = Console.ReadLine();
Console.Clear();

do
{
    if (autoStatus == "A" && reload =="Y")
    {


        for (int i = 0; i < cannon; i++)
        {
            if (i != cannon)
            {

                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric");
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Electric and Fire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Normal");
                }

            }
            
            

        }
        Console.WriteLine("Would you like to reload? (Y/N) ");
        reload = Console.ReadLine();
    }
    else if (reload == "Y")
    {
        for (int i = 0; i < cannon; i++)
        {
            if (i != cannon)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Press any button to fire!");
                Console.ReadKey();
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric");
                }
                else if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Electric and Fire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Normal");
                }

            }

        }
        Console.WriteLine("Would you like to reload? (Y/N) ");
        reload = Console.ReadLine();
    }
}
while (reload == "Y");

Console.WriteLine("You have stopped using the Magic Cannon");







Console.ReadKey();