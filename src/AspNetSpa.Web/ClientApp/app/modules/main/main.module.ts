import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';
import { MainComponent } from './main.component';
import { ProductComponent } from './components/product/product.component';
import { IndexComponent } from './components/index/index.component';
import { MainRoutingModule } from './main-routing.module';

@NgModule({
  imports: [
    CommonModule,
    HttpModule,
    MainRoutingModule
  ],
  declarations: [
    MainComponent, 
    ProductComponent, 
    IndexComponent]
})
export class MainModule { }
