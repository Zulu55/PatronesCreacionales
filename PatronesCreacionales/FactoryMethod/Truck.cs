namespace FactoryMethod
{
    public class Truck : ITransport
    {
        public string Deliver()
        {
            return "Delivery by truck";
        }
    }
}