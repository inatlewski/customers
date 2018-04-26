using System.Collections.Generic;
using Customers.BusinessLogic.Interfaces;
using Customers.Models.DTO;
using Customers.Models.Entities;
using Customers.Models.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Customers.Web.Controllers
{
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("All")]
        [Produces(typeof(ResponseDto<IEnumerable<Customer>>))]
        public IActionResult GetAll()
        {
            var customersDto = _customerService.GetAll();

            return Ok(customersDto);
        }

        [HttpGet("{id}")]
        [Produces(typeof(ResponseDto<Customer>))]
        public IActionResult GetCustomer(int customerId)
        {
            var customerDto = _customerService.GetCustomer(customerId);

            return Ok(customerDto);
        }

        [HttpPatch("{id}/Status")]
        [Produces(typeof(ResponseDto<Customer>))]
        public IActionResult SetCustomerStatus(int customerId, CustomerStatus customerStatus)
        {
            var customerDto = _customerService.SetCustomerStatus(customerId, customerStatus);

            return Ok(customerDto);
        }
    }
}