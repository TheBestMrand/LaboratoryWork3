using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryWork3.Models.Data
{
    public class Payment
    {
        public int Id { get; set; }
        [ForeignKey("ResidentId")]
        public int ResidentId { get; set; }
        public ServiceType ServiceType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
