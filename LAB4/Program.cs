using LAB4.Business;
using LAB4.Models;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Squad army = new Squad();
            Squad dragonSquad = new Squad();
            dragonSquad.Add(new Dragon());
            dragonSquad.Add(new Dragon());
            dragonSquad.Add(new Dragon());
            Squad orcSquad = new Squad();
            orcSquad.Add(new Orc());
            orcSquad.Add(new Orc());
            orcSquad.Add(new Orc());
            orcSquad.Add(new Cyclop());
            
            army.Add(dragonSquad);
            army.Add(orcSquad);
            army.Add(new Hydra());

            Console.WriteLine("3 dragons, 4 orcs and Hydra");
            client.One(army);
            Console.WriteLine("3 dragons and 4 orcs");
            client.Several(dragonSquad, orcSquad);
        }
    }
}