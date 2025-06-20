using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8sfirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            return "luozhonglin";
        }

        [HttpGet]
        public string GetName2()
        {
            return "luozhonglin2";
        }
    }
}
