import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EstoqueCreateComponent } from './components/estoque/estoque-create/estoque-create.component';
import { FornecedorCreateComponent } from './components/fornecedor/fornecedor-create/fornecedor-create.component';
import { ProdutoCreateComponent } from './components/produto/produto-create/produto-create.component';
import { ProdutoUpdateComponent } from './components/produto/produto-update/produto-update.component';
import { EstoqueCrudComponent } from './views/estoque-crud/estoque-crud.component';
import { FornecedorCrudComponent } from './views/fornecedor-crud/fornecedor-crud.component';
import { HomeComponent } from './views/home/home.component'
import { ProdutoCrudComponent } from './views/produto-crud/produto-crud.component'

const routes: Routes = [
  {
    path:"",
    component: HomeComponent
  },
  {
    path:"produtos",
    component: ProdutoCrudComponent
  },
  {
    path:"produtos/update:Id",
    component: ProdutoUpdateComponent
  },
  {
    path:"produtos/create",
    component: ProdutoCreateComponent
  },
  {
    path:"fornecedores",
    component: FornecedorCrudComponent
  },
  {
    path:"fornecedores/create",
    component: FornecedorCreateComponent
  },
  {
    path:"estoques",
    component: EstoqueCrudComponent
  },
  {
    path:"estoques/create",
    component: EstoqueCreateComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
