using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MicroApp2.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        public IActionResult GetInvoices()
        {
            var userName = HttpContext.User.Identity.Name;

            var userId = User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

            

            return Ok($" Invoice işlemleri  =>  UserName: {userName} - UserId: {userId} ");
        }
    }
}
