using System.Diagnostics;
using LigaPro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LigaPro.Data; // Asegúrate de tener la referencia a tu contexto de base de datos.

namespace LigaPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LigaProContext _context; // Contexto de la base de datos

        // Constructor
        public HomeController(ILogger<HomeController> logger, LigaProContext context)
        {
            _logger = logger;
            _context = context;
        }

        // Acción Index que pasa los datos de equipos y jugadores goleadores
        public async Task<IActionResult> Index()
        {
            var equipos = await _context.Equipo.ToListAsync();
            var jugadoresGoleadores = await _context.Jugador
                .OrderByDescending(j => j.Goles)
                .Take(10) // Cambia el número según lo que necesites
                .ToListAsync();

            var modelo = new
            {
                Equipos = equipos,
                JugadoresGoleadores = jugadoresGoleadores
            };

            return View(modelo); // Pasamos los datos a la vista
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
