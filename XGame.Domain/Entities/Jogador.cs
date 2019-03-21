using prmToolkit.NotificationPattern;
using System;
using XGame.Domain.Entities.Enum;
using XGame.Domain.Extension;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador : Notifiable
    {

        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve conter entre 6 e 32 caracteres");
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = new Guid();
            Status = EnumSituacaoJogador.EM_ANALISE;

            new AddNotifications<Jogador>(this)
                  .IfNullOrInvalidLength(x => x.Senha, 6, 32, "A senha deve conter entre 6 e 32 caracteres");

            if (IsValid())
            {
                Senha = Senha.ConvertToMD5();
            }

            AddNotifications(nome, email);

        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public EnumSituacaoJogador Status { get; private set; }

        public override string ToString()
        {
            return Nome.PrimeiroNome + " " + Nome.SegundoNome;
        }
    }
}
