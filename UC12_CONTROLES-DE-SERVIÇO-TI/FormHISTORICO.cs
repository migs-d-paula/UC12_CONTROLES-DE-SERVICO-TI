using MySql.Data.MySqlClient;
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
    public partial class FormHISTORICO : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormHISTORICO()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_controle_de_servicos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
        }
        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome, produto, solucoes, valor, data_de_chegada, status FROM tbl_ordem_de_servico INNER JOIN tbl_cliente ON (tbl_ordem_de_servico.fk_cliente = tbl_cliente.id) ORDER BY data_de_chegada DESC;";
                comando.ExecuteNonQuery();

                MySqlDataAdapter adaptadorHISTORICO = new MySqlDataAdapter(comando);

                DataTable tabelaHISTORICO = new DataTable();
                adaptadorHISTORICO.Fill(tabelaHISTORICO);

                dataGridViewHISTORICO.DataSource = tabelaHISTORICO;
                dataGridViewHISTORICO.Columns["nome"].HeaderText = "NOME";
                dataGridViewHISTORICO.Columns["produto"].HeaderText = "PRODUTO";
                dataGridViewHISTORICO.Columns["solucoes"].HeaderText = "SOLUÇÃO";
                dataGridViewHISTORICO.Columns["valor"].HeaderText = "VALOR";
                dataGridViewHISTORICO.Columns["data_de_chegada"].HeaderText = "DATA";
                dataGridViewHISTORICO.Columns["status"].HeaderText = "STATUS";
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void labelATUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome, produto, solucoes, valor, data_de_chegada, status FROM tbl_ordem_de_servico INNER JOIN tbl_cliente ON (tbl_ordem_de_servico.fk_cliente = tbl_cliente.id) ORDER BY data_de_chegada DESC;";
                comando.ExecuteNonQuery();

                MySqlDataAdapter adaptadorHISTORICO = new MySqlDataAdapter(comando);

                DataTable tabelaHISTORICO = new DataTable();
                adaptadorHISTORICO.Fill(tabelaHISTORICO);

                dataGridViewHISTORICO.DataSource = tabelaHISTORICO;
                dataGridViewHISTORICO.Columns["nome"].HeaderText = "NOME";
                dataGridViewHISTORICO.Columns["produto"].HeaderText = "PRODUTO";
                dataGridViewHISTORICO.Columns["solucoes"].HeaderText = "SOLUÇÃO";
                dataGridViewHISTORICO.Columns["valor"].HeaderText = "VALOR";
                dataGridViewHISTORICO.Columns["data_de_chegada"].HeaderText = "DATA";
                dataGridViewHISTORICO.Columns["status"].HeaderText = "STATUS";

            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonPESQUISAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT nome, produto, solucoes, valor, data_de_chegada, status FROM tbl_ordem_de_servico INNER JOIN tbl_cliente ON (tbl_ordem_de_servico.fk_cliente = tbl_cliente.id) WHERE nome LIKE '" + textBoxPESQUISA.Text + "'% OR produto LIKE '" + textBoxPESQUISA.Text + "'% OR status LIKE '" + textBoxPESQUISA.Text + "'% OR data_de_chegada BETWEEN '" + dateTimePicker1 + "' AND '" + dateTimePicker2 + "' '" + "'% ORDER data_de_chegada;";
                comando.ExecuteNonQuery();

                MySqlDataAdapter adaptadorHISTORICO = new MySqlDataAdapter(comando);

                DataTable tabelaHISTORICO = new DataTable();
                adaptadorHISTORICO.Fill(tabelaHISTORICO);

                dataGridViewHISTORICO.DataSource = tabelaHISTORICO;
                dataGridViewHISTORICO.Columns["nome"].HeaderText = "NOME";
                dataGridViewHISTORICO.Columns["produto"].HeaderText = "PRODUTO";
                dataGridViewHISTORICO.Columns["solucoes"].HeaderText = "SOLUÇÃO";
                dataGridViewHISTORICO.Columns["valor"].HeaderText = "VALOR";
                dataGridViewHISTORICO.Columns["data_de_chegada"].HeaderText = "DATA";
                dataGridViewHISTORICO.Columns["status"].HeaderText = "STATUS";
            }


            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao abrir a lista, Fale com o Adiministrador do sistema");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
