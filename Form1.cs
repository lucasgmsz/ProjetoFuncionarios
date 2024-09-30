namespace Funcionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //4 variaveis declaradas passadando as informações do banco de dados
                const string servidor = "localhost";
                const string bancoDados = "dbFuncionarios";
                const string usuario = "root";
                const string senha = "db4dm1n";

                //declarando variavel conexaoBanco para fazer a conexao com o banco de dados
                string conexaoBanco = $"server={servidor}; user id ={usuario};database={bancoDados};password={senha}"; //string conexaoBanco = "server= + servidor +; user id = +usuario};database={bancoDados};password={senha}";

                //alterando o texto de lblTeste para dizer se ocorreu a conexao com o banco de dados
                lblTeste.Text = $"A conexão com o banco {bancoDados} foi realizada com sucesso";
            }
            catch(Exception ex) 
            {
                MessageBox("Ocorreu um erro " + ex.Message);
            }
        }
    }
}
