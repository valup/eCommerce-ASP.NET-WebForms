using eCommerceNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace eCommerceNet.DTO
{
    public static class ListaCarritoDTO
    {
        public static List<CarritoProducto> ListaCarrito {  get; set; } = new List<CarritoProducto>();
    }
}