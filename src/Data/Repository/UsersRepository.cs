using Data.Repository.Shared;
using Entites;


public class UsersRepository : Repository<User>
{
    public UsersRepository(UsersDbContext context) : base(context)
    {
    }
}
