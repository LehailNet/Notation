using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Notation.Domain.Intarfaces
{
    public interface IAuthorRepository
    {
        Task CreateAuthor(Author author);

        Author GetAuthor(int id);

        void UpdateAuthor(Author author);

        void DeleteAuthor(int id);

        IEnumerable<Author> GetAuthors();
    }
}
