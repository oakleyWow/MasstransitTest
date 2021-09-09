using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alpha.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MassTransit;
using Contracts;

namespace Alpha.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController
    {
        private readonly ILogger<TestController> _logger;

        private readonly IRepository<ProcessTask> _repository; 
        
        private readonly IMessageSender _messageSender; 
        
        readonly ISendEndpointProvider _sendEndpointProvider;
        
        [HttpGet]
        [Route("Create")]
        public ProcessTask CreateTask()
        {
            var task = new ProcessTask() { State = TaskState.New};
            _repository.Create(task);
            
            var endpoint =  _sendEndpointProvider.GetSendEndpoint(new Uri("queue:beta")).Result;
            endpoint.Send(new WorldMessage() {MessageId = new Guid(), MessageText = "Hello"});
            return task;
        }
        
        public TestController(ILogger<TestController> logger, IRepository<ProcessTask> repository, 
            IMessageSender messageSender, 
            IPublishEndpoint publishEndpoint, 
            ISendEndpointProvider sendEndpointProvider)
        {
            _logger = logger;
            _repository = repository;
            _messageSender = messageSender;
            _sendEndpointProvider = sendEndpointProvider;
        }
        
    }
}