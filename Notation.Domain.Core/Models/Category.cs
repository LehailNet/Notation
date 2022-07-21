﻿using MongoDB.Bson;
using System.Collections.Generic;

namespace Notation.Domain.Core.Models
{
    public class Category
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; }
    }
}
