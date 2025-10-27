using System;
public class TicketSeller
{
    private string sellerName;
    private double ticketPrice;
    private int numAdults;
    private int numChildren;
    private double total;

    public void Start()
    {
        Console.Write("Ange biljettförsäljarens namn: ");
        sellerName = Console.ReadLine();
        Console.Write("Ange pris per biljett: ");
        ticketPrice = double.Parse(Console.ReadLine());
        Console.Write("Antal vuxna: ");
        numAdults = int.Parse(Console.ReadLine());
        Console.Write("Antal barn: ");
        numChildren = int.Parse(Console.ReadLine());
        total = (numAdults + numChildren) * ticketPrice;

        Console.WriteLine($"Försäljare: {sellerName}, Totalt att betala: {total}kr");
    }
}
