using System.Collections.Generic;
using System.Net;
using Customers.BusinessLogic.Interfaces;
using Customers.Models.DTO;
using Customers.Models.Entities;
using Customers.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Web.Controllers
{
    [Route("api/[controller]")]
    [ProducesResponseType((int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly INoteService _noteService;
        
        public CustomerController(ICustomerService customerService, INoteService noteService)
        {
            _customerService = customerService;
            _noteService = noteService;
        }

        [HttpGet("all")]
        [Produces(typeof(ResponseDto<IEnumerable<Customer>>))]
        public IActionResult GetAll()
        {
            var customersDto = _customerService.GetAll();

            return Ok(customersDto);
        }

        [HttpGet("{customerId}")]
        [Produces(typeof(ResponseDto<Customer>))]
        public IActionResult GetCustomer(int customerId)
        {
            var customerDto = _customerService.GetCustomer(customerId);

            return Ok(customerDto);
        }

        [HttpPatch("{customerId}/status")]
        [Produces(typeof(ResponseDto<Customer>))]
        public IActionResult SetCustomerStatus(int customerId, CustomerStatus customerStatus)
        {
            var customerDto = _customerService.SetCustomerStatus(customerId, customerStatus);

            return Ok(customerDto);
        }

        [HttpGet("{customerId}/notes")]
        [Produces(typeof(ResponseDto<IEnumerable<Note>>))]
        public IActionResult GetCustomerNotes(int customerId)
        {
            var notesDto = _noteService.GetNotesForCustomer(customerId);

            return Ok(notesDto);
        }
    }
}