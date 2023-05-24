using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_EmpresaReserva.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        private static int proximoId = 1;
        public static int GerarId()
        {
            int novoId = proximoId;
            proximoId++;
            return novoId;
        }

        // Foreign Key
        public int PrecoId { get; set; }
    }
}