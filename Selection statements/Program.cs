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
// Excersize 2
    Console.WriteLine();
    Console.WriteLine("What is your fav subject in school?");
    string subject = Console.ReadLine();
    switch (subject.ToLower())
    {
        case "science":
            Console.WriteLine("Science");
            break;

        case "math":
            Console.WriteLine("Math");
            break;

        case "gym":
            Console.WriteLine("Gym");
            break;

        case "history":
            Console.WriteLine("History");
            break;

        case "shop":
            Console.WriteLine("Shop");
            break;

        default:
            Console.WriteLine("that is not one of your classes!");
            break;

    };


