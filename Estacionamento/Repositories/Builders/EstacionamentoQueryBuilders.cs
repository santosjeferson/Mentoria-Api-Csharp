namespace Estacionamento.Repositories.Builders
{
    public static class EstacionamentoQueryBuilders
    {
        public const string SelectBaseEstacionamento =
       @"        
            SELECT
              e.Id,
              e.Nome,
              e.Cpf,
              e.Placa,
              e.Modelo
             
            FROM Estacionamento e 
            Where 1 = 1
       ";

        public const string WhereId =
            " And e.Id = @Id";

        public const string InsetEstacionamento =
            @"
            insert into x () values ()
        ";
    }
}
