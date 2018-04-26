using System.Collections.Generic;
using System.Threading.Tasks;
using Customers.Models.DTO;
using Customers.Models.Entities;
using Customers.Models.Enums;

namespace Customers.BusinessLogic.Interfaces
{
    public interface ICustomerService
    {
        Task<ResponseDto<IEnumerable<Customer>>> GetAll();

        Task<ResponseDto<Customer>> GetCustomer(int customerId);

        Task<ResponseDto<Customer>> SetCustomerStatus(int customerId, CustomerStatus customerStatus);
    }
}