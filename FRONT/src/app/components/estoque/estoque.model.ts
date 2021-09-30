import { Fornecedor } from "../fornecedor/fornecedor.model";
import { Produto } from "../produto/produto.model";

export interface Estoque{
    Id?: number
    Produto: Produto
    Fornecedor: Fornecedor
    Quantidade: number 
    Valor: number
    Lote: number
}