using System;

namespace API.Models
{
    public class Fornecedor
    {
        public Fornecedor() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public string NomeFornecedor { get; set; }

        public string CnpjFornecedor { get; set; }

        public string TelFornecedor { get; set; }

        public string EmailFornecedor { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {NomeFornecedor} | CNPJ Fornecedor: {CnpjFornecedor} | Tel Fornecedor: {TelFornecedor} | Email Fornecedor: {EmailFornecedor} | Criado em: {CriadoEm}";
    }
}