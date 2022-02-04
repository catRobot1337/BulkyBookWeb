using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    [Key] //key annotation tells entity framework code to ensure Id is a PK and should also be an identity column when it creates the script, does all the talking and configuration by itself
    public int Id { get; set; }
    [Required] //req annotation ensures that there name must not be null before EF creates the script
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now; //default value automatically assigned to datetime when we make an object of this class
}


