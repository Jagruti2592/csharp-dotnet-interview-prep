using PaymentProcessingSystem.Events;

namespace PaymentProcessingSystem.Services
{
    public class AnalyticsService
    {
        public void TrackPayment(object sender, PaymentEventArgs e)
        {
            var payment = e.Payment;

            Console.WriteLine($"Analytics updated for payment ${payment.Amount}");
        }
    }
}