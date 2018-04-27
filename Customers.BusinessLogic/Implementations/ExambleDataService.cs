using System.Threading.Tasks;
using Customers.BusinessLogic.Interfaces;
using Customers.DataAccess;
using Customers.Models.Entities;
using Customers.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Customers.BusinessLogic.Implementations
{
    public class ExambleDataService : IExampleDataService
    {
        private readonly CustomersContext _dbContext;

        public ExambleDataService(CustomersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ResetData()
        {
            var notes = await _dbContext.Notes.ToListAsync();
            _dbContext.RemoveRange(notes);

            var customers = await _dbContext.Customers.ToListAsync();
            _dbContext.RemoveRange(customers);

            await _dbContext.SaveChangesAsync();

            for (int i = 1; i <= 10; i++)
            {
                var newCustomer = new Customer
                {
                    FirstName = $"First Name {i}",
                    LastName = $"Last Name {i}",
                    City = $"City {i}",
                    Country = $"Country {i}",
                    Street = $"Street {i}",
                    Status = CustomerStatus.Current
                };

                for (int j = 1; j <= 3; j++)
                {
                    var newNote = new Note
                    {
                        Content = $"Content {j}"
                    };

                    newCustomer.Notes.Add(newNote);
                }

                _dbContext.Add(newCustomer);
            }

            await _dbContext.SaveChangesAsync();
        }
    }
}
