using DependencyInjectionMultipleImplementationsCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInjectionMultipleImplementationsCore.Controllers
{
    [Route("home")]
    public class HomeController : Controller
    {

        private IEnumerable<CrudRepository> crudRepositroies;
        public HomeController(IEnumerable<CrudRepository> _crudRepositories)
        {
            crudRepositroies = _crudRepositories;
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            var crudRepository = crudRepositroies.SingleOrDefault(s => s.GetType() == typeof
            (CrudRepositoryMongoDB));
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            return View();
        }
        [Route("index2")]
        public IActionResult Index2()
        {
            var crudRepository = crudRepositroies.SingleOrDefault(s => s.GetType() == typeof
            (CrudRepositoryMySQL));
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            return View("Index");
        }
        [Route("index3")]
        public IActionResult Index3()
        {
            var crudRepository = crudRepositroies.SingleOrDefault(s => s.GetType() == typeof
            (CrudRepositorySqlServer));
            crudRepository.Create();
            crudRepository.Delete();
            crudRepository.Update();
            return View("Index");
        }

        
    }
}
