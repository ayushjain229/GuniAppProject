using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniApp.Web.Models
{
    [Table("Departments")]
    public class Department
    {
        [Display(Name = "Department ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Display(Name = "Name of the Department")]
        [Required]
        [StringLength(50)]
        [Column("varchar")]
        public string DepartmentName { get; set; }
    }
}
