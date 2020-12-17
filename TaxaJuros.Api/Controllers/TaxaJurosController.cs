using App.Domain.Commands.Handlers;
using App.Domain.Commands.Inputs;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class TaxaJurosController: BaseController
    {
        private readonly TaxaJurosCommandHandler _handler;

        public TaxaJurosController(TaxaJurosCommandHandler handler) 
            : base()
        {
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/TaxaJuros")]
        public async Task<IActionResult> Get(TaxaJurosCommand command)
        {
            var data = _handler.Handle(command);
            if (data != null)
                return await Response(data);

            return await Response(data);
        }

    }
}
