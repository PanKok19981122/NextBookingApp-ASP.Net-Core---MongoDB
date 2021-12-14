using System;
namespace NextLevelTrainingApi.ViewModels
{
    public class BuyCreditsViewModel
    {
        public int Credits { get; set; }
        public decimal AmountPaid { get; set; }

        public string PaypalPaymentId { get; set; }
    }
}
