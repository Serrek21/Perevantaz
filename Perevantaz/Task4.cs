using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perevantaz
{
    internal class Task4
    {
        public class CreditCard
        {
            public string CardNumber { get; set; }
            public string ExpiryDate { get; set; }
            public int CVC { get; set; }

            private decimal _balance;
            public decimal Balance
            {
                get { return _balance; }
                set { _balance = value; }
            }

            public CreditCard(string cardNumber, string expiryDate, int cvc, decimal balance)
            {
                CardNumber = cardNumber;
                ExpiryDate = expiryDate;
                CVC = cvc;
                Balance = balance;
            }

            // Перевантаження оператора збільшення суми грошей на картці
            public static CreditCard operator +(CreditCard card, decimal amount)
            {
                card.Balance += amount;
                return card;
            }

            // Перевантаження оператора зменшення суми грошей на картці
            public static CreditCard operator -(CreditCard card, decimal amount)
            {
                card.Balance -= amount;
                return card;
            }

            // Перевантаження оператора порівняння для перевірки рівності CVC коду
            public static bool operator ==(CreditCard card1, CreditCard card2)
            {
                if (ReferenceEquals(card1, card2))
                    return true;

                if (card1 is null || card2 is null)
                    return false;

                return card1.CVC == card2.CVC;
            }

            // Перевантаження оператора порівняння для перевірки нерівності CVC коду
            public static bool operator !=(CreditCard card1, CreditCard card2)
            {
                return !(card1 == card2);
            }

            // Перевантаження оператора порівняння для перевірки меншості суми грошей на картці
            public static bool operator <(CreditCard card1, CreditCard card2)
            {
                return card1.Balance < card2.Balance;
            }

            // Перевантаження оператора порівняння для перевірки більшості суми грошей на картці
            public static bool operator >(CreditCard card1, CreditCard card2)
            {
                return card1.Balance > card2.Balance;
            }

            // Перевизначення методу Equals для порівняння CVC коду карток
            public override bool Equals(object obj)
            {
                if (!(obj is CreditCard))
                    return false;

                CreditCard other = (CreditCard)obj;
                return this.CVC == other.CVC;
            }
        }
    }
}
