namespace Sample_2.Legacy
{
    // Sprout Method:
    // Добавление нового функционала
    // в виде отдельного,
    // чистого метода/класса
    public class PriceCalculator
    {
        #region === Legacy ===
        // Старый метод (не изменять!)
        public decimal CalculatePrice(int quantity, decimal unitPrice)
        {
            return quantity * unitPrice;
        }
        #endregion

        // Ваш новый метод здесь...
        #region === Refactored/Modified ===
        // Новый, "проросший" метод, использующий старый
        public decimal CalculatePriceWithDiscount(int quantity, decimal unitPrice)
        {
            decimal basePrice = CalculatePrice(quantity, unitPrice);
            return ApplyDiscount(basePrice);
        }

        // Логика скидки изолирована в отдельном методе
        private decimal ApplyDiscount(decimal basePrice)
        {
            if (basePrice > 1000)
            {
                return basePrice * 0.90m; // 10% скидка
            }
            return basePrice;
        }
        #endregion
    }

}
