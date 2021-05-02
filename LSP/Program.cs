using LSP.Payments;
using System;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            NubankRewards card = new NubankRewards();

            card.Validate();
            card.CollectPayment();

            Console.ReadLine();
        }
    }
}
