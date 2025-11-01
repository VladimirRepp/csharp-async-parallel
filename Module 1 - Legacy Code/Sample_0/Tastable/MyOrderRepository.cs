using Sample_0.Legacy_Code;

namespace Sample_0.Tastable
{
    internal class MyOrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            // do some
            Console.WriteLine("MyOrderRepository.Save: called!");
        }
    }
}
