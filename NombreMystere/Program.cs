Console.WriteLine("le jeu du nombre mystère !!");

Console.WriteLine("quel est votre prenom ?");
string playerName = Console.ReadLine();

var rand = new Random();
int numMyst = rand.Next(1, 101);
// Console.WriteLine(numMyst);
int luck = 10;

Console.WriteLine($"Bonjour {playerName} vous devez deviné quel est le nombre mystère ( il est compris entre 1 et 100) vous avez {luck} chance");


while (luck > 0)
{
    Console.WriteLine($"il vous reste {luck} chance ");
    Console.WriteLine("entrez votre nombre");
    int playerChoice = int.Parse(Console.ReadLine());

    

    if (numMyst == playerChoice)
    {
        Console.WriteLine($"Bravo {playerName} vous avez gagné");
            Console.WriteLine($"le nombre mystère etait bien {numMyst}");

        break;
    }
    else
    {
        if (numMyst < playerChoice)
        {
            Console.WriteLine("le nombre mystère est plus petit");
            luck--;
        }
        if (numMyst > playerChoice)
        {
            Console.WriteLine("le nombre mystère est plus grand");
            luck--;
        }

    }

}

if (luck == 0)
{
    Console.WriteLine($"Dommage {playerName} vous avez perdu !!");
    Console.WriteLine($"le nombre mystère etait {numMyst}");

}
