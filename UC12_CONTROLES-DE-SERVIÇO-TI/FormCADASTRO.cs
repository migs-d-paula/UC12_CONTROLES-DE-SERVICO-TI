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
    public partial class FormCADASTRO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        string endereco = "";

        public FormCADASTRO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_controle_de_servicos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form telaENDERECO = new FormENDERECO();
            
            telaENDERECO.Show();
        }

        private void buttonCONCLUIDO_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_endereco;";

                MySqlDataReader readerVENDA = comando.ExecuteReader();

                if (readerVENDA.Read())
                {
                    endereco = readerVENDA.GetString(0);
                }
            }
            catch (Exception erro_Mysql)
            {
                MessageBox.Show(erro_Mysql.Message);
            }
            finally
            {
                conexao.Close();
            }

            try
            {
                conexao.Open();

                comando.CommandText = "INSERT INTO tbl_cliente(nome, cpf, celular, fk_endereco) VALUES ('" + textBoxNOME.Text + "', '" + textBoxCPF.Text + "', '" + textBoxCELULAR.Text + "', '" + endereco + "'); ";
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
