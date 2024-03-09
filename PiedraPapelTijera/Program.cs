
using System.Diagnostics;

Console.WriteLine("Rock Paper Scissors");

while (true)
{
    Console.WriteLine("Are you ready?");
    Console.WriteLine("Let's begin!!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You selected {yourChoice}");

    var opponentChoice = GetOpponentChoice();

    Console.WriteLine($"I Choose {opponentChoice}");

    DecideWinner(opponentChoice, yourChoice);

    Console.WriteLine("Do you play to again?");
    Console.WriteLine("Enter YES to play again or any other key to stop...");

    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "yes")
        continue;
    else
        break;

    
}
//Method that allows you to validate if the option you select is valid
string SelectChoice()
{
    Console.WriteLine("Choose R, P or S: [R]ock, [P]aper or [S]cissors: ");
    var selectedChoice = Console.ReadLine();

    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please, select only on letter: R, P or S");
        selectedChoice = SelectChoice();
    }

    return selectedChoice;

}

//Method that allows the opponent to randomly select an option
char GetOpponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S' };

    Random random = new Random();
    int randomIndex = random.Next(options.Length);

    return options[randomIndex];
}

//Method that allows determining the winner
void DecideWinner(char opponentChoice, char yourChoice)
{
    if (opponentChoice == yourChoice)
    {
        Console.WriteLine("Tie!");
        return;

    }
        
    switch(yourChoice)
    {
        case 'R':
        case 'r':
            if (opponentChoice == 'P')
                Console.WriteLine("Paper beats rock, I win!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Rock beats Scissors, You win!");
            break;
        case 'S':
        case 's':
            if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats paper, You win!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Rock beats Scissors, I win!");
            break;
        case 'P':
        case 'p':
            if (opponentChoice == 'S')
                Console.WriteLine("Scissors beats paper, I win!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Paper beats Rock, you win!");
            break;
        default:
            break;
    }

}