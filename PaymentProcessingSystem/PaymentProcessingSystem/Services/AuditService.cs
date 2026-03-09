using PaymentProcessingSystem.Events;

namespace PaymentProcessingSystem.Services
{
    public class AuditService
    {
        public void LogTransaction(object sender, PaymentEventArgs e)
        {
            var payment = e.Payment;

            Console.WriteLine($"Audit log created for Order {payment.OrderId}");
        }
    }
}