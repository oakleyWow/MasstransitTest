using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MassTransit;
using Contracts;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("controller")]
    public class TestController : ControllerBase
    {
        readonly IRequestClient<WorldMessage> _sendWordMessageClient;
        
        readonly IRequestClient<PointMessage> _sendPointMessageClient;
        
        [HttpGet]
        [Route("Send")]
        public async Task<IActionResult> CreateTask()
        {
            var (status, notFound) = 
                await _sendWordMessageClient.GetResponse<IWorldMessageAccepted, IMessageRejected>(new WorldMessage() { MessageId = new Guid(), MessageText = "Hello"});

            if (!status.IsCompletedSuccessfully)
                return NotFound();
            
            var response = await status;
            
            var message =response.Message;
            
            (status, notFound) = 
                await _sendPointMessageClient.GetResponse<IWorldMessageAccepted, IMessageRejected>(new PointMessage() { MessageId = message.MessageId, MessageText = message.Text});
            
            if (status.IsCompletedSuccessfully)
            {
                response = await status;
                return Ok(response.Message.Text);
            }
            else
            {
                return NotFound();
            }  
        }
        
        public TestController(IRequestClient<WorldMessage> sendWordMessageClient, IRequestClient<PointMessage> sendPointMessageClient)
        {
            _sendWordMessageClient = sendWordMessageClient;
            _sendPointMessageClient = sendPointMessageClient;
        }
    }
}