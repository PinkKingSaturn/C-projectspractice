using System.Collections.Generic;

static void Main (string[] args)
{
int playerRandomNum;
int enemyRandomNum;

Random random = new Random();

int playerPoints = 0;
int enemyPoints = 0;

for (int i = 0; i < 10; i++)
{
        Console.WriteLine("Press any key to roll the dice");

        Console.ReadKey();

        playerRandomNum = random.Next(1, 7);
        Console.WriteLine("You rolled a " + playerRandomNum);

        Console.WriteLine("... ");
        System.Threading.Thread.Sleep(1000);


        enemyRandomNum = random.Next(1,7);
        Console.WriteLine("The Enemy rolled a " + enemyRandomNum);

        if (playerRandomNum > enemyRandomNum)
        {
            playerPoints++;
            Console.WriteLine("Player wins this round!");
        }
        else if (playerRandomNum < enemyRandomNum) {
            enemyPoints++;
            Console.WriteLine("The Enemy wins this round!");
        }
        else {
            Console.WriteLine("Draw, No points awarded!");
        }
        Console.WriteLine("The score is now - Player : " + playerPoints);
}

if (playerPoints > enemyPoints) {
    Console.WriteLine("You Win!");
}
else if (playerPoints < enemyPoints) {
    Console.WriteLine("You Lose! Try Again?");
}
else {
    Console.WriteLine("Its a Draw! Try Again?");
}
Console.ReadKey();
}
