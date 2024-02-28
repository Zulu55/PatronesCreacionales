namespace FactoryMethod
{
    public class ShipLogistics : Logistics
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}