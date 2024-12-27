using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10._1
{
    internal class BanknoteLibrary
    {

        public class Banknote
        {

            public int Denomination { get; private set; }

 
            public int Quantity { get; private set; }


            public Banknote(int denomination, int quantity)
            {
                if (denomination <= 0)
                    throw new ArgumentException("Номинал купюры должен быть положительным.");
                if (quantity < 0)
                    throw new ArgumentException("Количество купюр не может быть отрицательным.");

                Denomination = denomination;
                Quantity = quantity;
            }
            public int CalculateTotalAmount()
            {
                return Denomination * Quantity;
            }
        }
    }
}

