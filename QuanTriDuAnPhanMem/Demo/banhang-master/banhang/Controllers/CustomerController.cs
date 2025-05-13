using System.Linq;
using Microsoft.AspNetCore.Mvc;
using banhang.Models;
using banhang.Repository;


namespace banhang.Controllers
{
    public class CustomerController : Controller
    {
        private readonly DataContext _context;

        public CustomerController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            var totalCustomers = _context.Customers.Count(); 
            var customers = _context.Customers
                .OrderBy(c => c.CustomerName)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.TotalPages = (int)Math.Ceiling((double)totalCustomers / pageSize);
            ViewBag.CurrentPage = page;
            ViewBag.PageSize = pageSize;

            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }


        public IActionResult Details(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return Ok(new { message = "Xóa thành công!" });
        }
        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var existingCustomer = _context.Customers.FirstOrDefault(c => c.CustomerId == id);
                if (existingCustomer == null)
                {
                    return NotFound();
                }

                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.CustomerEmail = customer.CustomerEmail;
                existingCustomer.CustomerPhone = customer.CustomerPhone;
                existingCustomer.CustomerAddress = customer.CustomerAddress;

                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(customer);
        }

    }
}
