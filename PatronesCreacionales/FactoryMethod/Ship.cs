namespace FactoryMethod
{
    public class Ship : ITransport
    {
        public string Deliver()
        {
            return "Delivery by ship";
        }
    }
}