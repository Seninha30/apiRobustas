namespace XGame.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {
        public string PrimeiroNome { get; set; }
        public string Email { get; set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador v)
        {
            return new AutenticarJogadorResponse()
            {
                Email = v.Email.Endereco,
                PrimeiroNome = v.Nome.PrimeiroNome
            };
        }
    }
}
