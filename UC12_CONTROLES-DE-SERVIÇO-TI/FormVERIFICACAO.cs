using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace UC12_CONTROLES_DE_SERVIÇO_TI
{
    public partial class FormVERIFICACAO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormVERIFICACAO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_controle_de_servicos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                comando.CommandText = "UPDATE tbl_ordem_de_servico SET status = 'Aprovado';";
                comando.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                comando.CommandText = "UPDATE tbl_ordem_de_servico SET status = 'Cancelado';";
                comando.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
