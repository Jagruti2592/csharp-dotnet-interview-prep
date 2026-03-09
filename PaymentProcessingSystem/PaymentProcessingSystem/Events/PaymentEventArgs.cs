
using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Events
{
    public class PaymentEventArgs : EventArgs
    {
        public PaymentRequest Payment { get; }

        public PaymentEventArgs(PaymentRequest payment)
        {
            Payment = payment;
        }
    }
}