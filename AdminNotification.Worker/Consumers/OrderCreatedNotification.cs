using Contracts.Events;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace AdminNotification.Worker.Consumers;

public sealed class OrderCreatedNotification : IConsumer<OrderCreated>
{
    public async Task Consume(ConsumeContext<OrderCreated> context)
    {
        await Task.Delay(1000);

        Console.WriteLine($"Listening from admin notification worker. Queue: {context.ReceiveContext.InputAddress}");

        Console.WriteLine($"Listening from admin notification worker. Consuming order: {context.Message.OrderId}");
    }
}