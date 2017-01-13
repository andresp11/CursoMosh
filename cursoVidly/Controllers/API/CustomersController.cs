using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using cursoVidly.Models;
using cursoVidly.DTOS;
using AutoMapper;

namespace cursoVidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /API/CUSTOMERS
        public IHttpActionResult GetCustomers()
        {
            var customerDTO =   _context.Customer.Include(c=>c.MembershipType).
                                ToList().
                                Select(Mapper.Map<Customers,CustomerDTO>);
            return Ok(customerDTO);
        }

        //Get /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customer == null )
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Customers, CustomerDTO>(customer));
        }
        // post /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var customer = Mapper.Map<CustomerDTO, Customers>(customerDto);
            _context.Customer.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;
            return Created(new Uri(Request.RequestUri +"/"+ customer.Id),customerDto);
        }

        [HttpPut]
        //Put /api/customers/1
        public void UpdateCustomer(int id, CustomerDTO customerDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var customerInDb = _context.Customer.SingleOrDefault(c=> c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map(customerDto, customerInDb);
            

            _context.SaveChanges();

        }

        [HttpDelete]
        //Delete /api/customers/1
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Customer.Remove(customerInDb);
            _context.SaveChanges();
        }
    }

}
