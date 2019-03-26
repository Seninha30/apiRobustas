using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Services;

namespace XGame.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServicesJogador();
            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            var add = new AdicionarJogadorRequest()
            {
                Email = "ricardoaraujosena.sena@gmail.com",
                PrimeiroNome = "Ricardo",
                SegundoNome = "Sena",
                senha = "123456"
            };
            service.AdicionarJogador(add);
            service.AutenticarJogador(request);
        }
    }
}
