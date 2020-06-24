﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIpart1.Model
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        public string firstName { get; set; }
        
        [Required]
        public string lastName { get; set; }
        
        [Required]
        public DateTime birthday { get; set; }
        
        public List<Book> Books { get; set; }
    }
}
