using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ArtificialPlayground.Data;
using ArtificialPlayground.Models;

namespace ArtificialPlayground.Controllers; 

public class ToyController : Controller {
    private readonly ApplicationDbContext _context;
    
    public ToyController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IActionResult> Index()
    {
        return View(await _context.Toys.ToListAsync());
    }
    
    // GET: Toys/Details/5
    // public async Task<IActionResult> Details(int? id)
    // {
    //     if (id == null)
    //     {
    //         return NotFound();
    //     }
    //
    //     var toy = await _context.Toys.FirstOrDefaultAsync(m => m.Id == id);
    //     if (toy == null)
    //     {
    //         return NotFound();
    //     }
    //     
    //     return View(toy);
    // }
}