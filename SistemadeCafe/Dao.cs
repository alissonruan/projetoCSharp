using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace SistemadeCafe
{
    class Dao
    {
        public string connectionString = "Server=localhost;Database=pingpong;Trusted_Connection=true";

        public void InserirJogador(Pessoa pessoa)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "INSERT INTO jogadores (nome, idade, nivel) VALUES (@nome, @idade, @nivel)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@idade", pessoa.Idade);
                cmd.Parameters.AddWithValue("@nivel", pessoa.Nivel);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Pessoa> ListarJogador()
        {
            var pessoa = new List<Pessoa>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string sql = "SELECT id, nome, idade, nivel FROM jogadores";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pessoa.Add(new Pessoa
                    {
                        Nome = reader["Nome"].ToString(),
                        Idade = (int)reader["idade"],
                        Nivel = reader["nivel"].ToString()
                    });
                }
            }
            return pessoa;
        }
        public void Atualizar (Pessoa pessoa) 
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                string sql = "UPDATE jogadores SET nome = @nome, idade = @idade, nivel = @nivel WHERE id = @id";
                SqlCommand cmd  = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", pessoa.Id);
                cmd.Parameters.AddWithValue("@nome", pessoa.Nome);
                cmd.Parameters.AddWithValue("@idade", pessoa.Idade);
                cmd.Parameters.AddWithValue("@nivel", pessoa.Nivel);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Deletar (int id) 
        {
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                string sql = "DELETE FROM jogadores WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
    }
}
