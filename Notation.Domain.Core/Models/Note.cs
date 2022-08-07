using Notation.Domain.Core.Enums;
using Notation.Domain.Core.Models.Base;
using System;

namespace Notation.Domain.Core.Models
{
    public class Note : BaseEntity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        public NoteType NoteType { get; set; }
        public Status Status { get; set; }
        public DateTime TimeCreate { get; set; }
    }
}