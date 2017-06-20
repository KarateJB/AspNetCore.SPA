import { fallbackRoute } from './fallback-route.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes, PreloadAllModules } from '@angular/router';
import { HomeComponent } from './../components/home/home.component';
import { FetchDataComponent } from './../components/fetchdata/fetchdata.component';
import { CounterComponent } from './../components/counter/counter.component';
import { MainComponent } from '../modules/main/main.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
   {
       path: 'Cms',                                     
       loadChildren: '../modules/cms/cms.module#CmsModule'
   },
  fallbackRoute
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    enableTracing: true,
    // preloadingStrategy: PreloadAllModules
  })],
  exports: [RouterModule],
  providers: []
})


export class AppRoutingModule { }
