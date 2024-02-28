namespace FactoryMethod
{
    public abstract class Logistics
    {
        // The Factory Method
        public abstract ITransport CreateTransport();

        public string PlanDelivery()
        {
            // Get the transport object from the Factory Method
            var transport = CreateTransport();
            // Call the Deliver method of the transport object
            return transport.Deliver();
        }
    }
}