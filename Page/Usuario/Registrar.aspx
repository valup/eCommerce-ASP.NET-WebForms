<%@ Page Title="" Language="C#" MasterPageFile="~/Page/Usuario/MiCuenta.Master" AutoEventWireup="true" CodeBehind="Registrar.aspx.cs" Inherits="eCommerceNet.Page.Usuario.Registrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="../../Template/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
    <link href="../../Template/css/tiny-slider.css" rel="stylesheet">
    <link href="../../Template/css/style.css" rel="stylesheet">

    <h2>Nuevo Usuario</h2>

    <div class="input-group input-group-sm mb-3">
        <asp:TextBox runat="server" ID="tbEmail" placeholder="Email" cssclass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"
            Width="100px"/>
        <br />
    </div>
    <div class="input-group input-group-sm mb-3">
        <asp:TextBox runat="server" ID="tbPassword" TextMode="Password" placeholder="Password" cssclass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"
            Width="100px"/>
        <br />
    </div>

    <asp:Label ID="errorExiste" runat="server" CssClass="alert-danger"/>
    <br />

    <asp:Button ID="btnRegistrar" Text="Registrar" runat="server" OnClick="btnRegistrar_Click" />

</asp:Content>
