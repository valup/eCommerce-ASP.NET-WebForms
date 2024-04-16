<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Usuario/MiCuenta.Master" AutoEventWireup="true" CodeBehind="MisDirecciones.aspx.cs" Inherits="eCommerceNet.Page.Usuario.MisDirecciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
	<link href="/Template/css/tiny-slider.css" rel="stylesheet">
	<link href="/Template/css/style.css" rel="stylesheet">

    <div class="container">
        <div class="row mb-5">
            <form class="col-md-12" method="post">
                <div class="site-blocks-table">
                    <table class="table">

                        <thead>
                            <tr>
                                <th> Mis Direcciones </th>
                            </tr>
                        </thead>

                        <tbody>
                            <asp:DataList ID="dlDirecciones" runat="server">
                                <ItemTemplate>
                                    <th>
                                        Direccion <%# Eval("id") %>
                                    </th>
                                    <tr>
                                        <td> | Pais: <%# Eval("pais") %> </td>
                                        <td> | Estado: <%# Eval("estado") %> </td>
                                        <td> | Ciudad: <%# Eval("ciudad") %> </td>
                                        <td> | Codigo Postal: <%# Eval("codigoPostal") %> </td>
                                        <td> | Calle: <%# Eval("calle") %> </td>
                                        <td> | Telefono: <%# Eval("telefono") %> </td>
                                        <td> | Notas: <%# Eval("opcional") %> </td>
                                    </tr>
                                    
                                </ItemTemplate>
                            </asp:DataList>
                        </tbody>
                    </table>
                </div>
            </form>
        </div>
    </div>
</asp:Content>
