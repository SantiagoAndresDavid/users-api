using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites;

public class User
{

    [Key]
    [Column("Username")]
    public required string UserName { get; set; }

    [Column("Password")]
    public required string Password { get; set; }

    [ForeignKey("IdentificationCard")]
    public required int IdentificationCard { get; set; }
}
