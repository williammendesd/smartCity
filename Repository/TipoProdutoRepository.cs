using Oracle.ManagedDataAccess.Client;
using SmartCity.Models;
using SmartCity.Repository.Context;

namespace SmartCity.Repository

{
    public class TipoProdutoRepository
{
        // INCLUSÃO DataBaseContext - Entity
        private DataBaseContext context;

        //INSTÂNCIA do DataBaseContext
        public TipoProdutoRepository()
        {
            context = new DataBaseContext();
        }

        public IList<TipoProduto> Listar()
        {
            return context.TipoProduto.ToList();
            // ANTES DO ENTITY
            //IList<TipoProduto> lista = new List<TipoProduto>();

            //var connectionString = new ConfigurationBuilder()
            //                            .SetBasePath(Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json")
            //                            .Build().GetConnectionString("FiapSmartCityConnection");

            //using (OracleConnection connection = new OracleConnection(connectionString))
            //{
            //    String query =
            //        "SELECT IDTIPO, DESCRICAOTIPO, COMERCIALIZADO FROM TIPOPRODUTO ";

            //    OracleCommand command = new OracleCommand(query, connection);
            //    connection.Open();
            //    OracleDataReader dataReader = command.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        // Recupera os dados
            //        TipoProduto tipoProd = new TipoProduto();
            //        tipoProd.IdTipo = Convert.ToInt32(dataReader["IDTIPO"]);
            //        tipoProd.DescricaoTipo = dataReader["DESCRICAOTIPO"].ToString();
            //        tipoProd.Comercializado = dataReader["COMERCIALIZADO"].Equals("1");

            //        // Adiciona o modelo da lista
            //        lista.Add(tipoProd);
            //    }

            //    connection.Close();

            //} // Finaliza o objeto connection

            //// Retorna a lista
            //return lista;
        }

        public TipoProduto Consultar(int id)
        {
            return context.TipoProduto.Find(id);
            //TipoProduto tipoProd = new TipoProduto();

            //var connectionString = new ConfigurationBuilder()
            //                            .SetBasePath(Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json")
            //                            .Build().GetConnectionString("FiapSmartCityConnection");

            //using (OracleConnection connection = new OracleConnection(connectionString))
            //{
            //    String query =
            //        "SELECT IDTIPO, DESCRICAOTIPO, COMERCIALIZADO FROM TIPOPRODUTO WHERE IDTIPO = :IDTIPO ";

            //    OracleCommand command = new OracleCommand(query, connection);
            //    command.Parameters.Add("IDTIPO", id);
            //    connection.Open();

            //    OracleDataReader dataReader = command.ExecuteReader();

            //    while (dataReader.Read())
            //    {
            //        // Recupera os dados
            //        tipoProd.IdTipo = Convert.ToInt32(dataReader["IDTIPO"]);
            //        tipoProd.DescricaoTipo = dataReader["DESCRICAOTIPO"].ToString();
            //        tipoProd.Comercializado = dataReader["COMERCIALIZADO"].Equals("1");
            //    }

            //    connection.Close();

            //} // Finaliza o objeto connection

            //// Retorna a lista
            //return tipoProd;
        }

        public void Inserir(TipoProduto tipoProduto)
        {
 
            context.TipoProduto.Add(tipoProduto);
            context.SaveChanges();
            //var connectionString = new ConfigurationBuilder()
            //                            .SetBasePath(Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json")
            //                            .Build().GetConnectionString("FiapSmartCityConnection");

            //using (OracleConnection connection = new OracleConnection(connectionString))
            //{
            //    String query =
            //        "INSERT INTO TIPOPRODUTO ( DESCRICAOTIPO, COMERCIALIZADO ) VALUES ( :descr, :comerc ) ";

            //    OracleCommand command = new OracleCommand(query, connection);

            //    // Adicionando o valor ao comando
            //    command.Parameters.Add("descr", tipoProduto.DescricaoTipo);
            //    command.Parameters.Add("comerc", Convert.ToInt32(tipoProduto.Comercializado));

            //    // Abrindo a conexão com  o Banco
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();

            //}
        }

        public void Alterar(TipoProduto tipoProduto)
        {
            context.TipoProduto.Update(tipoProduto);
            context.SaveChanges();
            //var connectionString = new ConfigurationBuilder()
            //                            .SetBasePath(Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json")
            //                            .Build().GetConnectionString("FiapSmartCityConnection");

            //using (OracleConnection connection = new OracleConnection(connectionString))
            //{
            //    String query =
            //        "UPDATE TIPOPRODUTO SET DESCRICAOTIPO = :descr , COMERCIALIZADO = :comerc WHERE IDTIPO = :id  ";

            //    OracleCommand command = new OracleCommand(query, connection);

            //    // Adicionando o valor ao comando
            //    command.Parameters.Add("descr", tipoProduto.DescricaoTipo);
            //    command.Parameters.Add("comerc", Convert.ToInt32(tipoProduto.Comercializado));
            //    command.Parameters.Add("id", tipoProduto.IdTipo);

            //    // Abrindo a conexão com  o Banco
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}
        }

        public void Excluir(int id)
        {
            // Objeto só com Id;
            var tipoProduto = new TipoProduto()
            {
                IdTipo = id
            };
            context.TipoProduto.Remove(tipoProduto);
            context.SaveChanges();



            //var connectionString = new ConfigurationBuilder()
            //                            .SetBasePath(Directory.GetCurrentDirectory())
            //                            .AddJsonFile("appsettings.json")
            //                            .Build().GetConnectionString("FiapSmartCityConnection");

            //using (OracleConnection connection = new OracleConnection(connectionString))
            //{
            //    String query =
            //        "DELETE TIPOPRODUTO WHERE IDTIPO = :id  ";

            //    OracleCommand command = new OracleCommand(query, connection);

            //    // Adicionando o valor ao comando
            //    command.Parameters.Add("id", id);

            //    // Abrindo a conexão com  o Banco
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //}

        }
    }
}


