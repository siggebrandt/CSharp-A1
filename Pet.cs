using System;
public class Pet
{
    private string name;
    private int age;
    private bool isFemale;

    public void Start()
    {
        Console.Write("Ange namn på ditt husdjur: ");
        name = Console.ReadLine();
        Console.Write("Ange ålder: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Är det hona? (ja/nej): ");
        isFemale = Console.ReadLine().ToLower() == "ja";
        
        Console.WriteLine($"Husdjur: {name}, Ålder: {age}, Kön: {(isFemale ? "Hona" : "Hane")}");
    }
}
