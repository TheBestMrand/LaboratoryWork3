using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class Task1ViewModel
    {
        public decimal AverageGasBill { get; set; }
        public List<Resident> Residents { get; set; } = new List<Resident>();

        private readonly ResidentService _residentService;
        private readonly PaymentService _paymentService;

        public Task1ViewModel(ResidentService residentService, PaymentService paymentService)
        {
            _residentService = residentService;
            _paymentService = paymentService;
        }

        public async Task LoadResidentsAsync(string street)
        {
            var _residentsForPaymentCheck = await _residentService.GetResidentsAsync();
            (AverageGasBill, Residents) = await _paymentService.GetAverageGasBillAndResidentsForStreetAsync(street, _residentsForPaymentCheck);
        }
    }
}
