﻿using BookApiProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookApiProject
{
    public class Book
    {
        [Key] // primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // generate Id automatically
        public int Id { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "ISBN must be between 3 and 10 characters")]
        public string Isbn { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Title can't be more than 200 characters")]
        public string Title { get; set; }
        public DateTime? DatePublished { get; set; } // nullable e.g) DateTime?
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
        public virtual ICollection<BookCategory> BookCategories { get; set; }

    }
}
