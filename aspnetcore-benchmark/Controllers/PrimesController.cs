using aspnetcore.benchmark.Core;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.benchmark.Controllers
{
    public class PrimesController : Controller
    {
        private readonly ICheckPrimes _primesChecker;

        public PrimesController(ICheckPrimes primesChecker)
        {
            _primesChecker = primesChecker;
        }

        [HttpGet("primes/random")]
        public JsonResult Primes()
        {
            Response.ContentType = "application/json";
            return Json(_primesChecker.Check());
        }

        [HttpGet("primes/find")]
        public JsonResult Generate() {
            Response.ContentType = "application/json";
            return Json(_primesChecker.Prime());
        }
    }
}

