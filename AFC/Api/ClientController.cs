using AFC.Application.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFC.Api
{
    [ApiController]
    [Route("api/client")]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator; 
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAllClient()
        {
            return Ok(_mediator.Send(new ClientReadAllModel() ));
        }
        [HttpGet("{id}")]
        public async Task< string> GetClient(int id)
        {
            //скорее всего это не правильно и можно обойтись без создания модели просто id мб передавать только id  а остальное делать в методе handle handlera
            var client = await _mediator.Send(new ClientReadModel { Id = id });
            var response = JObject.FromObject(client).ToString();
           
            return response;

            //return Ok(_mediator.Send(new ClientReadModel { Id = id }));
        }
        [HttpPost]
        public string PostClient(ClientCreateModel createClient)
        {
            _mediator.Send(createClient);
            return "Post";
        }
        [HttpPut]
        public string PutClient(ClientUpdateModel updateModel)
        {
            _mediator.Send(updateModel);
            return "Put";
        }
        [HttpDelete("{id}")]
        public string DeleteClient(int id)
        {
            _mediator.Send(new ClientDeleteModel { Id = id });
            return "Delete";
        }
    }
    
    
}
