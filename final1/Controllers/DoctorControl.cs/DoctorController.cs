using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class Doctor_Controller : Controller
{
    private readonly AppContext _context;
    public Doctor_Controller(AppContext context)
    {
        _Context = context;
    }

    public IActionResult Index()
    {
        var Doctors = _context.doctors.ToList();
        return View(Doctors);

    }
}