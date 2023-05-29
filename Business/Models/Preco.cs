using System;
using System.Collections.Generic;


namespace Business.Models
{
    public class Preco
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public float PrecoVenda { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}