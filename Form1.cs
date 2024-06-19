using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Importação da biblioteca para Mysql


namespace CrudEmDotNet
{
    public partial class Form1 : Form
    {
       private MySqlConnection Conexao;
        // Variável Conexao do tipo MysQconection
       private string data_source = "datasource=localhost;username=root;password=;database=db_agenda";
        // Dados da conexão
        private int ?id_contato_selecionado=null; //? referenciando que a variavel pode ser nula


        public Form1()
        {
            InitializeComponent();

            lst_contato.View = View.Details;
            lst_contato.LabelEdit=true;
            lst_contato.AllowColumnReorder=true;
            lst_contato.FullRowSelect=true;

            lst_contato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contato.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lst_contato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            CarregarConteudo();
            btn_excluir.Visible=false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                // passado os dados para a conexao
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (id_contato_selecionado==null)
                {
                    // insert
                    cmd.CommandText="insert into contato(nome,email,telefone)" +
                    "values(@nome,@email,@telefone);";
                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);

                    cmd.Prepare(); // No exemplo do vídeo o cara coloca prepare antes do parameters, dá erro, faz assim ;)

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Processo realizado com sucesso !!!", 
                        "Inserido!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    // update
                    cmd.CommandText="update contato set nome=@nome,email=@email,telefone=@telefone where id=@id";
                    cmd.Parameters.AddWithValue("@nome", TxtNome.Text);
                    cmd.Parameters.AddWithValue("@email", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", TxtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id",id_contato_selecionado.ToString());
                    cmd.Prepare(); // No exemplo do vídeo o cara coloca prepare antes do parameters, dá erro, faz assim ;)

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Processo realizado com sucesso !!!",
                        "Alterado!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                CarregarConteudo();
                ZerarConteudo();

              /*  string sql = "insert into contato(nome,email,telefone) " +
                "values('"+TxtNome.Text+"','"+TxtEmail.Text+"','"+TxtTelefone.Text+"');";

            // Dados do comando sql na variavel de string sql

                MySqlCommand comando = new MySqlCommand(sql,Conexao);
                // Criando variavel comando do tipo mysqlcomand, e instanciando uma classe mysqlcomand
                // com 2 parâmetros, comando, e dados da conexão

                Conexao.Open(); // Abrindo conexao
                comando.ExecuteReader(); // Executando o comando sql
                MessageBox.Show("Conexão realizada e inserção feita !"); */

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro : "+ex.Message,"Erro !!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally { 
            Conexao.Close();
                // Fechando conexão, independente se der certo ou não
            
            }


        }

        private void CarregarConteudo()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                // passado os dados para a conexao
                string sql = "select * from contato;";

                // Dados do comando sql na variavel de string sql

                Conexao.Open(); // Abrindo conexao

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                // Criando variavel comando do tipo mysqlcomand, e instanciando uma classe mysqlcomand
                // com 2 parâmetros, comando, e dados da conexão

                MySqlDataReader reader = comando.ExecuteReader();
                lst_contato.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lst_contato.Items.Add(new ListViewItem(row));


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
                // Fechando conexão, independente se der certo ou não

            }


        }

        private void ZerarConteudo()
        {
            TxtNome.Text="";
            TxtEmail.Text="";
            TxtTelefone.Text="";
            txt_buscar.Clear();
            TxtNome.Focus();
            id_contato_selecionado=null;
            btn_excluir.Visible=false;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                string query = "'%"+txt_buscar.Text+"%'";

                Conexao = new MySqlConnection(data_source);
                // passado os dados para a conexao
                string sql = "select * from contato where nome like "+query+" or email like "+query+";";

                // Dados do comando sql na variavel de string sql

                Conexao.Open(); // Abrindo conexao

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                // Criando variavel comando do tipo mysqlcomand, e instanciando uma classe mysqlcomand
                // com 2 parâmetros, comando, e dados da conexão

                MySqlDataReader reader = comando.ExecuteReader();
                lst_contato.Items.Clear();

                while (reader.Read())
                {
                    string[] row = {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lst_contato.Items.Add(new ListViewItem(row));


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
                // Fechando conexão, independente se der certo ou não

            }

        }

        private void lst_contato_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListView.SelectedListViewItemCollection lista = lst_contato.SelectedItems;

            foreach(ListViewItem item in lista)
            {
                id_contato_selecionado = int.Parse(item.SubItems[0].Text);
                TxtNome.Text = item.SubItems[1].Text;
                TxtEmail.Text = item.SubItems[2].Text;
                TxtTelefone.Text = item.SubItems[3].Text;

            }

            if (id_contato_selecionado!=null)
            {
                btn_excluir.Visible=true;
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            ZerarConteudo();

        }

        private void tsm_excluir_Click(object sender, EventArgs e)
        {
            ExcluirContato();
            
        }

        private void ExcluirContato()
        {
            try
            {
                DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir ?", "Ops, tem certeza?"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                if (confirmacao==DialogResult.Yes && id_contato_selecionado!=null)
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;
                    cmd.CommandText="delete from contato where id=@id";
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado.ToString());
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Processo realizado com sucesso !!!",
                        "Excluído!!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    CarregarConteudo();
                    ZerarConteudo();

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro : "+ex.Message, "Erro !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            ExcluirContato();
        }
    }
}
