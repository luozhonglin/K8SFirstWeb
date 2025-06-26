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

            var result = "luozhonglin,恭喜你，第一个K8S集群发布成功了！";

            var headers = HttpContext.Request.Headers;
            if (headers.TryGetValue("x-upstream-addr", out var userAgent))
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
