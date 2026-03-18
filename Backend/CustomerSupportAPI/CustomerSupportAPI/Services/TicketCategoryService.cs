using CustomerSupportAPI.Interfaces;
using CustomerSupportAPI.Models;

namespace CustomerSupportAPI.Services
{
    public class TicketCategoryService
    {
        private readonly ITicketCategoryRepository _repository;

        public TicketCategoryService(ITicketCategoryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TicketCategory> GetCategories()
        {
            return _repository.GetAllCategories();
        }

        public void CreateCategory(TicketCategory category)
        {
            _repository.AddCategory(category);
        }
    }
}