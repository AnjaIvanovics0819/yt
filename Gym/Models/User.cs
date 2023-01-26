using System;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}