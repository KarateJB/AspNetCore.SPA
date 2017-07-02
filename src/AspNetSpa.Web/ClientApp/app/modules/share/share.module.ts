import { ToastsManager } from 'ng2-toastr/src/toast-manager';
import { ProdService } from './service/prod.service';
import { RestapiConfig } from './../../config/restapi.config.dev';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  imports: [
    CommonModule
  ],
  providers:[
    RestapiConfig,
    ProdService
  ],
  declarations: []
})
export class ShareModule { }
