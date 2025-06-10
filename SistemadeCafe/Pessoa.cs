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
        public int id {  get; set; }
        public string Nome { get; set; }
        public int idade { get; set; }
        public string nivel { get; set; }
        
    }
}
