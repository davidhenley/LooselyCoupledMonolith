using System;
using Microsoft.Extensions.Logging;
using Paramore.Brighter;
using Sales.Contracts;

namespace Shipping
{
    public class CreateShippingLabel : RequestHandler<OrderPlaced>
    {
        private readonly ILogger<CreateShippingLabel> _logger;

        public CreateShippingLabel(ILogger<CreateShippingLabel> logger)
        {
            _logger = logger;
        }

        public override OrderPlaced Handle(OrderPlaced command)
        {
            throw new InvalidOperationException();

            return base.Handle(command);
        }
    }
}