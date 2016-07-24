<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/EquipoFutbol.Master" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TallerEquipoFutbol.Vistas.Ejercicio1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Crear, Modificar o Eliminar Usuario</h1>
    <br /><br />
        <div id="div1" class="form-horizontal" runat="server">

        <div class="form-group">
            <asp:Label ID="lblNumDoc" runat="server" Text="Número de Documento" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNumDoc" runat="server" CssClass="form-control" placeholder="Ingrese su número de documento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNumDoc" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNumDoc" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese su nombre completo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtNombre" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblEdad" runat="server" Text="Edad" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtEdad" runat="server" CssClass="form-control" placeholder="Ingrese su Edad" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revEdad" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtEdad" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblGoles" runat="server" Text="Goles" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtGoles" runat="server" CssClass="form-control" placeholder="Ingrese el número de goles" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revGoles" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtGoles" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblDepartamento" runat="server" Text="Departamento" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtDepartamento" runat="server" CssClass="form-control" placeholder="Ingrese su departamento" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revDepartamento" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtDepartamento" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblSueldo" runat="server" Text="Sueldo" CssClass="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:TextBox ID="txtSueldo" runat="server" CssClass="form-control" placeholder="Ingrese su sueldo" required="required"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revSueldo" runat="server" ErrorMessage="Ingreso un caracter invalido." ControlToValidate="txtSueldo" Display="Dynamic" ValidationGroup="grupoval1" ValidationExpression="^[0-9 ]*$"></asp:RegularExpressionValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label ID="lblEquipo" runat="server" Text="Equipo" class="col-xs-6"></asp:Label>
            <div class="col-xs-6">
                <asp:DropDownList ID="ddlEquipo" runat="server" CssClass="form-group">
                    <asp:ListItem Selected="FALSE">Seleccionar</asp:ListItem>
                    <asp:ListItem Value="1">Millonarios</asp:ListItem>
                    <asp:ListItem Value="2">Santafe</asp:ListItem>
                    <asp:ListItem Value="3">Nacional</asp:ListItem>
                    <asp:ListItem Value="4">Yunior</asp:ListItem>
                    <asp:ListItem Value="5">Once Caldas</asp:ListItem>
                    <asp:ListItem Value="6">America</asp:ListItem>
                    <asp:ListItem Value="7">Cali</asp:ListItem>
                    <asp:ListItem Value="8">Equidad</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="text-center">
            <asp:Button ID="btnVer" runat="server" Text="Ver" CssClass="btn btn-primary" OnClick="btnVer_Click" />
            <asp:Button ID="btnInserter" runat="server" Text="Insertar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnInserter_Click" />
            <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnModificar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnEliminar_Click" />
        </div>

   <%-- <div class="text-center">
       
        <button id="bntEliminar" type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#Modal">Eliminar</button>
        <div id="Modal" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <div class="modal-content">
                    Cabecera
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h3 class="modal-tittle">Atención:</h3>
                    </div>
                    Cuerpo
                    <div class="modal-body">
                        <p>¿Esta seguro de eliminar este registro?</p>
                    </div>
                    Pie
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">No</button>
                         <asp:Button ID="Button1" runat="server" Text="Sí" CssClass="btn btn-primary" data-toggle="modal" data-target="#Modal" CausesValidation="true" ValidationGroup="grupoval1" OnClick="btnEliminar_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>--%>

        <div class="form-group">
            <asp:Label ID="lblValidacion" runat="server" Text=""></asp:Label>
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
    </div>
</asp:Content>
