using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_AgenciaViagem.Models
{
    public class Cliente
    {
        public ushort IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string Email { get; set; }
        public string SenhaCliente { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
     
        //-----------------------
        //CadastrarCliente()
        //ConsultaAgenda()
        //RealizarCompra()
    }
}