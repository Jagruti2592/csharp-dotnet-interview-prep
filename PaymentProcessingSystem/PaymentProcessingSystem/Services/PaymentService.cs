using System;
using PaymentProcessingSystem.Models;
using PaymentProcessingSystem.Delegates;

namespace PaymentProcessingSystem.Services
{
    public class PaymentService
    {
        //public PaymentHandler OnPaymentProcessed;

        //public void ProcessPayment(PaymentRequest payment)
        //{
        //    // Simulate payment processing logic
        //    Console.WriteLine($"Processing payment for Order ID: {payment.orderId}, Amount: {payment.Amount}, Customer Email: {payment.CustomerEmail}");
        //    // After processing, trigger the event
        //    OnPaymentProcessed?.Invoke(payment);
        //}

        public event EventHandler<PaymentEventArgs> PaymentProcessed;

        public void ProcessPayment(PaymentRequest payment)
        {
            // Simulate payment processing logic
            Console.WriteLine($"Processing payment for Order ID: {payment.orderId}, Amount: {payment.Amount}, Customer Email: {payment.CustomerEmail}");
            // After processing, trigger the event
            OnPaymentProcessed(payment);
        }

        protected virtual void OnPaymentProcessed(PaymentRequest payment)
        {
            PaymentProcessed?.Invoke(this, new PaymentEventArgs(payment));
        }
    }

}
