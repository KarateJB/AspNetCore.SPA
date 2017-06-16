import { CmsRoutingModule } from './cms-routing.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './components/login/login.component';

@NgModule({
  imports: [
    CommonModule,
    CmsRoutingModule
  ],
  declarations: [
    LoginComponent
  ]
})
export class CmsModule { }
