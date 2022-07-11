using System;
using System.Collections.Generic;
using System.Text;

namespace Notation.Domain.Core.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public int TypeNoteId { get; set; }
        public int StatusId { get; set; }
        public DateTime TimeCreate { get; set; }
    }
}
