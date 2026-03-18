using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Interfaces
{
    public interface IAgentRepository
    {
        IEnumerable<Agent> GetAllAgents();
        void AddAgent(Agent agent);
    }
}