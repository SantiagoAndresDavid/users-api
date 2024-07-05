namespace Api;

public static class DependencyInjection
{
    public static void AddRepositories(this IServiceCollection repositories)
    {
        repositories.AddScoped<UsersRepository>();
        repositories.AddScoped<PersonsRepository>();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddScoped<UserService>();
    }
}
