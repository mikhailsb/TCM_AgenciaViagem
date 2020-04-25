using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_AgenciaViagem.Models
{
    public class Venda
    {

        public ushort IdVendas { get; set; }
        public string TipoPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataVenda { get; set; }

        public void FinalizarCompra() 
        { }

        /*
            * Venda
            *IdVenda: ushort
            *TipoPagamento: string
            *ValorTotal: double(10)
            *DataVenda: DateTime
            *-----------------------
            *-FinalizarCompra()
         */
    }
}