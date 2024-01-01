using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class Patient_Controller : Controller
{
    private readonly AppContext _context;
    public Patient_Controller (AppContext context)
    {
        _Context = context;
    }

    public IActionResult Index()
    {
        var patients = _context.Patients.ToList();
        return View(patients);

    }
}