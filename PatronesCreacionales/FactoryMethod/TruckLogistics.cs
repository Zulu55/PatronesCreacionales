namespace FactoryMethod
{
    public class TruckLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}