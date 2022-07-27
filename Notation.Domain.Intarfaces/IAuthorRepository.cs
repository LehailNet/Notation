using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface IAuthorRepository
    {
        Task CreateAuthorAsync(Author author);

        Task<Author> GetAuthor(int id);

        Task UpdateAuthorAsync(Author author);

        Task DeleteAuthorAsync(int id);

        Task<IEnumerable<Author>> GetAuthors();

    }
}
