namespace VariableExercise;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play a questions game!");
        Console.WriteLine("Please tell me your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Nice to meet you {userName}! Now put in your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You are {userAge} that's cool! Now tell me the first letter of your middle name now:");
        char userMiddleName = Convert.ToChar(Console.ReadLine());
        Console.WriteLine($"You're middle names starts with a {userMiddleName} sounds nice");
        Console.WriteLine("Is it true you are taking true coders bootcamp");
        bool userEducation = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine($"{userEducation}, I am also taking that bootcamp! What is your gpa for TrueCoders?" );
        double userGpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"A {userGpa} is a really good grade! Now how much did it cost for you for this bootcamp?");
        decimal userCost = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"It cost you {userCost}? This bootcamp is worth the money though!");
        Console.WriteLine("Thank you for answering my questions have a great day!");





    }
}