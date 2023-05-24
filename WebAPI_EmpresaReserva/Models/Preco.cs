using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_EmpresaReserva
{
    public class Preco
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public double PrecoVenda { get; set; }
        public string Data { get; set; }

    }
}