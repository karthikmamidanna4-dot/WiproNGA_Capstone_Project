using System.ComponentModel.DataAnnotations;

namespace CustomerSupportAPI.Models
{
    public class TicketCategory
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }
    }
}