

namespace LAB4.Business
{
    class Client
    {
        public void One(Component unit)
        {
            Console.WriteLine($"Power: {unit.Power}\n");
        }

        public void Several(Component c1, Component c2)
        {
            Console.WriteLine($"Total power: {c1.Power + c2.Power}");
        }
    }
}
