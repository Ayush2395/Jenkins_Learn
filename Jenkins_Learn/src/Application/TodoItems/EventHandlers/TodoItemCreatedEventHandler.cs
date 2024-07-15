using Jenkins_Learn.Domain.Events;
using Microsoft.Extensions.Logging;

namespace Jenkins_Learn.Application.TodoItems.EventHandlers;
public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Jenkins_Learn Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
