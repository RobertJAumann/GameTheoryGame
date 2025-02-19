using GameTheoryGame.Blazor.Shared.Notifications;
using MediatR;

namespace GameTheoryGame.Blazor.Infrastructure.Notifications;

public class NotificationWrapper<TNotificationMessage> : INotification
    where TNotificationMessage : INotificationMessage
{
    public NotificationWrapper(TNotificationMessage notification) => Notification = notification;

    public TNotificationMessage Notification { get; }
}