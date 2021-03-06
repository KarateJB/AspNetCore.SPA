import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';

import { RestapiConfig } from './../../config/restapi.config.dev';
import { ProdService } from './../share/service/prod.service';
import { MainComponent } from './main.component';
import { MainRoutingModule } from './main-routing.module';
import { MainFooterComponent } from './components/main-footer/main-footer.component';
import { ProdCreateComponent } from './components/product/prod-create/prod-create.component';
import { ProdEditComponent } from './components/product/prod-edit/prod-edit.component';
import { BookComponent } from './components/product/prod/book.component';
import { ClothingComponent } from './components/product/prod/clothing.component';
import {ToyComponent} from './components/product/prod/toy.component';

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
