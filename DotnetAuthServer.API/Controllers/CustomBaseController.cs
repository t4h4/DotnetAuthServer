using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetAuthServer.API.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public IActionResult ActionResultInstance <T> (Response<T> response) where T : class // generic T alsin.
        {
            return new ObjectResult(response) // return status code
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
