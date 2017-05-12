using System;

namespace MateusViegas.GoF.AbstractFactory
{
    public interface IDocumentoFactory
    {
        RG CreateRG(string nomeCompleto, string numero, DateTime dataNascimento, string pai, string mae, DateTime dataExpedicao, DateTime dataValidade, string orgaoExpedidor, string UF);

        CPF CreateCPF(string nomeCompleto, string numero, DateTime dataNascimento);
    }
}
