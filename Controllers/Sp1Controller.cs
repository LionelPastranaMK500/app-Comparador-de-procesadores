using app_Comparador_de_procesadores.data;
using Microsoft.AspNetCore.Mvc;

namespace app_Comparador_de_procesadores.Controllers
{
    public class Sp1Controller : Controller
    {
        private CRUD_spComparacionProcesadores crud = new CRUD_spComparacionProcesadores();

        public IActionResult Index()
        {
            var comparacion = crud.ObtenerComparacionProcesadores();
            Console.WriteLine($"Comparaciones obtenidos: {comparacion.Count}");
            return View(comparacion);
        }
    }
}
