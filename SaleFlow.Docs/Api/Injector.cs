using BLL.Services;
using BLL.Repositories;

public static class Injector
{
    public static IServiceCollection DoBLLClassesInjection(this IServiceCollection services, bool useMockRepos )
    {
        //services
        services.AddScoped<IQuoteService, QuoteService>();

        //repos
        if (!useMockRepos)
        {
            services.AddScoped<IQuoteRepository, DAL.Repositories.QuoteRepository>();
        }
        else
        {
            services.AddScoped<IQuoteRepository, DAL.Repositories.Mock.MockQuoteRepository>();
        }
 
        return services;
    }
}