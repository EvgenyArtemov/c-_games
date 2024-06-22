// See https://aka.ms/new-console-template for more information

int playerRandomNum;
int enemyRandomNum;
int playerTotal = 0;
int enemyTotal = 0;

Random random = new Random();

for (int i = 0; i < 10; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Press any key to roll the Dice!");
    }
    else
    {
        Console.WriteLine("Press any key to roll again!");
        Console.WriteLine();
    }

    Console.ReadKey();
    
    playerRandomNum = random.Next(1, 7);

    playerTotal = playerRandomNum + playerTotal;
    
    Console.WriteLine("You rolled a " + playerRandomNum);
    
    Console.WriteLine("...");
    System.Threading.Thread.Sleep(1000);

    enemyRandomNum = random.Next(1, 7);
    enemyTotal = enemyRandomNum + enemyTotal;
    
    Console.WriteLine("Your enemy rolled " + enemyRandomNum);
    Console.WriteLine();
}

if (playerTotal > enemyTotal)
{
    Console.WriteLine("You won! Your total is " + playerTotal + "and your enemy total is " + enemyTotal);
}
else
{
    Console.WriteLine("You lose! :( Your enemy total score is " + enemyTotal + "and your is " + playerTotal);
}


