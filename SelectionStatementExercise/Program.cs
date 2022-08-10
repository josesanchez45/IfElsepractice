// Exercise 1
var favNumber = 25;


Console.WriteLine(" Can you guess my favorite number?");
Console.WriteLine("Type in your guess below (between 1 and 100) : ");
var userInput = int.Parse(Console.ReadLine());

if (userInput == favNumber)
{
    Console.WriteLine("You guessed it!"); 
}
else if (userInput < favNumber)
{
    Console.WriteLine("Too low!");
}
else
{
    Console.WriteLine("Too High!");
}
//Exercise 2
