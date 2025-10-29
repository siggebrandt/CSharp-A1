using System;
public class Pet
{
    private string name;
    private int age;
    private bool isFemale;

    public void Start()
    {
        Console.Write("Enter name of your pet: ");
        name = Console.ReadLine();
        Console.Write("Enter " + name + "'s age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Is "+ name + "a female (y/n)? ");
        isFemale = Console.ReadLine().ToLower() == "y";
        
        Console.WriteLine($"----------------------------\nName: {name}, Age: {age}\n{name} is a good {(isFemale ? "girl" : "boy")}!\n----------------------------");
    }
}
