﻿using Stringes.Tokens;

namespace Processus.Arithmetic.Parselets
{
    internal class NameParselet : IPrefixParselet
    {
        public Expression Parse(Parser parser, Token<MathTokenType> token)
        {
            return new NameExpression(token);
        }
    }
}