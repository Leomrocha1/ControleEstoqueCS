using System;

namespace API.Models
{
    public class Produto
    {
        public Produto() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public string UnidadeMedida { get; set; }

        public string TipoEstoque {get; set;}
        
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {NomeProduto} | Descrição: {Descricao} | Unidade de medida: {UnidadeMedida} | Criado em: {CriadoEm}";
    }
}