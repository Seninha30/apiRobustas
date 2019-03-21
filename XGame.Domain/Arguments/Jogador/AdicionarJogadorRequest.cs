﻿using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Email { get; set; }
        public string senha { get; set; }
    }
}