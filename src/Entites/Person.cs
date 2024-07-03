using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites;

public class Person
{
    [Key]
    [Column("IdentificationCard")]
    public required int IdentificationCard { get; set; }

    [Column("FirstName")]
    public string FirstName { get; set; }

    [Column("SecondName")]
    public string SecondName { get; set; }

    [Column("LastName")]
    public string LastName { get; set; }

    [Column("Gender")]
    public string Gender { get; set; }

    [Column("Age")]
    public string Age { get; set; }
}
