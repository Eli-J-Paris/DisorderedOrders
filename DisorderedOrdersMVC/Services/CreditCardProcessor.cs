﻿namespace DisorderedOrdersMVC.Services
{
    public class CreditCardProcessor : IProcessPayment, IProcessRefund
    {
        public bool ProcessPayment(int amount)
        {
            // payment processing.  This would typically use a third party service like Stripe.
            
            return true;
        }

        public bool ProcessRefund(int amount)
        {
            // refund processing.  This would typically use a third party service like Stripe.

            return true;
        }
    }
}
