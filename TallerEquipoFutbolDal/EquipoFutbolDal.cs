using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace TallerEquipoFutbolDal
{
    public class EquipoFutbolDal
    {
        public void InsertarUsuarioDal(int NumDoc, string Nombre, int Edad, int Goles, string Departamento, int Sueldo, int Idequipo2)
        {
            string sql = "";

            sql = "insert into Jugadores (Nit, Nombre, Edad, NumGoles, Departamento, sueldo, Idequipo2 ) values ( " + NumDoc + ", ' " + Nombre + " '," + Edad + ", " + Goles + ", ' " + Departamento + " '," + Sueldo + ", " + Idequipo2 + " )";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public void ModificarUsuarioDal(int NumDoc, string Nombre, int Edad, int Goles, string Departamento, int Sueldo, int Idequipo2)
        {
            string sql = "";
            sql = "update Jugadores set Nombre = ' " + Nombre + " ' , Edad = " + Edad + ", NumGoles = " + Goles + ", Departamento = ' " + Departamento + " ', sueldo = " + Sueldo + ", Idequipo2 = " + Idequipo2 + " where Nit = (select Nit from Jugadores where Nit = " + NumDoc + ")";

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public void EliminarUsuarioDal(int NumDoc)
        {
            string sql = "";
            sql = "delete from Jugadores where Nit = " + NumDoc;

            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();

            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sql;
            Comando.ExecuteNonQuery();
            Connection.Close();
        }

        public DataTable VerJugadoresDal(string Consulta)
        {
            string sql = "";

            sql = "select * from Jugadores where Nit=" + Consulta;


            DataTable dtVer = new DataTable();
            DataSet dsVer = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsVer);
            Connection.Close();
            dtVer = dsVer.Tables[0];
            return dtVer;
        }
        public DataTable MostrarDatosDal(string consulta)
        {
            string sql = "";
            sql = "select E.Nombre as Nombre,Idequipo  from EquipoFutbol E inner join Jugadores J on Idequipo2=Idequipo where Idequipo=" + consulta;
            DataTable dtmostrar = new DataTable();
            DataSet dsmostrar = new DataSet();
            SqlConnection Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            Connection.Open();
            IDbCommand Comando = Connection.CreateCommand();
            Comando.CommandText = sql;
            SqlDataAdapter Adaptador = new SqlDataAdapter((SqlCommand)Comando);
            Adaptador.Fill(dsmostrar);
            Connection.Close();
            dtmostrar = dsmostrar.Tables[0];
            return dtmostrar;
        }
    }
}
