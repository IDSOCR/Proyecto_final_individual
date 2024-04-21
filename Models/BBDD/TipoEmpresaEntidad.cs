namespace Models.BBDD
{
    public class TipoEmpresaEntidad
    {

        // son los misms campos de la tabla de la BBDD para el proyecto final
        public int IDTipoEmpresa { get; set; }

        public string TipoEmpresa { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public string Sigla { get; set; } = string.Empty;


        public bool Activo { get; set; } = true;
    }
}
