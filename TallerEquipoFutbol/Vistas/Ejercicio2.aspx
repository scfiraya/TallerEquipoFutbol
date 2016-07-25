<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/EquipoFutbol.Master" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TallerEquipoFutbol.Vistas.Ejercicio2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Exportar Datos</h1>

    <br />
    <br />

    <div id="div1" class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" placeholder="Ingrese su número de documento"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnVer" runat="server" Text="Ver" CssClass="btn btn-primary" OnClick="btnVer_Click" />
        </div>

        <div class="form-group">
            <asp:GridView ID="gvJugadores" runat="server" AutoGenerateColumns="false" RowStyle-HorizontalAlign="Justify">
                <Columns>
                    <asp:BoundField HeaderText="Número de Documento" DataField="Nit" HeaderStyle-HorizontalAlign="Justify" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Edad" DataField="Edad" />
                    <asp:BoundField HeaderText="Número de Goles" DataField="NumGoles" />
                    <asp:BoundField HeaderText="Departamento" DataField="Departamento" />
                    <asp:BoundField HeaderText="Sueldo" DataField="sueldo" />
                    <asp:BoundField HeaderText="Equipo" DataField="idequipo2" />
                </Columns>
            </asp:GridView>
        </div>

        <div class="text-center">
            <asp:Button ID="btnExportarXls" runat="server" Text="Exportar XLS" CssClass="btn btn-primary" OnClick="btnExportarXls_Click" />
            <asp:Button ID="btnExportarTxt" runat="server" Text="Exportar TXT" CssClass="btn btn-primary" OnClick="btnExportarTxt_Click"/>
            <asp:Button ID="btnExportarHtml" runat="server" Text="Exportar HTML" CssClass="btn btn-primary" OnClick="btnExportarHtml_Click" />
            <asp:Button ID="btnExportarCvs" runat="server" Text="Exportar CVS" CssClass="btn btn-primary" OnClick="btnExportarCvs_Click"/>
            <asp:Button ID="btnPdf" runat="server" Text="Exportar PDF" CssClass="btn btn-primary" OnClick="btnPdf_Click"/>
        </div>

        <div class="form-group">
            <asp:Label ID="lblValidacion" runat="server" Text=""></asp:Label>
        </div>

    </div>

</asp:Content>