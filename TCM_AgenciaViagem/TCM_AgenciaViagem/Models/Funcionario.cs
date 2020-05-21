using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCM_AgenciaViagem.Models
{
    public class Funcionario
    {
        public ushort IdFuncionario { get; set; }


        public string NomeFuncioario { get; set; }
        public string Login { get; set; }
        public string SenhaFuncionario { get; set; }

        public void CadastrarFuncionario() 
        { }

        public void ConsultaCliente()
        { }

        public void CadastrarPacote()
        { }

        public void ConsultaPacote()
        { }

        /*
            * Funcionario
            * IdFuncionario: ushort
            * NomeFuncionario: string
            * Login: string
            * SenhaFuncionario: string
            * -----------------------
            * CadastrarFuncionario()
            * ConsultaCliente()
            * CadastrarPacote()
            * ConsultaPacote()
         */
    }
}