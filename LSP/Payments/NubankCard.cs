using System;

namespace LSP.Payments
{
    abstract class NubankCard : IPaymentInstrument
    {
        public virtual void Validate()
        {
            //Validações do cartão
        }

        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado.");
        }
    }
}
