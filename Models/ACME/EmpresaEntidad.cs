using System.ComponentModel.DataAnnotations;

namespace Models.ACME
{
    public class EmpresaEntidad
    {


        [Range(0, int.MaxValue,ErrorMessage = "Debe seleciconar una empresa")]
        [Display(Name = "Codigo")]

        public int IDEmpresa { get; set; }

        [Required (ErrorMessage = "Debe Seleccionar un tipo de empresa")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleciconar una empresa")]
        [Display(Name = "Tipo de empresa")]
        public int? IDTipoEmpresa { get; set; }


        [Required(ErrorMessage = "El Tipo  de la empresa ")]
        [Display(Name = "Tipo de la empresa")]
        public string Empresa { get; set; } = string.Empty;
        [Required(ErrorMessage = "La direccion de la empresa es obligatorio")]
        [Display(Name = "Direccion")]

        public string Direcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El RUC de la empresa es obligatorio")]
        [Display(Name = "RUC")]

        public string RUC { get; set; } = string.Empty;
        [Required(ErrorMessage = "Debe ingresar la fecha de creacion")]
        [Display(Name = "fecha de creacion")]

        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "debe ingresar el presupuesto")]
        [Display(Name = "presupuesto")]

        public decimal Presupuesto { get; set; }

        public bool Activo { get; set; } = true;


        public TipoEmpresaEntidad? TipoEmpresaEntidad { get; set; }
        
    }
}
