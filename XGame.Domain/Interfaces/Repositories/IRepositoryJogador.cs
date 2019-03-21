using System;
using System.Collections.Generic;
using XGame.Domain.Arguments.Jogador;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);

        Jogador AdicionarJogador(Jogador request);

        void AlterarJogador(Jogador request);

        IEnumerable<Jogador> Listar();

        Jogador ObterId(Guid id);
    }
}
