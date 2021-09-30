import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Estoque } from '../estoque.model';
import { EstoqueService } from '../estoque.service';

@Component({
  selector: 'app-estoque-create',
  templateUrl: './estoque-create.component.html',
  styleUrls: ['./estoque-create.component.css']
})
export class EstoqueCreateComponent implements OnInit {

  // estoque: Estoque ={
  //   Produto: undefined,
  //   Fornecedor: undefined,
  //   Quantidade: 0,
  //   Valor: 0,
  //   Lote: 0
  // }

  constructor(private estoqueService: EstoqueService, private router: Router) { }

  ngOnInit(): void {
  }

  // createFornecedor(): void{
  //   this.estoqueService.create(this.estoque).subscribe(()=>{
  //     this.estoqueService.showMessage('Entrada cadastrada')
  //     this.router.navigate(['/estoques'])
  //   })

  // }
  // cancel(): void{
  //   this.router.navigate(['/fornecedores'])
  // }
}
