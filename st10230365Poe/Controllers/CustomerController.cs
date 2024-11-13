using Microsoft.AspNetCore.Mvc;
using st10230365Poe.Data;
using st10230365Poe.Models;

namespace st10230365Poe.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            customer.RowKey = Guid.NewGuid().ToString();
            customer.DateCreated = DateTime.UtcNow;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Customer"); // Ensures redirect to Customer/Index
        }


    }
}
