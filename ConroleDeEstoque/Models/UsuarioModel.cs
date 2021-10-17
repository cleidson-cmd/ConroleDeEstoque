using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ConroleDeEstoque.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            #region Conecxao com banco de dados
            var ret = false;

            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = @"server=localhost;user id=Admin; Password=123;database=controde_estoque";
                conexao.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format("select count(*) from Usuario where Login = '{0}' and Senha = '{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }
            return ret;
            #endregion
        }
    }
}