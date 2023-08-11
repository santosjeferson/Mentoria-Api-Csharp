using Dapper;
using Estacionamento.Contracts;
using Estacionamento.Data;
using Estacionamento.Repositories.Builders;
using System.Data;

namespace Estacionamento.Repositories
{
    public class EstacionamentoRepository : IEstacionamentoRepository
    {
        private readonly IDbConnection _dbConnection;

        public EstacionamentoRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<EstacionamentoDto>> GetEstacionamento()
        {
            //string query = "Select * from Estacionamento";
            string query = $"{EstacionamentoQueryBuilders.SelectBaseEstacionamento}{EstacionamentoQueryBuilders.WhereId}";

            return await _dbConnection.QueryAsync<EstacionamentoDto>(query, new { Id = 3 });
        }

        //public async Task<bool> InsertEstacionamento()
        //{
        //    string query = "insert into estacionamento (nome,cpf, placa, modelo) values ('corola','55555555555','ora5d86', 'toyota')";

        //    var saved = await _dbConnection.ExecuteAsync(query);

        //    return saved > 0;
        //}

        //public async Task<bool> UpdateEstacionamento()
        //{
        //    string query = $"update estacionamento set  nome = 'update', cpf = '123456789',placa = '654', modelo = 'teste'";

        //    var updated = await _dbConnection.ExecuteAsync(query);

        //    return updated > 0;
        //}
        //public async Task<bool> DeleteEstacionamento(int id)
        //{
        //    string query = $"delete estacionamento where id = {id}";

        //    var delete = await _dbConnection.ExecuteAsync(query);

        //    return delete > 0;
        //}
    }
}
