using TechGab.API.Models.Domain;

namespace TechGab.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
