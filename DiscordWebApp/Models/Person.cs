﻿using System.ComponentModel.DataAnnotations;

namespace DiscordWebApp.Models
{
    public class Person
    {

        [Key]

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

    }
}
