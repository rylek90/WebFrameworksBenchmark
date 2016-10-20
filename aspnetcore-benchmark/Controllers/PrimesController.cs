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
        public JsonResult Random()
        {
            Response.ContentType = "application/json";
            return Json(_primesChecker.Random());
        }

        [HttpGet("primes/find")]
        public JsonResult Find() {
            Response.ContentType = "application/json";
            return Json(_primesChecker.Find());
        }
    }
}

