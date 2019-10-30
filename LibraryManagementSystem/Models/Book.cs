﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

    }
}
