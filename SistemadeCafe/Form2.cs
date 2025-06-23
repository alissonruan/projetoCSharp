using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SistemadeCafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nome = txtNome.Text;
            int Idade;
            string Nivel = txtNivel.Text;

            if (string.IsNullOrEmpty(Nome) || !int.TryParse(txtNome.Text, out Idade))
            {
                MessageBox.Show("Preencha os dados Corretamente");
                return;
            }

            CadastrarPessoa();

        }

        private void CadastrarPessoa()
        {
            Pessoa pessoa = new Pessoa();

            Id = Id;
            Nome = Nome;
            Idade = Idade;
            Nivel = Nivel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            ExibirPessoas();
        }
            private void ExibirPessoas()
            {
                lstPessoas.Items.Clear();
                
                foreach(var pessoa in listaPessoa) 
                {
                    lstPessoas.Items.Add("$Nome: {pessoa.Nome}, $Idade: {pessos.Idade}, $Nivel: {pessoa.Nivel}");
                }

            }

    }
}
