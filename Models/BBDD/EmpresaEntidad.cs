using System.ComponentModel.DataAnnotations;


namespace Models.BBDD
{
    public class EmpresaEntidad
    {

        [Range(0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa")]
        [Display(Name ="Código")]
        public int IDEmpresa { get; set; }

        //

        [Required(ErrorMessage = "Debe selecionar un tipo de empresa.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe selecionar un tipo de empresa.")]
        [Display(Name = "Tipo Empresa")]
        public int IDTipoEmpresa { get; set; }

        //
        [Required(ErrorMessage = "El Nombre de la empresa es obligatorio")]
        [Display(Name = "Nombre Empresa")]
        public string Empresa { get; set; } = string.Empty;

        //
        [Required(ErrorMessage = "La dirección de la empresa es obligatorio")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; } = string.Empty;

        //
        [Required(ErrorMessage = "El RUC de la empresa es obligatorio")]
        [Display(Name = "RUC Empresa")]
        public string RUC { get; set; } = string.Empty;

        //
        [Required(ErrorMessage = "Debe ingresar la fecha de creación")]
        [Display(Name = "Fecha creación")]

        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        //
        [Required(ErrorMessage = "Debe ingresar el presupuesto")]
        [Display(Name = "Presupuesto")]
        public decimal Presupuesto { get; set; }

        //
        
        public bool Activo { get; set; } = true;
        

        //Propiedad de navegacion a TipoEmpresa
        //


        public TipoEmpresaEntidad? TipoEmpresa { get; set;}







    }
}
