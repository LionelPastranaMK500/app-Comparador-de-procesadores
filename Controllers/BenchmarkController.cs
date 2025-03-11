using app_Comparador_de_procesadores.Models;
using Microsoft.AspNetCore.Mvc;

namespace app_Comparador_de_procesadores.Controllers
{
    public class BenchmarkController : Controller
    {
        private CRUD_Benchmark crud = new CRUD_Benchmark();

        public IActionResult Index()
        {
            List<Benchmark> benchmarks = crud.ObtenerBenchmarks();
            return View(benchmarks);
        }
    }
}
