using System;
using System.Collections.Generic;
using System.Text;
using Customers.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customers.DataAccess
{
    public class CustomersContext : DbContext
    {
        public CustomersContext(DbContextOptions<CustomersContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}
