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
}