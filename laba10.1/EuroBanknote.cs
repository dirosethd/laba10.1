using static laba10._1.BanknoteLibrary;

namespace laba10._1
{
    internal class EuroBanknote
    {
        public EuroBanknote(int v1, int v2, decimal v3)
        {
        }

        internal int CalculateTotalAmount()
        {
            throw new NotImplementedException();
        }

        internal decimal CalculateTotalAmountInEuros() => throw new NotImplementedException();

        public class EuroBanknotes : Banknote
        {
            public decimal EuroToHryvniaRate { get; private set; }
            public EuroBanknotes(int denomination, int quantity, decimal euroToHryvniaRate)
                : base(denomination, quantity)
            {
                if (euroToHryvniaRate <= 0)
                    throw new ArgumentException("Стоимость евро в гривне должна быть положительной.");

                EuroToHryvniaRate = euroToHryvniaRate;
            }
            public decimal CalculateTotalAmountInEuros()
            {
                int totalInHryvnia = CalculateTotalAmount();
                return totalInHryvnia / EuroToHryvniaRate;
            }
        }
    }
}

