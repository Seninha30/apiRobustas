using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGame.Domain.Resources;

namespace XGame.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string segundoNome)
        {
            PrimeiroNome = primeiroNome;
            SegundoNome = segundoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50, Message.X0_E_OBRIOGATORIO_E_DEVE_CONTER_ENTRE_X_E_Y_CARACTERES.ToFormat(""))
                .IfNullOrInvalidLength(x => x.SegundoNome, 3, 50, Message.X0_E_OBRIOGATORIO_E_DEVE_CONTER_ENTRE_X_E_Y_CARACTERES.ToFormat(""));
        }

        public string PrimeiroNome { get; private set; }
        public string SegundoNome { get; private set; }
    }
}
