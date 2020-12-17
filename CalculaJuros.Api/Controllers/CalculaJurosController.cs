using App.Domain.Commands.Handlers;
using App.Domain.Commands.Inputs;
using App.Domain.Entities;
using App.Shared.ApiManager;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Api.Controllers
{
    public class CalculaJurosController: BaseController
    {
        private readonly CalculaJurosCommandHandler _handler;

        public CalculaJurosController(CalculaJurosCommandHandler handler) 
            : base()
        {
            _handler = handler;
        }

        [HttpPost]
        [Route("v1/CalculaJuros")]
        public async Task<IActionResult> Post([FromBody] CalculaJurosCommand command)
        {
            var taxaJuros = ObtemTaxaJuros().Result;

            command.Juros = taxaJuros.ValorTaxaJuros;

            var data = _handler.Handle(command);
            if (data != null)
                return await Response(data);

            return await Response(data);
        }

        [HttpGet]
        [Route("v1/ShowMeCode")]
        public async Task<IActionResult> Get()
        {
            return await Response("");
        }

        //O Ideal seria isso estar em outra classe de serviço, mas, preferi para este exemplo deixar aqui mesmo.
        public async Task<TaxaJuro> ObtemTaxaJuros()
        {
            var action = $"{ApiManager.GetKey("urlapi")}v1/TaxaJuros/";
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, action);

            HttpResponseMessage response = await HttpInstance.GetHttpClientInstance().SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var jsonResult = JObject.Parse(response.Content.ReadAsStringAsync().Result)["data"];
                var result = JsonConvert.DeserializeObject<TaxaJuro> (jsonResult.ToString());
                return result;
            }

            return null;
        }
    }
}
