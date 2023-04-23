using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class Task2ViewModel
    {
        private readonly PaymentService _paymentService;

        public Dictionary<ServiceType, decimal> ServiceAmounts { get; set; } = new Dictionary<ServiceType, decimal>();
        public decimal MaxAmountForService { get; set; }
        public ServiceType MaxAmountServiceType { get; set; }

        public Task2ViewModel(PaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public async Task LoadPaymentsAsync()
        {
            ServiceAmounts = await _paymentService.GetTotalAmountsForServices();
            (MaxAmountServiceType, MaxAmountForService) = await _paymentService.GetMaxTotalAmountForService();
        }
    }
}
