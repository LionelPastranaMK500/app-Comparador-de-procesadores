using app_Comparador_de_procesadores.data;
using Microsoft.AspNetCore.Mvc;

namespace app_Comparador_de_procesadores.Controllers
{
    public class ProcesadorController : Controller
    {
        private CRUD_Procesador crud = new CRUD_Procesador();

        public IActionResult Index()
        {
            var procesadores = crud.ObtenerProcesadores();
            Console.WriteLine($"Procesadores obtenidos: {procesadores.Count}");

            foreach (var p in procesadores)
            {
                Console.WriteLine($"Procesador: {p.Nombre}, {p.Marca}");
            }

            return View(procesadores); 
        }
    }
}
