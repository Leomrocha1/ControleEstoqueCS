using System;

namespace API.Models
{
    public class Produto
    {
        public Produto() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public Estoque Estoque { get; set; }

        public Fornecedor Fornecedor {get; set;}

        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {NomeProduto} | Descrição: {Descricao} | Unidade de medida: {Quantidade} | Criado em: {CriadoEm}";
    }
}