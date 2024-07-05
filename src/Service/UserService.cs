using Entites;
using Encryptor = BCrypt.Net.BCrypt;

public class UserService
{
    private readonly UsersRepository _usersRepository;

    public UserService(UsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public string SaveUser(User user)
    {
        try
        {
            Console.WriteLine(user);
            user.Password = Encryptor.HashPassword(user.Password);
            _usersRepository.Save(user);
            return "se guardo con exito";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}
