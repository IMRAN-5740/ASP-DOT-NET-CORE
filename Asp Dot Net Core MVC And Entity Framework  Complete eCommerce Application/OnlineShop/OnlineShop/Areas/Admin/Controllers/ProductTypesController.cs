using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductTypesController : Controller
    {
        ApplicationDbContext _context;
        public ProductTypesController(ApplicationDbContext context)
            {
            _context=context;
            }
        public IActionResult Index()
        {
            var data=_context.ProductTypes.ToList();
            return View(data);
        }

        //Create Get Action Method
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductTypes productTypes)
        {
            if(ModelState.IsValid)
            {
                _context.ProductTypes.Add(productTypes);
                await _context.SaveChangesAsync();
                TempData["add"] = "New Product Type Added Successfully";
                return RedirectToAction("Index");//nameof(Index) eta dite parbo chaile
            }
            return View(productTypes);
        }


        //Edit Get Action Method
        [HttpGet]
        public ActionResult Edit(int?id)
        {
            if(id == null)
            {
                return NotFound();
            }
           var productType=_context.ProductTypes.Find(id);
            if(productType==null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProductTypes productTypes)
        {
            if(ModelState.IsValid)
            {
                _context.ProductTypes.Update(productTypes);
                await _context.SaveChangesAsync();
                TempData["edit"] = "Product Typ eUpdated Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }


        //Details Get Action Method
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _context.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Details(ProductTypes productTypes)
        {
            return RedirectToAction(nameof(Index));
            
        }

        //Delete Action Method
        [HttpGet]
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var productType = _context.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Delete Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int? id,ProductTypes productTypes)
        {
            if(id==null)
            {
                return NotFound();
            }
            if(id!=productTypes.Id)
            {
                return NotFound();
            }
            var productType = _context.ProductTypes.Find(id);
            if(productType==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Remove(productType);
                await _context.SaveChangesAsync();
                TempData["done"] = "Product Type Deleted Successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(productTypes);
        }
    }
}
