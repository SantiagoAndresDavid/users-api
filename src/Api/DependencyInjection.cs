namespace Api;

public static class DependencyInjection
{
    public static void AddRepositories(this IServiceCollection repositories)
    {
        repositories.AddScoped<UsersRepository>();
        repositories.AddScoped<PersonsRepository>();

    }

}
