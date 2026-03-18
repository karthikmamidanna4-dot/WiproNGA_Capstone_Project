using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;
using CustomerSupportAPI.Data;

namespace CustomerSupportAPI.Repositories
{
    public class AgentRepository : IAgentRepository
    {
        private readonly AppDbContext _context;

        public AgentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return _context.Agents.ToList();
        }

        public void AddAgent(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
        }
    }
}