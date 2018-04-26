using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Customers.BusinessLogic.Interfaces;
using Customers.Models.DTO;
using Customers.Models.Entities;

namespace Customers.BusinessLogic.Implementations
{
    public class NoteService : INoteService
    {
        public Task<ResponseDto<IEnumerable<Note>>> GetNotesForCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
