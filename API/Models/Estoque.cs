using System;


namespace API.Models
{
    public class Estoque
    {
        public Estoque() => CriadoEm = DateTime.Now;

        public int Id { get; set; }

        public virtual Produto Produto { get; set; }

        public virtual Fornecedor Fornecedor {get; set;}

        public int Quantidade { get; set; }

        public double Valor { get; set; }

        public int Lote { get; set; }

        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Produto: {Produto}  | Fornecedor: {Fornecedor} | Quantidade: {Quantidade} | Valor: {Valor} | Lote: {Lote} | Criado em: {CriadoEm}";
    }
}