using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace k8sfirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public TestController(IHttpContextAccessor httpContextAccessor)
        {

            _httpContextAccessor = httpContextAccessor;
        }



        [HttpGet]
        [HttpHead]
        public string GetName()
        {

            var result = "luozhonglin,恭喜你，第一个K8S集群发布成功了！！！";

            var headers = Request.Headers;

            var s = HttpContext.Request.Path;

            var client = new HttpClient();
            var response = client.GetAsync(HttpContext.Request.Host+HttpContext.Request.Path).GetAwaiter();
            return Newtonsoft.Json.JsonConvert.SerializeObject(response);


            if (headers.TryGetValue("X-Upstream-Addr", out var userAgent))
            { 
               result += $"当前请求的负载地址：{userAgent}";
            }
            return result;
        }

        [HttpGet]
        public string GetName2()
        {
            return "luozhonglin2";
        }
    }
}
