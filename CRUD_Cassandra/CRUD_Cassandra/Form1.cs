using Cassandra;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace CRUD_Cassandra
{
    public partial class Form1 : Form
    {
        private ISession session;
        private Cluster cluster;

        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            
            //ConnectToCassandra();
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            //conectar ao Cassandra
            //ConnectToCassandra();

            // Criar keyspace se não existir
            string createKeyspaceQuery = "CREATE KEYSPACE IF NOT EXISTS my_keyspace WITH replication = {'class': 'SimpleStrategy', 'replication_factor': '1'}";
            session.Execute(createKeyspaceQuery);

            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            // Criar tabela se não existir
            string createTableQuery = "CREATE TABLE IF NOT EXISTS my_table (id UUID PRIMARY KEY, name text, email text)";
            session.Execute(createTableQuery);

            MessageBox.Show("Tabela criada com sucesso");


            //desconectar
            //DisconnectToCassandra();


        }

        private void ConnectToCassandra()
        {
            cluster = Cluster.Builder()
                .AddContactPoint("localhost")
                .WithPort(9042)
                .Build();
            session = cluster.Connect();
            // Verificar a conexão
            MessageBox.Show("Connected to cluster: " + cluster.Metadata.ClusterName);
        }

        private void DisconnectToCassandra()
        {
            session.Dispose();
            cluster.Dispose();
            MessageBox.Show("Desconectado do banco cassandra");
        }

        private void Ler_Click(object sender, EventArgs e)
        {
            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            string query = "SELECT * FROM my_table";
            var result = session.Execute(query);

            dataGridView1.Rows.Clear();

            foreach (var row in result)
            {
                // Adicionar os dados às linhas do DataGridView
                dataGridView1.Rows.Add(row.GetValue<Guid>("id"), row.GetValue<string>("name"), row.GetValue<string>("email"));
            }

            MessageBox.Show("Tabela carregada com sucesso!");
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            // Gerar um UUID para a coluna "id"
            Guid id = Guid.NewGuid();

            string query = $"INSERT INTO my_table (id, name, email) VALUES ({id}, 'Rafael', 'rafael@gmail.com')";
            session.Execute(query);

            MessageBox.Show("dados inseridos");
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            // Verificar se alguma linha está selecionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string id = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                string query = $"UPDATE my_table SET email = 'matheus@gmail.com', name = 'Matheus' WHERE id = {id}";
                session.Execute(query);
                MessageBox.Show("Dados atualizados com sucesso.");
            }
            else
            {
                MessageBox.Show("Selecione uma linha para atualizar.");
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            string query = $"TRUNCATE my_table";
            session.Execute(query);

            MessageBox.Show("Tabela Limpa");
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            // Usar o keyspace criado
            string useKeyspaceQuery = "USE my_keyspace";
            session.Execute(useKeyspaceQuery);

            string dropTableQuery = "DROP TABLE IF EXISTS my_keyspace.my_table;";
            session.Execute(dropTableQuery);
            MessageBox.Show("Tabela deletada!");
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            ConnectToCassandra();
        }

        private void Desconectar_Click(object sender, EventArgs e)
        {
            DisconnectToCassandra();
        }
    }
}