using GameTheoryGame.Blazor.Shared.Notifications;

namespace GameTheoryGame.Blazor.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}