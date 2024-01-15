using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerceNet.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime Fecha { get; set; }
        public string Password { get; set; }
        public byte Type { get; set; }
    }
}