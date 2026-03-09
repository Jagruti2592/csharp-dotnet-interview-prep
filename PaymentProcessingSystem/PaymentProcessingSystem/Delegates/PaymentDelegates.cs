using System;
using PaymentProcessingSystem.Models;

namespace PaymentProcessingSystem.Delegates
{
    public class PaymentDelegates
{
        public delegate void PaymentHandler(PaymentRequest payment);
}
