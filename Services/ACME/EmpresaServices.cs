using Models.ACME;
using DataAccesss.ACME;


namespace Services.ACME
{
    public class EmpresaServices
    {
        public bool Crear(EmpresaEntidad empresaEntidad)
        {
            EmpresaDA empresaDA = new EmpresaDA();

            try
            {
                empresaDA.Insertar(empresaEntidad);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Actaulizar(EmpresaEntidad empresaEntidad)
        {
            EmpresaDA empresaDA = new EmpresaDA();

            try
            {
                empresaDA.Modificar(empresaEntidad);
                return true;
            }
            catch
            {
                return false;
            }

        }
       
    }
}
