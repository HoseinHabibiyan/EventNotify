namespace EventNotify;

public class NotificationPublisher : INotificationPublisher
{
    public async Task Publish<TSource>(TSource source) where TSource : INotification<TSource>
    {
        var types = ServiceRegistrar.Assemblies.SelectMany(x => x.GetTypes())
            .Where(x => x.IsClass && x.IsAssignableTo(typeof(INotificationHandler<TSource>))).ToList();

        foreach (var type in types)
        {
            var obj = Activator.CreateInstance(type) as INotificationHandler<TSource>;
            await obj!.Handle(source);
        }
    }
}