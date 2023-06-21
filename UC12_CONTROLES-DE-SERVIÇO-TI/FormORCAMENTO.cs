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
    public partial class FormORCAMENTO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormORCAMENTO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_controle_de_servicos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            listarclientes();
        }
        private void listarclientes()
        {

            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome FROM tbl_cliente;";

                MySqlDataReader readercliente = comando.ExecuteReader();

                while (readercliente.Read())
                {
                    comboBoxCLIENTE.Items.Add(readercliente.GetString(0));
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
        }

        private void buttonPROXIMO_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();

                comando.CommandText = "INSERT INTO tbl_ordem_de_servico(cliente, produto, problema, data_de_chegada, solucoes, valor,  status) VALUES ('" + comboBoxCLIENTE.Text + "', '" + textBoxPRODUTO.Text + "', '" + textBoxPROBLEMA.Text + "', '" + System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + textBoxSOLUCOES.Text +  "', 'R$" + textBoxVALOR.Text + "', ' Em Andamento') ;";
                comando.ExecuteNonQuery();

                
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
