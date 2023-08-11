using Estacionamento.Data;

namespace Estacionamento.Contracts
{
    public interface IEstacionamentoRepository
    {
        Task<IEnumerable<EstacionamentoDto>> GetEstacionamento();



        //Task<bool> InsertEstacionamento();
        //Task<bool> UpdateEstacionamento();
        //Task<bool> DeleteEstacionamento(int id);
    }
}