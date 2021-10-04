using System.ComponentModel.DataAnnotations;

namespace TP4.EF.API.Models
{
    public class CustomersView
    {
        [Required]
        [StringLength(5)]
        public string Id { get; set; }
        public string ContactName { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required]
        [StringLength(40)]
        public string CompanyName { get; set; }
    }
}