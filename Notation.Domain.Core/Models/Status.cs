using Notation.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Notation.Domain.Core.Statuses
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; }
    }
}
