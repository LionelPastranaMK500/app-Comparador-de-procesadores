using app_Comparador_de_procesadores.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_Comparador_de_procesadores.Controllers
{
    public class Sp2Controller : Controller
    {
        private CRUD_spPuntajedeProcesadores crud = new CRUD_spPuntajedeProcesadores();

        public IActionResult Index()
        {
            var puntaje = crud.ObtenerPuntajeProcesadores();
            Console.WriteLine($"Puntajes obtenidos: {puntaje.Count}");
            return View(puntaje);
        }
    }
}
