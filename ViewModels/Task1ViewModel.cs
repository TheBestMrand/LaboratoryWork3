using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class Task1ViewModel
    {
        //This can be simplified I think
        private readonly ResidentService _residentService;

        public Task1ViewModel(ResidentService residentService)
        {
            _residentService = residentService;
        }
        //Fix this method it is awfull and not readable
        public async Task<(decimal averageGasBill, List<Resident> residents)>
            GetAverageGasBillAndResidentsForStreetAsync(string street)
        {
            var totalGasBill = 0.0m;
            var gasPaymentsCount = 0;
            var targetResidents = new List<Resident>();

            var residents = await _residentService.GetResidentsAsync();

            foreach (var resident in residents)
            {
                if (resident.Address.Contains(street))
                {
                    targetResidents.Add(resident);

                    foreach (var payment in resident.Payments)
                    {
                        if (payment.ServiceType == ServiceType.Gas && payment.Date.Month == DateTime.Now.Month)
                        {
                            totalGasBill += payment.Amount;
                            gasPaymentsCount++;
                        }
                    }
                }
            }

            var averageGasBill = gasPaymentsCount > 0 ? totalGasBill / gasPaymentsCount : 0;
            return (averageGasBill, targetResidents);
        }
    }
}
