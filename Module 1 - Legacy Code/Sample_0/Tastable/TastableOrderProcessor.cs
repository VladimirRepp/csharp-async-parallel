using Sample_0.Legacy_Code;

namespace Sample_0.Tastable
{
    internal class TastableOrderProcessor
    {
        private readonly IOrderValidator _validator;
        private readonly IOrderRepository _repository;
        private readonly INotificator _notificator;

        public TastableOrderProcessor(
            IOrderValidator validator,
            IOrderRepository repository,
            INotificator notificator
            )
        {
            _validator = validator;
            _repository = repository;
            _notificator = notificator;
        }

        public void Process(Order order)
        {
            if (!_validator.Validate(order))
            {
                throw new Exception("OrderProcessor.Process: order not validate!");
            }

            _repository.Save(order);

            _notificator.SendEmail(order.CustomerEmail, "Заказ обработан");
        }
    }
}
