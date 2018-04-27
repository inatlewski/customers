using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Customers.Models.Enums;

namespace Customers.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public CustomerStatus Status { get; set; }

        [IgnoreDataMember]
        public ICollection<Note> Notes { get; set; }

        public Customer()
        {
            Notes = new List<Note>();
        }
    }
}
