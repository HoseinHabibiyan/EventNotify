namespace EventNotify;

public interface INotificationPublisher
{
    Task Publish<TSource>(TSource source) where TSource : INotification<TSource>;
}