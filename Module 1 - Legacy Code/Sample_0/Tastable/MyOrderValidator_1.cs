using Sample_0.Legacy_Code;

namespace Sample_0.Tastable
{
    internal class MyOrderValidator_1 : IOrderValidator
    {
        public bool Validate(Order order)
        {
            // do some
            Console.WriteLine("MyOrderValidator_1.Validate: called!");
            return true;
        }
    }
}
