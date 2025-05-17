using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace aulaCSharp04.BancoDados
{
    public class FuncoesBanco
    {
        public static string stringConexao()
        {
            string conexaoSQL = "Data Source=TIT0676511W11-1\\SQLEXPRESS;Initial Catalog=MyFinanceiro;Trusted_Connection=True;";
            return conexaoSQL;
        }
        public static DataTable ListarUsuarios()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conexao = new SqlConnection(stringConexao()))
            {
                conexao.Open();
                string query = "SELECT * FROM tbUsuario WHERE status_usuario = 1";
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    using (SqlDataReader leitor = comando.ExecuteReader())
                    {
                        dataTable.Load(leitor);
                    }
                }

            }
            return dataTable;
        }
        public static DataTable ConsultarUsuario(int campoCodigo)
        {
            DataTable dadosUsuario = new DataTable();
            using (SqlConnection conexao = new SqlConnection(stringConexao()))
            {
                try
                {
                    conexao.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                    // Comando SQL para consulta
                    string query = "SELECT * FROM tbUsuario WHERE tbUsuario.id_usuario = @campoCodigo";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {

                        comando.Parameters.AddWithValue("@campoCodigo", campoCodigo);
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            dadosUsuario.Load(leitor);
                        }
                    }

                    return dadosUsuario;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao conectar: {ex.Message}");
                    return null;
                }

            }
        }

        public static bool RemoverUsuario (int campoCodigo)
        {
            using (SqlConnection conexao = new SqlConnection(stringConexao()))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE tbUsuario SET status_usuario = 0 WHERE id_usuario = @campoCodigo";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@campoCodigo", campoCodigo);

                        int linhasAfetadas = comando.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao remover o usuário: {ex.Message}");
                    return false;
                }
            }
        }

        public static bool CadastroUsuario( int tipoAcao
                                          , string campoNome
                                          , string campoEmail
                                          , string campoDocumento
                                          , string campoCelular
                                          , string campoSenha
                                          , int campoTipoUsuario
                                          , int campoCodigo
                                          )
        {

            if (tipoAcao == 1) {
                using (SqlConnection conexao = new SqlConnection(stringConexao()))
                {
                    try
                    {
                        conexao.Open();
                        string query = "INSERT INTO tbUsuario ( tp_usuario, nome_usuario, email_usuario, documento_usuario, celular_usuario, senha_usuario) " +
                            "VALUES (@campoTipoUsuario, @campoNome, @campoEmail, @campoDocumento, @campoCelular, @campoSenha)";

                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@campoTipoUsuario", campoTipoUsuario);
                            comando.Parameters.AddWithValue("@campoNome", campoNome);
                            comando.Parameters.AddWithValue("@campoEmail", campoEmail);
                            comando.Parameters.AddWithValue("@campoDocumento", campoDocumento);
                            comando.Parameters.AddWithValue("@campoCelular", campoCelular);
                            comando.Parameters.AddWithValue("@campoSenha", campoSenha);

                            int linhasAfetadas = comando.ExecuteNonQuery();
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao inserir usuário: {ex.Message}");
                        return false;
                    }
                }
            }
            else {
                using (SqlConnection conexao = new SqlConnection(stringConexao()))
                {
                    try
                    {
                        conexao.Open();
                        string query = "UPDATE tbUsuario " +
                            "SET tp_usuario = @campoTipoUsuario" +
                            ", nome_usuario = @campoNome" +
                            ", email_usuario = @campoEmail" +
                            ", documento_usuario = @campoDocumento" +
                            ", celular_usuario = @campoCelular" +
                            ", senha_usuario = @campoSenha" +
                            " WHERE tbUsuario.id_usuario = @campoCodigo";

                        using (SqlCommand comando = new SqlCommand(query, conexao))
                        {
                            comando.Parameters.AddWithValue("@campoTipoUsuario", campoTipoUsuario);
                            comando.Parameters.AddWithValue("@campoNome", campoNome);
                            comando.Parameters.AddWithValue("@campoEmail", campoEmail);
                            comando.Parameters.AddWithValue("@campoDocumento", campoDocumento);
                            comando.Parameters.AddWithValue("@campoCelular", campoCelular);
                            comando.Parameters.AddWithValue("@campoSenha", campoSenha);
                            comando.Parameters.AddWithValue("@campoCodigo", campoCodigo);

                            int linhasAfetadas = comando.ExecuteNonQuery();
                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao inserir usuário: {ex.Message}");
                        return false;
                    }
                }
            }
            
        }

    }
}
