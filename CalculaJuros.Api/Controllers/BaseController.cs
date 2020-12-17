using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class BaseController: Controller
    {
        public BaseController()
        {
        }

        public async Task<IActionResult> Response(object result)
        {
            try
            {

                return Ok(new
                {
                    success = true,
                    data = result
                });
            }
            catch (Exception e)
            {
                // Logar o erro ()
                return BadRequest(new
                {
                    success = false,
                    errors = new[] { "Ocorreu uma falha interna no servidor." + e.InnerException.Message }
                });
            }
        }



    }
}
