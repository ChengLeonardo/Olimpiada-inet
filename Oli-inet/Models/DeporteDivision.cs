using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Oli_inet;
[Table("DeporteDivision")]
public class DeporteDivision
{
    [Key]
    [Required]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdDeporteDiv {get; set ;}
    
    [Required]
    [Key]
    [ForeignKey("IdDeporte")]
    public Deporte? Deporte{get; set;}=null;
}

