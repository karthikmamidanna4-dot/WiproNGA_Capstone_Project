using System.ComponentModel.DataAnnotations;
namespace CustomerSupportAPI.Models
{
    public class Ticket
    {
        [Key]
        public int TicketID { get; set; }

        public int CustomerID { get; set; }

        public int AgentID { get; set; }

        public int CategoryID { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? ResolvedDate { get; set; }
    }
}
