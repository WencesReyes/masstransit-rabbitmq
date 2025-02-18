using MassTransit;

namespace OrdersApi.Consumers
{
    //create consumer definition to set a consumer up
    public class OrderCreatedConsumerDefinition : ConsumerDefinition<OrderCreatedConsumer>
    {
        public OrderCreatedConsumerDefinition()
        {
            Endpoint(cfg => {
                cfg.Name = "wences_order_created";
            });
        }

        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<OrderCreatedConsumer> consumerConfigurator, IRegistrationContext context)
        {
            base.ConfigureConsumer(endpointConfigurator, consumerConfigurator, context);

            consumerConfigurator.UseMessageRetry(cfg => cfg.Immediate(2));
        }
    }
}
