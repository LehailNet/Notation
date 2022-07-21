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

        Category GetCategory(int id);

        Task UpdateCategoryAsync(Category category);

        Task DeleteCategoryAsync(int id);

        IEnumerable<Category> GetCategories();

    }
}
