import { MainRoutingModule } from './main-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ProductComponent } from './components/product/product.component';
import { IndexComponent } from './components/index/index.component';

@NgModule({
  imports: [
    CommonModule,
    MainRoutingModule
  ],
  declarations: [
    MainComponent, 
    ProductComponent, 
    IndexComponent]
})
export class MainModule { }
