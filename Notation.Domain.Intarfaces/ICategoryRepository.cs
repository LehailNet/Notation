using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface ICategoryRepository
    {
        Task CreateCategory(Category category);

        Category GetCategory(int id);

        void UpdateCategory(Category category);

        void DeleteCategory(int id);

        IEnumerable<Category> GetCategories();
    }
}
