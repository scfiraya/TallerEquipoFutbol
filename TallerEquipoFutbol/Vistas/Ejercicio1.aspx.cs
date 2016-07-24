using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TallerEquipoFutbolBll;


namespace TallerEquipoFutbol.Vistas
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            EquipoFutbolBll objVer = new EquipoFutbolBll();
            DataTable dtVer = new DataTable();
            string Consulta = "";

            dtVer = objVer.VerJugadoresBll(Consulta);
            gvJugadores.DataSource = dtVer;
            gvJugadores.DataBind();
        }

        protected void btnInserter_Click(object sender, EventArgs e)
        {
            try
            {
                EquipoFutbolBll objInsertar = new EquipoFutbolBll();

                int NumDoc = Convert.ToInt32(txtNumDoc.Text);
                string Nombre = txtNombre.Text;
                int Edad = Convert.ToInt32(txtEdad.Text);
                int Goles = Convert.ToInt32(txtGoles.Text);
                string Departamento = txtDepartamento.Text;
                int Sueldo = Convert.ToInt32(txtSueldo.Text);

                int Idequipo2 = 0;

                if (ddlEquipo.Text.Equals(""))
                {
                    Idequipo2 = 0;
                }
                else
                {
                    Idequipo2 = Convert.ToInt32(ddlEquipo.Text);
                }

                objInsertar.InsertarUsuarioBll(NumDoc, Nombre, Edad, Goles, Departamento, Sueldo, Idequipo2);
                lblValidacion.Text = "El registro se guardar exitosamente";
            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al guardar. Detalledel error: " + ex.Message.ToString();
            }

            txtNumDoc.Text = " ";
            txtNombre.Text = " ";
            txtEdad.Text = " ";
            txtGoles.Text = " ";
            txtDepartamento.Text = " ";
            txtSueldo.Text = " ";
            ddlEquipo.Text = " ";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                EquipoFutbolBll objModificar = new EquipoFutbolBll();

                int NumDoc = Convert.ToInt32(txtNumDoc.Text);
                string Nombre = txtNombre.Text;
                int Edad = Convert.ToInt32(txtEdad.Text);
                int Goles = Convert.ToInt32(txtGoles.Text);
                string Departamento = txtDepartamento.Text;
                int Sueldo = Convert.ToInt32(txtSueldo.Text);

                int Idequipo2 = 0;

                if (ddlEquipo.Text.Equals(""))
                {
                    Idequipo2 = 0;
                }
                else
                {
                    Idequipo2 = Convert.ToInt32(ddlEquipo.Text);
                }

                objModificar.ModificarUsuarioBll(NumDoc, Nombre, Edad, Goles, Departamento, Sueldo, Idequipo2);
                lblValidacion.Text = "El registro se actualizó exitosamente";
            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al guardar. Detalledel error: " + ex.Message.ToString();
            }

            txtNumDoc.Text = " ";
            txtNombre.Text = " ";
            txtEdad.Text = " ";
            txtGoles.Text = " ";
            txtDepartamento.Text = " ";
            txtSueldo.Text = " ";
            ddlEquipo.Text = " ";
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                EquipoFutbolBll objEliminar = new EquipoFutbolBll();

                int NumDoc = Convert.ToInt32(txtNumDoc.Text);

                objEliminar.EliminarUsuarioBll(NumDoc);
                lblValidacion.Text = "El registro se elimino exitosamente.";
            }
            catch (Exception ex)
            {
                lblValidacion.Text = "Error al eliminar el registro. Detalle del error: " + ex.Message.ToString();
            }

            txtNumDoc.Text = " ";
            txtNombre.Text = " ";
            txtEdad.Text = " ";
            txtGoles.Text = " ";
            txtDepartamento.Text = " ";
            txtSueldo.Text = " ";
            ddlEquipo.Text = " ";
        }
    }
}