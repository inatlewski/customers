using System.Collections.Generic;
using System.Threading.Tasks;
using Customers.Models.DTO;
using Customers.Models.Entities;

namespace Customers.BusinessLogic.Interfaces
{
    public interface INoteService
    {
        Task<ResponseDto<IEnumerable<Note>>> GetNotesForCustomer(int customerId);
    }
}