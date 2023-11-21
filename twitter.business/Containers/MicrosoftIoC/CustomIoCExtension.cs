using Microsoft.Extensions.DependencyInjection;
using twitter.business.Concrete;
using twitter.business.Interfaces;
using twitter.dataaccess.Concrete.EntityFrameworkCore.Repositories;
using twitter.dataaccess.Interfaces;

namespace twitter.business.Containers.MicrosoftIoC
{
    public static class CustomIoCExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<ITweetService, TweetManager>();
            services.AddScoped<ITweetDal, EfTweetRepository>();
        }
    }
}
