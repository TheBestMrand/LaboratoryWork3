using System.Collections;

namespace LaboratoryWork3.Models.Data
{
    public class Resident
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}
