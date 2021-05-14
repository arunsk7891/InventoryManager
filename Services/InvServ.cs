using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManager
{   
    public class InvServ : Inventor.InventorBase
    {
        private readonly ILogger<InvServ> _logger;
        public InvServ(ILogger<InvServ> logger)
        {
            _logger = logger;
        }

        public override Task<InventorReply> SayHello(InventorRequest request, ServerCallContext context)
        {
            return Task.FromResult(new InventorReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
    

}
