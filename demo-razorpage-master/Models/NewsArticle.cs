using System;
using System.ComponentModel.DataAnnotations;

namespace NewsWebsite.Models
{
    public class NewsArticle
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public required string Title { get; set; }

        [Required]
        public required string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}