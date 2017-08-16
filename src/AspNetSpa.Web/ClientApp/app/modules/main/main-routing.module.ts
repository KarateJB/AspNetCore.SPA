import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main.component';
import { ProdCreateComponent } from './components/product/prod-create/prod-create.component';
import { BookComponent } from "./components/product/prod/book.component";
import { ToyComponent } from "./components/product/prod/toy.component";
import { ClothingComponent } from "./components/product/prod/clothing.component";


const routes: Routes = [{
  path: 'Main', component: MainComponent, children: [
    { path: 'Book', component: BookComponent },
    { path: 'Toy', component: ToyComponent },
    { path: 'Clothing', component: ClothingComponent },
    { path: 'Prod/Create', component: ProdCreateComponent },
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  providers: []
})
export class MainRoutingModule { }

