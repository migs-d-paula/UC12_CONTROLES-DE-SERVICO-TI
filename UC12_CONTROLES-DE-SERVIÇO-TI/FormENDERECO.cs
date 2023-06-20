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
    public partial class FormENDERECO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormENDERECO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=db_controle_de_servicos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_endereco(estado, cidade, bairro, rua, numero) VALUES ('" + comboBoxESTADO.Text + "', '" + textBoxCIDADE.Text + "', '" + textBoxBAIRRO.Text + "','" + textBoxRUA.Text + "', '" + textBoxNUMERO.Text + "'); ";
                comando.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao adicionar endereço, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
