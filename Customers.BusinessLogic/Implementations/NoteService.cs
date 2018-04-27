using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customers.BusinessLogic.Interfaces;
using Customers.DataAccess;
using Customers.Models.DTO;
using Customers.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Customers.BusinessLogic.Implementations
{
    public class NoteService : INoteService
    {
        private readonly CustomersContext _dbContext;

        public NoteService(CustomersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ResponseDto<IEnumerable<Note>>> GetNotesForCustomer(int customerId)
        {
            var notes = await _dbContext.Notes
                .Where(x => x.CustomerId == customerId)
                .ToListAsync();

            var responseDto = new ResponseDto<IEnumerable<Note>>(notes);

            return responseDto;
        }
    }
}
