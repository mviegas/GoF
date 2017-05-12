using System;
using System.Collections.Generic;
using System.Text;

namespace MateusViegas.GoF.Builder
{
    public class RGBuilder
    {
        private string _nomeCompleto;
        private string _numero;
        private DateTime _dataNascimento;
        private string _pai;
        private string _mae;
        private DateTime _dataExpedicao;
        private DateTime? _dataValidade;
        private string _orgaoExpedidor;
        private string _uf;

        public RGBuilder NomeCompleto(string nomeCompleto)
        {
            _nomeCompleto = nomeCompleto;
            return this;
        }
        public RGBuilder Numero(string numero)
        {
            _numero = numero;
            return this;
        }
        public RGBuilder DataNascimento(DateTime dataNascimento)
        {
            _dataNascimento = dataNascimento;
            return this;
        }
        public RGBuilder Pai(string pai)
        {
            _pai = pai;
            return this;
        }
        public RGBuilder Mae(string mae)
        {
            _mae = mae;
            return this;
        }
        public RGBuilder DataExpedicao(DateTime dataExpedicao)
        {
            _dataExpedicao = dataExpedicao;
            return this;
        }
        public RGBuilder DataValidade(DateTime? dataValidade)
        {
            _dataValidade = dataValidade;
            return this;
        }
        public RGBuilder OrgaoExpedidor(string orgaoExpedidor)
        {
            _orgaoExpedidor = orgaoExpedidor;
            return this;
        }
        public RGBuilder UF(string uf)
        {
            _uf = uf;
            return this;
        }

        public RG Build()
        {
            return new RG()
            {
                NomeCompleto = _nomeCompleto,
                Numero = _numero,
                DataNascimento = _dataNascimento,
                Pai = _pai,
                Mae = _mae,
                DataExpedicao = _dataExpedicao,
                DataValidade = _dataValidade,
                OrgaoExpedidor = _orgaoExpedidor,
                UF = _uf
            };
        }

    }
}
