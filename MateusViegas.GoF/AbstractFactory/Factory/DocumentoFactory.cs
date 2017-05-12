using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.AbstractFactory
{
    public class DocumentoFactory : IDocumentoFactory
    {
        public RG CreateRG(string nomeCompleto, string numero, DateTime dataNascimento, string pai, string mae, DateTime dataExpedicao, DateTime dataValidade, string orgaoExpedidor, string uf)
        {
            return new RG()
            {
                NomeCompleto = nomeCompleto,
                Numero = numero,
                DataNascimento = dataNascimento,
                Pai = pai,
                Mae = mae,
                DataExpedicao = dataExpedicao, 
                DataValidade = dataValidade,
                OrgaoExpedidor = orgaoExpedidor,
                UF = uf
            };
        }

        public CPF CreateCPF(string nomeCompleto, string numero, DateTime dataNascimento)
        {
            return new CPF()
            {
                NomeCompleto = nomeCompleto,
                Numero = numero,
                DataNascimento = dataNascimento
            };
        }

    }
}
