using System;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class Membership
    {
        [Key]
        public int IdMembership { get; set; }

        public string Type { get; set; }

        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }



    }
}