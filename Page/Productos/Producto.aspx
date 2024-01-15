<%@ Page Title="" Language="C#" MasterPageFile="~/Page/eCommerce.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="eCommerceNet.Page.Productos.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link href="../Template/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
    <link href="../Template/css/tiny-slider.css" rel="stylesheet">
    <link href="../Template/css/style.css" rel="stylesheet">
    
    <h1>Nuevo Producto</h1>
    <br />

    <div class="input-group input-group-sm mb-3">
        <asp:TextBox runat="server" ID="tbNombre" placeholder="Nombre" cssclass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"/>
        <br />
    </div>
    <div class="input-group input-group-sm mb-3">
        <asp:TextBox runat="server" ID="tbPrecio" placeholder="Precio" cssclass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"/>
        <br />
    </div>
    <div class="input-group input-group-sm mb-3">
        <asp:TextBox runat="server" ID="tbURL" placeholder="URL de la imagen" cssclass="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-sm"/>
        <br />
    </div>

    <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" />

</asp:Content>
