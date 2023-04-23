using LaboratoryWork3.Models.Data;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWork3.Models.Services
{
    public class PaymentService
    {
        private readonly AppDbContext _context;

        private readonly string _pattern = @"(?<=\d+\s)[a-zA-Z\s]+";

        public PaymentService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<(decimal averageGasBill, List<Resident> residents)>
            GetAverageGasBillAndResidentsForStreetAsync(string street, List<Resident> residentsToCheck)
        {
            var totalGasBill = 0.0m;
            var gasPaymentsCount = 0;
            var targetResidents = new List<Resident>();
            var targetResidentsById = new Dictionary<int, Resident>();
            string lowerCaseStreet = street.ToLower();

            var residents = residentsToCheck;
            var payments = new List<Payment>();

            foreach (Payment payment in _context.Payments)
            {
                if (payment.ServiceType == ServiceType.Gas)
                {
                    payments.Add(payment);
                }
            }

            foreach (var resident in residents)
            {
                var address = Regex.Match(resident.Address.Trim(), _pattern);
                var addressValue = address.Value.ToLower();
                if (addressValue.Equals(lowerCaseStreet))
                {
                    targetResidents.Add(resident);
                    targetResidentsById.Add(resident.Id, resident);
                }
            }

            foreach (var payment in payments)
            {
                if (targetResidentsById.ContainsKey(payment.ResidentId) &&
                    payment.ServiceType == ServiceType.Gas && payment.Date.Month == DateTime.Now.Month)
                {
                    totalGasBill += payment.Amount;
                    gasPaymentsCount++;
                }
            }

            var averageGasBill = gasPaymentsCount > 0 ? totalGasBill / gasPaymentsCount : 0;
            return (averageGasBill, targetResidents);
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _context.Payments.ToListAsync();
        }

        public async Task<Dictionary<ServiceType, decimal>> GetTotalAmountsForServices()
        {
            DateTime currentQuarterStart = new DateTime(DateTime.Now.Year, ((DateTime.Now.Month - 1) / 3) * 3 + 1, 1);
            DateTime lastQuarterStart = currentQuarterStart.AddMonths(-3);

            Dictionary<ServiceType, decimal> totalAmounts = new Dictionary<ServiceType, decimal>();

            foreach (Payment payment in _context.Payments)
            {
                if (payment.Date >= lastQuarterStart && payment.Date < currentQuarterStart)
                {
                    if (!totalAmounts.ContainsKey(payment.ServiceType))
                    {
                        totalAmounts[payment.ServiceType] = 0;
                    }

                    totalAmounts[payment.ServiceType] += payment.Amount;
                }
            }

            return totalAmounts;

        }

        public async Task<(ServiceType, decimal)> GetMaxTotalAmountForService()
        {
            Dictionary<ServiceType, decimal> totalAmounts = await GetTotalAmountsForServices();
            ServiceType maxServiceType = ServiceType.Gas;
            decimal maxAmount = 0;
            foreach (KeyValuePair<ServiceType, decimal> pair in totalAmounts)
            {
                if (pair.Value > maxAmount)
                {
                    maxAmount = pair.Value;
                    maxServiceType = pair.Key;
                }
            }
            return (maxServiceType, maxAmount);
        }
    }
}
