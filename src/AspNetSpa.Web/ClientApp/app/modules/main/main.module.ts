import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { MainRoutingModule } from './main-routing.module';
import { MainFooterComponent } from './components/main-footer/main-footer.component';
import { BookComponent } from './components/book/book.component';
import { ToyComponent } from './components/toy/toy.component';
import { ClothingComponent } from './components/clothing/clothing.component';
import { ProdCreateComponent } from './components/product/prod-create/prod-create.component';
import { ProdEditComponent } from './components/product/prod-edit/prod-edit.component';

@NgModule({
  imports: [
    CommonModule,
    HttpModule,
    FormsModule,
    MainRoutingModule
  ],
  declarations: [
    MainComponent, 
    MainFooterComponent, 
    BookComponent, 
    ToyComponent, 
    ClothingComponent, 
    ProdCreateComponent, 
    ProdEditComponent]
})
export class MainModule { }
