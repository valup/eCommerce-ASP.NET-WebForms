<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Usuario/MiCuenta.Master" AutoEventWireup="true" CodeBehind="MiCuenta.aspx.cs" Inherits="eCommerceNet.Page.Usuario.MiCuenta1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
	<link href="/Template/css/tiny-slider.css" rel="stylesheet">
	<link href="/Template/css/style.css" rel="stylesheet">

    <div style="text-align:center">
        <a href="MisOrdenes.aspx" class="btn btn-outline-light">Mis Ordenes</a>
        <a href="MisDirecciones.aspx" class="btn btn-outline-light">Mis Direcciones</a>
        <a href="CerrarSesion.aspx" class="btn btn-outline-light">Cerrar Sesion</a>
        <a href="EliminarCuenta.aspx" class="btn btn-outline-light">Eliminar Cuenta</a>
    </div>
</asp:Content>
