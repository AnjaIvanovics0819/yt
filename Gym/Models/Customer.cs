using System;
using System.ComponentModel.DataAnnotations;

namespace Gym.Models
{
    public class Customer
    {

        [Key]
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int IdMembership { get; set; }

    }
}