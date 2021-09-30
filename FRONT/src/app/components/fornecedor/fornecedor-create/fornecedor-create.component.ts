import { Component, OnInit } from '@angular/core';
import { FornecedorService } from '../fornecedor.service';
import { Router } from '@angular/router'
import { Fornecedor } from '../fornecedor.model';

@Component({
  selector: 'app-fornecedor-create',
  templateUrl: './fornecedor-create.component.html',
  styleUrls: ['./fornecedor-create.component.css']
})
export class FornecedorCreateComponent implements OnInit {

  fornecedor: Fornecedor ={
    NomeFornecedor: '',
    CnpjFornecedor: '',
    TelFornecedor: '',
    EmailFornecedor: ''
  }


  constructor(private fornecedorService: FornecedorService, private router: Router) { }

  ngOnInit(): void {
  }

  createFornecedor(): void{
    this.fornecedorService.create(this.fornecedor).subscribe(()=>{
      this.fornecedorService.showMessage('Fornecedor cadastrado')
      this.router.navigate(['/fornecedores'])
    })

  }

  cancel(): void{
    this.router.navigate(['/fornecedores'])
  }

}
