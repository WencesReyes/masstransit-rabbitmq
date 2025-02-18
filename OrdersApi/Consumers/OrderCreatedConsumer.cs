using Contracts.Events;
using MassTransit;

namespace OrdersApi.Consumers
{
    //create a consumer
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        public async Task Consume(ConsumeContext<OrderCreated> context)
        {
            await Task.Delay(1000);

            Console.WriteLine($"Queue: {context.ReceiveContext.InputAddress}");

            Console.WriteLine($"Consuming order: {context.Message.OrderId}");
        }
    }
}
