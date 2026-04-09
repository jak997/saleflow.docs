using BLL.Services;
using BLL.Repositories;

public static class Injector
{
    public static IServiceCollection DoBLLClassesInjection(this IServiceCollection services, bool useMockRepos )
    {
        //services
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IUserService, UserService>();

        //repos
        if (!useMockRepos)
        {
            services.AddScoped<IUserRepository, DAL.Repositories.UserRepository>();
        }
        else
        {
            services.AddScoped<IUserRepository, DAL.Repositories.Mock.MockUserRepository>();
        }
 
        return services;
    }
}