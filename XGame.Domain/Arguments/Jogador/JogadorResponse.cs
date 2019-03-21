using System;

namespace XGame.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid Id { get; set; }
        public string NomeCompleto { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador v)
        {
            return new JogadorResponse()
            {
                Email = v.Email.Endereco,
                Id = v.Id,
                NomeCompleto = v.Nome.ToString(),
                PrimeiroNome = v.Nome.PrimeiroNome,
                SegundoNome = v.Nome.SegundoNome,
                Status = v.Status.ToString()
            };
        }
    }
}
