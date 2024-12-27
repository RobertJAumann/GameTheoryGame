using GameTheoryGame.Blazor.Shared.Notifications;

namespace GameTheoryGame.Blazor.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;