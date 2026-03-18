using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Services
{
    public class AgentService
    {
        private readonly IAgentRepository _repository;

        public AgentService(IAgentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Agent> GetAgents()
        {
            return _repository.GetAllAgents();
        }

        public void CreateAgent(Agent agent)
        {
            _repository.AddAgent(agent);
        }
    }
}