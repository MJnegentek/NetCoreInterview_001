using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using TestNexsus.Services.Legacy;

namespace TestNexsus.Controllers
{
    [EnableCors("MyPolicy")]
    //[AllowAnonymous]
    [Route("[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        private readonly ITestBusiness_cls objBiz;

        public TestController(ITestBusiness_cls _objBiz)
        {
            objBiz = _objBiz;
        }

        [EnableCors("MyPolicy")]
        [AllowAnonymous]
        [HttpGet("getTestlist")]        
        public IActionResult getList(int cmp, int st)
        {

            if (cmp > 0 && st > 0)
            {
                var vReturn = objBiz.getDetailByStation(cmp, st);
                return Ok(vReturn);
            }
            else return BadRequest();

        }

        
    }
}
