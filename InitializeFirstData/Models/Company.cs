﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializeFirstData.Models
{
    internal class Company
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public List<User> Users { get; set; } = new();

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}";
        }
    }
}
