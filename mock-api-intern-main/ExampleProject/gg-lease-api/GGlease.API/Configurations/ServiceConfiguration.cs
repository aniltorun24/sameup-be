using GGlease.Services.Interfaces;

namespace GGlease.API.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection builder)
        {
            var type = typeof(ICurrencyService);
            var types = type.Assembly.ExportedTypes.ToArray();
            var ns = type.Namespace;

            var services = types.Where(x => x.Namespace == ns);

            foreach (var service in services)
            {
                var concrete = types.Where(x => x.IsAssignableTo(service) && x.IsClass).FirstOrDefault();

                if (concrete != null)
                {
                    builder.AddScoped(service, concrete);
                }
            }

            return builder;
        }
    }
}