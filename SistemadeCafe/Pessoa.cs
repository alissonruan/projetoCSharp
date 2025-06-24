using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace SistemadeCafe
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Nivel { get; set; }


        public void CadastrarPessoa()
        {
            Id = Id;
            Nome = Nome;
            Idade = Idade;
            Nivel = Nivel;
        }
    }
}
