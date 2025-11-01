namespace Sample_0.Tastable
{
    internal class MyNotificator_1 : INotificator
    {
        public void SendEmail(string customerEmail, string message)
        {
            // do some 
            Console.WriteLine("MyNotificator_1.SendEmail: called!");
        }
    }
}
