using System.Collections.Generic;
using System.Threading.Tasks;
using Customers.BusinessLogic.Interfaces;
using Customers.DataAccess;
using Customers.Models.DTO;
using Customers.Models.Entities;
using Customers.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Customers.BusinessLogic.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomersContext _dbContext;

        public CustomerService(CustomersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseDto<IEnumerable<Customer>>> GetAll()
        {
            var customers = await _dbContext.Customers.ToListAsync();
            var responseDto = new ResponseDto<IEnumerable<Customer>>(customers);

            return responseDto;
        }

        public async Task<ResponseDto<Customer>> GetCustomer(int customerId)
        {
            var customer = await _dbContext.Customers.FindAsync(customerId);
            var responseDto = new ResponseDto<Customer>(customer);

            return responseDto;
        }

        public async Task<ResponseDto<Customer>> SetCustomerStatus(int customerId, CustomerStatus customerStatus)
        {
            var customer = await _dbContext.Customers.FindAsync(customerId);

            if (customer == null)
            {
                var errorDto = new ErrorDto("The customer was not found.");
                var errorResponse = new ResponseDto<Customer>(errorDto);

                return errorResponse;
            }

            customer.Status = customerStatus;
            await _dbContext.SaveChangesAsync();

            var responseDto = new ResponseDto<Customer>(customer);

            return responseDto;
        }
    }
}