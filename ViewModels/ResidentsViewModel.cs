using LaboratoryWork3.Models.Data;
using LaboratoryWork3.Models.Services;

namespace LaboratoryWork3.ViewModels
{
    public class ResidentsViewModel
    {
        public List<Resident> Residents { get; set; }

        private readonly ResidentService _residentService;

        public ResidentsViewModel(ResidentService residentService)
        {
            _residentService = residentService;
        }

        public async Task LoadResidentsAsync()
        {
            Residents = await _residentService.GetResidentsAsync();
        }
    }
}
