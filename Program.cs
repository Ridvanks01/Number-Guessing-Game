
//Integers are defined
int guess;
int right = 3;
//Program name written to console
Console.WriteLine("** Welcome To Number Guessing Game! **");
//Random number generated
Random rnd = new Random();
//Random number assigned to number value
int number = rnd.Next(1, 11);
//Loop started
for (int i = 0; i < 3; i++)
{
    //Our right number has been written to the console
    Console.WriteLine("Make a guess (You have {0} rights):", right);
    //Guess value received from user
    guess = Convert.ToInt32(Console.ReadLine());
    //If guess is equal to number it will loop
    if (guess == number)
    {
        // This loop happens if the guess is equal to the number
        Console.WriteLine("Your guess is correct!");
        break;
    }
    // This loop happens if the guess is not equal to the number
    else
    {
        //It was written that our guess was wrong
        Console.WriteLine("Your guess is wrong!");
        //Our right has been reduced
        right--;
        //If we run out of right this loop happens
        if (right == 0)
        {
            //We have written to the console that we have no rights
            Console.WriteLine("You have no more rights!");
            break;
        }
    }
}
//We print the randomly generated number to the console
Console.WriteLine("Generated number was {0}", number);