import { Injectable } from '@angular/core';
import { MatSnackBar }from '@angular/material/snack-bar'
import { HttpClient } from '@angular/common/http'

import { Observable } from 'rxjs';
import { Estoque } from './estoque.model';


@Injectable({
  providedIn: 'root'
})
export class EstoqueService {

  baseUrl="https://localhost:5001/api/estoque"

  constructor(private snackBar: MatSnackBar, private http : HttpClient) { }


  showMessage(msg: string): void{
    this.snackBar.open(msg, 'X',{
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top"
      
    })
  }

  create(estoque: Estoque): Observable<Estoque>{
    return this.http.post<Estoque>(`${this.baseUrl}/create`, estoque)
  }

  read():Observable<Estoque[]>{
    return this.http.get<Estoque[]>(`${this.baseUrl}/list`)
  }
}
