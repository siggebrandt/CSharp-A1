using System;
class Program
{
    static void Main()
    {
        Pet pet = new Pet();
        pet.Start();

        Album album = new Album();
        album.Start();

        TicketSeller seller = new TicketSeller();
        seller.Start();
    }
}
