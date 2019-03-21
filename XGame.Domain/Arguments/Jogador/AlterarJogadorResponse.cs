using System;

namespace XGame.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse
    {
        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public static explicit operator AlterarJogadorResponse(Entities.Jogador v)
        {

            return new AlterarJogadorResponse()
            {
                Email = v.Email.Endereco,
                Message = "Dados Alterador com sucesso",
                Id = v.Id,
                PrimeiroNome = v.Nome.PrimeiroNome,
                SegundoNome = v.Nome.SegundoNome
            };
        }
    }
}
