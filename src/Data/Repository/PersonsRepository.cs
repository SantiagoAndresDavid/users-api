using Data.Repository.Shared;
using Entites;


public class PersonsRepository : Repository<Person>
{
    public PersonsRepository(UsersDbContext context) : base(context)
    {
    }
}
