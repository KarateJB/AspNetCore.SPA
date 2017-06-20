import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ProductComponent } from './components/product/product.component';
import { MainRoutingModule } from './main-routing.module';
import { MainFooterComponent } from './components/main-footer/main-footer.component';
import { BookComponent } from './components/book/book.component';
import { ToyComponent } from './components/toy/toy.component';
import { ClothingComponent } from './components/clothing/clothing.component';

@NgModule({
  imports: [
    CommonModule,
    HttpModule,
    MainRoutingModule
  ],
  declarations: [
    MainComponent, 
    ProductComponent, 
    MainFooterComponent, BookComponent, ToyComponent, ClothingComponent]
})
export class MainModule { }
