namespace EventNotify;

public interface INotificationHandler<in TSource>
{
    Task Handle(TSource source);
}