<%@ Page Title="" Language="C#" MasterPageFile="~/Page/eCommerce.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="eCommerceNet.Page.Home" %>
<%@ Import Namespace = "eCommerceNet" %>

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

        <asp:DataList ID="dlProductos" runat="server" RepeatColumns="3" CellSpacing="3" RepeatLayout="Table">

            <ItemTemplate>
					<table class="table">
						<tr>
							<th colspan="2">
								<b>
									<%# Eval("nombre") %></b>
							</th>
						</tr>
						<tr>
							<td>
								<asp:Image ImageUrl='<%# Eval("imagen")%>' runat="server" Width="200px" />
							</td>
						</tr>
						<tr>
							<td>
								$<%# Eval("precio")%>  
							</td>
						</tr>
						<tr>
							<td>
								<a href="Productos\DetallesProducto.aspx?id=<%# Eval("id")%>" >Ver</a>
							</td>
						</tr>
					</table>
            </ItemTemplate>

        </asp:DataList>
	
	</div>
	<!-- End Product Section -->

</asp:Content>
