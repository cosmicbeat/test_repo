﻿namespace Phoenix.Models
{
    using System.ComponentModel.DataAnnotations;

    public class UserLanguage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
