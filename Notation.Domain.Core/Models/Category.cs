using Notation.Domain.Core.Models.Base;
using System.Collections.Generic;

namespace Notation.Domain.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Note> Notes { get; set; }
    }
}
