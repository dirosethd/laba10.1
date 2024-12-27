using laba10._1;
using System;

namespace BanknoteLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Создаем объект EuroBanknote с деноминацией 10, количеством 5 и курсом 40 гривен за евро
                EuroBanknote euroBanknote = new EuroBanknote(10, 5, 40m);

                // Вычисляем общую сумму в гривне
                int totalInHryvnia = euroBanknote.CalculateTotalAmount();
                Console.WriteLine($"Общая сумма в гривне: {totalInHryvnia}");

                // Вычисляем общую сумму в евро
                decimal totalInEuros = euroBanknote.CalculateTotalAmountInEuros();
                Console.WriteLine($"Общая сумма в евро: {totalInEuros}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}