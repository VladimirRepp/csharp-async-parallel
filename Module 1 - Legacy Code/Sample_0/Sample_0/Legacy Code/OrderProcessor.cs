using System.ComponentModel.DataAnnotations;

namespace Sample_0.Legacy_Code
{
    internal class OrderProcessor
    {
        public void Process(Order order)
        {
            OrderValidator validator = new(); // внутреняя зависимость - ПЛОХО!!!
            if (!validator.Validate(order))
            {
                throw new Exception("OrderProcessor.Process: order not validate!");
            }

            OrderRepository repository = new(); // внутреняя зависимость - ПЛОХО!!!
            repository.Save(order);

            EmailNotificator notificator = new();// внутреняя зависимость - ПЛОХО!!!
            notificator.SendEmail(order.CustomerEmail, "Заказ обработан");
        }
    }
}
