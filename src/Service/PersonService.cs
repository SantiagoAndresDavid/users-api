using Entites;

namespace Service;

public class PersonService
{
    private readonly PersonsRepository _personsRepository;

    public PersonService(PersonsRepository personsRepository)
    {
        _personsRepository = personsRepository;
    }

    public string SavePerson(Person person)
    {
        try
        {
            _personsRepository.Save(person);
            return "se guardo con exito";
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

