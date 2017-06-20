import { ClothingComponent } from './components/clothing/clothing.component';
import { ToyComponent } from './components/toy/toy.component';
import { BookComponent } from './components/book/book.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main.component';


const routes: Routes = [{
  path: 'Main', component: MainComponent, children: [
    { path: 'Book', component: BookComponent },
    { path: 'Toy', component: ToyComponent },
    { path: 'Clothing', component: ClothingComponent }
  ]
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
  providers: []
})
export class MainRoutingModule { }

