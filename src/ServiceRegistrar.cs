using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace EventNotify;

public static class ServiceRegistrar
{
    public static Assembly[] Assemblies = [];
    
    public static void AddEventNotify(this IServiceCollection services, Assembly[] assemblies)
    {
        Assemblies = assemblies.Distinct().ToArray();
    }
}