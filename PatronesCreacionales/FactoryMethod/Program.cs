using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Logistics logistics;

        // Decide at runtime which type of logistics to use
        logistics = new TruckLogistics();
        Console.WriteLine(logistics.PlanDelivery());

        logistics = new ShipLogistics();
        Console.WriteLine(logistics.PlanDelivery());
    }
}
