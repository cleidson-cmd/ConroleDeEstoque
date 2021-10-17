using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConroleDeEstoque.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            #region Conecxao com banco de dados
            var ret = false;

            using (MySqlConnection conexao = new MySqlConnection())
            {
                conexao.ConnectionString = @"server=localhost;user id=Admin; Password=123;database=controde_estoque";
                conexao.Open();

                using (MySqlCommand comando = new MySqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format("select count(*) from usuario where Login = '{0}' and Senha = '{1}'", login, senha);
                    ret = (Convert.ToInt32(comando.ExecuteScalar()) > 0);
                }
            }
            return ret;
            #endregion
        }
    }
}