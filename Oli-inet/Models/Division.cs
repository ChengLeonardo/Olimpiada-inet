using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oli_inet;

[Table("Division")]
public class Division
{
   [Key]
   [Required]
   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   public int IdDiv {get; set;}
   
   [Required]
   public int Edad {set; get;}

   [Required]
   [StringLength(20)]
   public string Genero {get; set;}=string.Empty;
}
 