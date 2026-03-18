namespace CustomerSupportAPI.Models
{
    public class Agent
    {
        public int AgentID { get; set; }

        public string AgentName { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

        public bool IsActive { get; set; }
    }
}
