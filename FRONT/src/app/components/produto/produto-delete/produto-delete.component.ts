import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { ActivatedRoute, Router } from '@angular/router';
import { Produto } from '../produto.model';
import { ProdutoService } from '../produto.service';

@Component({
  selector: 'app-produto-delete',
  templateUrl: './produto-delete.component.html',
  styleUrls: ['./produto-delete.component.css']
})
export class ProdutoDeleteComponent implements OnInit {

  produto!: Produto

  constructor(private produtoService: ProdutoService, private router: Router, private msg: MatSnackBar, private route: ActivatedRoute) { }

  ngOnInit(): void {
  }

  deleteProduto(): void {
    this.produtoService.delete(this.produto.NomeProduto).subscribe(() => {
      this.produtoService.showMessage("Produto excluido com sucesso!");
      this.router.navigate(["/produtos"]);
    });
  }

  cancel():void{
    this.router.navigate(['/produtos'])
  
  }

}
