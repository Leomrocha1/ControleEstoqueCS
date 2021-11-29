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

  estoque: Estoque ={
    TipoEstoque: ""
  }

  constructor(private estoqueService: EstoqueService, private router: Router) { }

  ngOnInit(): void {
  }

  createEstoque(): void{
    this.estoqueService.create(this.estoque).subscribe(()=>{
      this.estoqueService.showMessage('Estoque cadastrado')
      this.router.navigate(['/estoques'])
    })

  }
  cancel(): void{
    this.router.navigate(['/estoques'])
  }
}
