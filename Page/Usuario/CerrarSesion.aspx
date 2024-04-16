<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Usuario/MiCuenta.Master" AutoEventWireup="true" CodeBehind="CerrarSesion.aspx.cs" Inherits="eCommerceNet.Page.Usuario.CerrarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="/Template/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
    <link href="/Template/css/tiny-slider.css" rel="stylesheet">
    <link href="/Template/css/style.css" rel="stylesheet">

    <h2>Cerrar Sesion</h2>

    <asp:Label Text="Desea cerrar su sesion?" runat="server" />
    <asp:Button ID="btnCerrarSesion" Text="Confirmar" runat="server" Width="200px" OnClick="btnCerrarSesion_Click" />
</asp:Content>
