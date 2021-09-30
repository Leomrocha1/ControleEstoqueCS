import { Injectable } from '@angular/core';
import { MatSnackBar }from '@angular/material/snack-bar'
import { HttpClient } from '@angular/common/http'
import { Fornecedor } from './fornecedor.model';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})


export class FornecedorService {
  
  baseUrl="https://localhost:5001/api/fornecedor"


  constructor(private snackBar: MatSnackBar, private http : HttpClient) { }

  showMessage(msg: string): void{
    this.snackBar.open(msg, 'X',{
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top"
      
    })
  }


  create(fornecedor: Fornecedor): Observable<Fornecedor>{
    return this.http.post<Fornecedor>(`${this.baseUrl}/create`, fornecedor)
  }

  read():Observable<Fornecedor[]>{
    return this.http.get<Fornecedor[]>(`${this.baseUrl}/list`)
  }
}
