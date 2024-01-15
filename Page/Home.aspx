<%@ Page Title="" Language="C#" MasterPageFile="~/Page/eCommerce.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="eCommerceNet.Page.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<link href="../Template/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
	<link href="../Template/css/tiny-slider.css" rel="stylesheet">
	<link href="../Template/css/style.css" rel="stylesheet">

	<!-- Start Hero Section -->
	<div class="hero">
		<div class="container">
			<div class="row justify-content-between">
				<div class="col-lg-5">
					<div class="intro-excerpt">
						<h1>Bienvenido a la tienda!</h1>
					</div>
				</div>
			</div>
		</div>
	</div>
	<!-- End Hero Section -->

	<!-- Start Product Section -->
	<div class="product-section">
		<h2>Productos</h2>
		<%
			var prods=ListaProductos();
			Response.Write("<ul>");
			foreach(var p in prods)
			{
				Response.Write("<li>"
					+ "<a class=\"product-item\" href=\"Carrito\\Carrito.aspx\">\r\n"
					+ "<img  src='" + p.Imagen + "' class=\"img-fluid product-thumbnail\">"
					+ "<h3 class=\"product-title\">'" + p.Nombre + "'</h3>"
					+ "<strong class=\"product-price\">'" + p.Precio + "'</strong>"
					+ "<span class=\"icon-cross\"><img src=\"../Template/images/cross.svg\" class=\"img-fluid\"></span></a></li><br/>");
			}
			Response.Write("</ul>");
		%>



	
	</div>
	<!-- End Product Section -->

</asp:Content>
