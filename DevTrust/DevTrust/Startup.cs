using DevTrust.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrust
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IDataAccessService, DataAccessService>();
        }
    }
}
