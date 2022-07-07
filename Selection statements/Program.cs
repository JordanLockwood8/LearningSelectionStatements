//Exercise 1
Console.WriteLine("Can you guess what my fav number is?");
var userInput = int.Parse(Console.ReadLine());
var fav = 8;

if (userInput == fav)
{
    Console.WriteLine("Great job!!!");
}
else if (userInput > fav)
{
    Console.WriteLine("Too High!");
}
else if (userInput < fav)
{
    Console.WriteLine("Too low!");
}

//Excercise 2


