int guess;
int right = 3;
Console.WriteLine("** Welcome To Number Guessing Game! **");
Random rnd = new Random();
int number = rnd.Next(1, 11);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Make a guess (You have {0} rights):", right);
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess == number)
    {
        Console.WriteLine("Your guess is true!");
        break;
    }
    else
    {
        Console.WriteLine("Your guess is false!");
        right--;
        if (right == 0)
        {
            Console.WriteLine("You have no more rights!");
            break;
        }
    }
}
Console.WriteLine("Generated number was {0}", number);