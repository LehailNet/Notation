using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface ICategoryRepository
    {
        Task CreateCategoryAsync(Category category);

        Task<Category> GetCategory(int id);

        Task UpdateCategoryAsync(Category category);

        Task DeleteCategoryAsync(int id);

        Task<IEnumerable<Category>> GetCategories();

    }
}
