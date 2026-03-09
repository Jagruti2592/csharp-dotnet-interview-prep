using System;
using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Services
{
    public class EmailService
    {
        public void SendReceipt(object sender, PaymentEventArgs e)

        {
            var payment = e.Payment;
            Console.WriteLine($"Email sent to {payment.CustomerEmail} for ${payment.Amount}");
        }
    }
}
