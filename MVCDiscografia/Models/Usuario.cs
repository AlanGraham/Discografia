using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDiscografia.Models
{
    [Table("Usuarios")]
    public partial class Usuario
    {
        public int UsuarioID { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name="Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage="Proporciona la contraseņa")]
        [StringLength(64)]
        [Display(Name="Contraseņa")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [Required(ErrorMessage="La contraseņa no es la misma.")]
        [StringLength(64)]
        [Display(Name="Confirma")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }

        public short Estatus { get; set; }

        public Usuario()
        {

        }
    }
}
