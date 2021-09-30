import { Injectable } from '@angular/core';
import { MatSnackBar }from '@angular/material/snack-bar'

import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Produto } from './produto.model';

@Injectable({
  providedIn: 'root'
})
export class ProdutoService {

  baseUrl="https://localhost:5001/api/produto"

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string): void{
    this.snackBar.open(msg, 'X',{
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top"
      
    })
  }

  create(produto: Produto): Observable<Produto>{
    return this.http.post<Produto>(`${this.baseUrl}/create`, produto)
  }

  read():Observable<Produto[]>{
    return this.http.get<Produto[]>(`${this.baseUrl}/list`)
  }

  delete(NomeProduto: string): Observable<Produto> {
    const url = `${this.baseUrl}/delete${NomeProduto}`;
    return this.http.delete<Produto>(url);
  }

}
