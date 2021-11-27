using System;


namespace API.Models
{
    public class Estoque
    {
        public Estoque() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public string TipoEstoque { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Valor: {TipoEstoque} | Criado em: {CriadoEm}";
    }
}