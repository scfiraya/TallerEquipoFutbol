using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TallerEquipoFutbolBll;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Text;
using iTextSharp.text; //Pdf
using iTextSharp.text.pdf; //Pdf
using iTextSharp.text.html; //Pdf
using iTextSharp.text.html.simpleparser; //Pdf
using System.Xml;
using System.Collections;
using System.Net;

namespace TallerEquipoFutbol.Vistas
{
    public partial class Ejercicio2 : System.Web.UI.Page
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

        protected void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel("Informe.xls", gvJugadores);
        }

        private void ExportToExcel(string nameReport, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "application/vnd.ms-excel";
            response.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            response.Write(sw.ToString());
            response.End();
        }

        protected void btnExportarHtml_Click(object sender, EventArgs e)
        {
            ExportToHtml("Informe.html", gvJugadores);
        }

        private void ExportToHtml(string nameReport, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "text/text";
            response.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            response.Write(sw.ToString());
            response.End();
        }

        protected void btnExportarPdf_Click1(object sender, EventArgs e)
        {
            ExportToPDF("Informe.pdf", gvJugadores);
        }

        private void ExportToPDF(string nameReport, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "application/pdf";
            response.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            response.Write(sw.ToString());
            response.End();
        }

        protected void btnExportarPlain_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Informe.csv"));
            Response.ContentType = "text/csv";
            Response.ContentEncoding = Encoding.UTF8;
            gvJugadores.AllowPaging = false;
            gvJugadores.DataBind();
            StringBuilder strbldr = new StringBuilder();
            for (int i = 0; i < gvJugadores.Columns.Count; i++)
            {
                //separting header columns text with comma operator
                strbldr.Append(gvJugadores.Columns[i].HeaderText + ',');
            }
            //appending new line for gridview header row
            strbldr.Append("\n");
            for (int j = 0; j < gvJugadores.Rows.Count; j++)
            {
                for (int k = 0; k < gvJugadores.Columns.Count; k++)
                {
                    //separating gridview columns with comma
                    strbldr.Append(gvJugadores.Rows[j].Cells[k].Text + ',');
                }
                //appending new line for gridview rows
                strbldr.Append("\n");
            }
            Response.Write(strbldr.ToString());
            Response.End();
        }
    }
}