using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TallerEquipoFutbolDal;

namespace TallerEquipoFutbolBll
{
    public class EquipoFutbolBll
    {
        public void InsertarUsuarioBll(int NumDoc, string Nombre, int Edad, int Goles, string Departamento, int Sueldo, int Idequipo2)
        {
            EquipoFutbolDal objInsertar = new EquipoFutbolDal();

            objInsertar.InsertarUsuarioDal(NumDoc, Nombre, Edad, Goles, Departamento, Sueldo, Idequipo2);
        }

        public void ModificarUsuarioBll(int NumDoc, string Nombre, int Edad, int Goles, string Departamento, int Sueldo, int Idequipo2)
        {
            EquipoFutbolDal objModificar = new EquipoFutbolDal();

            objModificar.ModificarUsuarioDal(NumDoc, Nombre, Edad, Goles, Departamento, Sueldo, Idequipo2);
        }

        public void EliminarUsuarioBll(int NumDoc)
        {
            EquipoFutbolDal objEliminar = new EquipoFutbolDal();

            objEliminar.EliminarUsuarioDal(NumDoc);
        }

        public DataTable VerJugadoresBll(string Consulta)
        {
            EquipoFutbolDal objVer = new EquipoFutbolDal();
            DataTable dtVer = new DataTable();
            dtVer = objVer.VerJugadoresDal(Consulta);
            return dtVer;
        }
    }
}
