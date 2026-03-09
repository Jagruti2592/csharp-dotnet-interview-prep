using PaymentProcessingSystem.Models;
using PaymentProcessingSystem.Services;

namespace PaymentProcessingSystem.Application
{
    public class DemoRunner
    {
        public void Run()
        {
            PaymentService paymentService = new PaymentService();

            EmailService emailService = new EmailService();
            AuditService auditService = new AuditService();
            AnalyticsService analyticsService = new AnalyticsService();

            paymentService.PaymentProcessed += emailService.SendReceipt;
            paymentService.PaymentProcessed += auditService.LogTransaction;
            paymentService.PaymentProcessed += analyticsService.TrackPayment;

            PaymentRequest payment = new PaymentRequest
            {
                OrderId = 1001,
                Amount = 250,
                CustomerEmail = "customer@email.com"
            };

            paymentService.ProcessPayment(payment);
        }
    }
}
