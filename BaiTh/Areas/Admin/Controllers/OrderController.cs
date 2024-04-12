using BaiTh.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BaiTh.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderRepositorycs _orderRepositorycs;

        public OrderController(IOrderRepositorycs orderRepositorycs)
        {
            _orderRepositorycs = orderRepositorycs;
           
        }
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepositorycs.GetAllAsync();
            return View(orders);
        }
        public async Task<IActionResult> Display(int id)
        {
            var orders = await _orderRepositorycs.GetByIdAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }
    }
}
