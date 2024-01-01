using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class Receptionist_Controller : Controller
{
    private readonly AppContext _context;
    public Receptionist_Controller(AppContext context)
    {
        _Context = context;
    }

    public IActionResult Index()
    {
        var Receptionist = _context.Receptionist.ToList();
        return View(Receptionist);

    }
}